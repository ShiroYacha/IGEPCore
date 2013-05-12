using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using IgepCore.CV.InputSystem;

namespace IgepCore.CV.ProcessSystem
{
    public class NativeLayerProcessSystem:BasicProcessSystem
    {
        private List<ILayer> layerSequenceList;

        public List<ILayer> LayerSequenceList { get { return layerSequenceList; } }

        public NativeLayerProcessSystem():base()
        {
            this.layerSequenceList=GenerateLayerSequence();
        }

        public override void Start(IInputSystem inputSystem)
        {
            // Handle event handler
            inputHandler.onProceed += inputHandler_onProceed;
            // Start
            base.Start(inputSystem);
        }

        private Dictionary<string, object> inputHandler_onProceed(Dictionary<string, object> argsDict)
        {
            Dictionary<string, object> result = layerSequenceList[0].Proceed(argsDict);
            int currentSeq = 1;
            while (currentSeq < layerSequenceList.Count)
            {
                result = layerSequenceList[currentSeq].Proceed(result);
                currentSeq++;
            }
            return result;
        }

        private List<ILayer> GenerateLayerSequence()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            // Find layer builder
            var builderTypes = from type in asm.GetTypes()
                        where Attribute.IsDefined(type, typeof(LayerBuilderAttribute))
                        select type;
            if (builderTypes.Count() == 0)
                throw new Exception("No layer builder is defined.");
            else if (builderTypes.Count() > 1)
                throw new Exception("More than 1 layer builder are defined.");
            // Build layers
            var layers = from layerType in builderTypes.First().GetNestedTypes()
                         where Attribute.IsDefined(layerType, typeof(LayerAttribute))
                         orderby (layerType.GetCustomAttributes(typeof(LayerAttribute), false)[0] as LayerAttribute).Sequence ascending
                         select Activator.CreateInstance(layerType) as ILayer;
            return layers.ToList<ILayer>();
        }
    }
}
