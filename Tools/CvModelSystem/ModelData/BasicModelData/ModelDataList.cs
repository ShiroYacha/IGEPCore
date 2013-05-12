using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem.Structure
{
    [XmlRoot("ModelDataList")]
    [XmlInclude(typeof(ModelData))] // include type class Person
    public class ModelDataList<T> where T:ModelData
    {
        [XmlArray("ModelDataArray")]
        [XmlArrayItem("ModelDataObject")]
        public List<T> DataList = new List<T>();

        [XmlElement("Listname")]
        public string Listname { get; set; }

        // Konstruktoren 
        public ModelDataList() { }

        public ModelDataList(string name)
        {
            this.Listname = name;
        }

        public void AddModel(T modelData)
        {
            DataList.Add(modelData);
        }

        /// <summary>
        /// Serialize model data to xml file, if the file exists append to it as list.
        /// </summary>
        /// <param name="xmlPath">Xml file path to save.</param>
        public void SaveToXml(string xmlPath)
        {
            Type[] modelDataTypes = { typeof(ColorModelData2), typeof(ColorModelData3), typeof(ColorConvexHull2) };
            XmlSerializer serializer = new XmlSerializer(typeof(ModelDataList<T>), modelDataTypes);
            FileStream fs = new FileStream(xmlPath, FileMode.Create);
            serializer.Serialize(fs, this);
            fs.Close(); 
        }

        /// <summary>
        /// Deserialize model data from xml file.
        /// </summary>
        /// <param name="xmlPath">Xml file path to load.</param>
        public static ModelDataList<T> CreateListFromXml(string xmlPath)
        {
            using (var stream = System.IO.File.OpenRead(xmlPath))
            {
                Type[] modelDataTypes = { typeof(ColorModelData2), typeof(ColorModelData3), typeof(ColorConvexHull2) };
                XmlSerializer serializer = new XmlSerializer(typeof(ModelDataList<T>), modelDataTypes);
                ModelDataList<T> deserializedObj = serializer.Deserialize(stream) as ModelDataList<T>;
                return deserializedObj;
            }
        }
    }

}
