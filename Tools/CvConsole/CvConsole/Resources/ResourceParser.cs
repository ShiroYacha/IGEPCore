using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Globalization;
using System.Resources;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace CvConsole
{
    public class ResourceParser
    {
        private ResourceManager resourceManager;
        private CultureInfo cultureInfo;

        public ResourceParser(string resourceName, string cultureInfoCode)
        {
            resourceManager = new ResourceManager("CvConsole.Resources." + resourceName, Assembly.GetExecutingAssembly());
            cultureInfo = new CultureInfo(cultureInfoCode);
        }

        public T GetData<T>(string dataName)
        {
            string dataString = resourceManager.GetString(dataName);
            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter != null)
            {
                return (T)converter.ConvertFromString(null,cultureInfo,dataString);
            }
            return default(T);
        }
    }

    public static class StaticResources
    {
        public static string GetFolderPathFromBin(params string[] folderArray)
        {
            const string SEPERATOR = @"/";
            string folderPath = Assembly.GetExecutingAssembly().CodeBase.Substring(8);
            folderPath = folderPath.Remove(folderPath.IndexOf(@"/CvConsole.EXE"));
            for (int i = 0; i < folderArray.Length; i++)
                folderPath += SEPERATOR + folderArray[i];
            folderPath = folderPath.Replace('/', '\\');
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
            return folderPath;
        }
    }
}
