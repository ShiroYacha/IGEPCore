using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Emgu.CV;
using Emgu.CV.Structure;

namespace CvModelSystem
{
    public static class SerializationExtensions
    {
        public const string xmlIndicator = "Indicator";

        public static string Serialize<T>(this T obj)
        {
            var serializer = new DataContractSerializer(obj.GetType());
            using (var writer = new StringWriter())
            using (var stm = new XmlTextWriter(writer))
            {
                serializer.WriteObject(stm, obj);
                return writer.ToString();
            }
        }

        public static T Deserialize<T>(this string serialized)
        {
            var serializer = new DataContractSerializer(typeof(T));
            using (var reader = new StringReader(serialized))
            using (var stm = new XmlTextReader(reader))
            {
                return (T)serializer.ReadObject(stm);
            }
        }

        public static T DeserializeXmlNode<T>(this string serialized, string nodeName, string attributeValue)
        {
            int attributePos = serialized.IndexOf(xmlIndicator + "=\"" + attributeValue);
            if (attributePos != -1)
            {
                int startPos = serialized.LastIndexOf("<" + nodeName, attributePos);
                int endPos = serialized.IndexOf("</" + nodeName + ">", attributePos);
                String test= serialized.Substring(startPos, endPos - startPos + nodeName.Length+3);
                return test.Deserialize<T>();
            }
            else return default(T);
        }
    }
}
