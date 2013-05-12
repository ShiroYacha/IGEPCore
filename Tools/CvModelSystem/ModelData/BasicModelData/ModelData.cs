using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;
using MIConvexHull;

namespace CvModelSystem.Structure
{
    /// <summary>
    /// Abstract base class for all serializable model data.
    /// </summary>
    [XmlType("ModelData")]
    [XmlInclude(typeof(ColorModelData2)), XmlInclude(typeof(ColorModelData3))]
    public abstract class ModelData : IComponentDataTreeRoot
    {
        #region Fields
        [ComponentData(ComponentNature.Leaf)]
        protected string description;
        [ComponentData(ComponentNature.Leaf)]
        protected string modelPath;
        [ComponentData(ComponentNature.Leaf)]
        protected string objectName;
        #endregion

        #region Ctors

        /// <summary>
        /// Protected constructor.
        /// </summary>
        /// <param name="objectName">The name of the object.</param>
        /// <param name="modelPath">The path of the model file.</param>
        /// <param name="description">The description of the model data.</param>
        protected ModelData(string objectName, string modelPath, string description)
        {
            this.description = description;
            this.modelPath = modelPath;
            this.objectName = objectName;
        }
        /// <summary>
        /// Protected constructor.
        /// </summary>
        protected ModelData()
        {
        } 

        #endregion

        #region Properties

        /// <summary>
        /// The name of the object.
        /// </summary>
        [XmlElement("ObjectName")]
        public string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }
        /// <summary>
        /// The path of the model file.
        /// </summary>
        [XmlElement("ModelPath")]        
        public string ModelPath
        {
            get { return modelPath; }
            set { modelPath = value; }
        }
        /// <summary>
        /// The description of the model data.
        /// </summary>
        [XmlElement("Dimension")]
        public abstract int Dimension
        {
            get;
        }
        /// <summary>
        /// A brief description of  the model data.
        /// </summary>
        [XmlElement("Description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [XmlIgnore]
        public IComponentDataTreeAdapter ComponentAdapter { get; set; }

        #endregion

        #region Methods

        #region Internal methods
        /// <summary>
        /// Append new data in existing xml file.
        /// </summary>
        /// <param name="xmlSourcePath">Existing xml file path.</param>
        /// <param name="objectToAppend">Object to serialize and append.</param>
        /// <param name="indicatorName">Name of the indicator.</param>
        protected internal void AppendToXmlFile<T>(string xmlSourcePath, T objectToAppend, string indicatorName)
        {
            XElement xRootElement = XElement.Load(xmlSourcePath);
            XElement xElement = XElement.Parse(objectToAppend.Serialize<T>());
            xElement.SetAttributeValue(SerializationExtensions.xmlIndicator, indicatorName);
            xRootElement.Add(xElement);
            StringWriter sWriter = new StringWriter();
            xRootElement.Save(xmlSourcePath);
        }
        #endregion

        #endregion
    }

    internal class Vertex2 : IVertex
    {
        internal Vertex2(Vector2 vector2)
        {
            Position = new double[2] { vector2.X, vector2.Y };
        }

        internal Vertex2(Vector3 vector3)
        {
            Position = new double[2] { vector3.X, vector3.Y };
        }

        public double[] Position { get; set; }

        public Vector2 ToVector2()
        {
            return new Vector2((float)Position[0], (float)Position[1]);
        }
    }

}
