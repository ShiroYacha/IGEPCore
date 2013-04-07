using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Resources;
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
}
