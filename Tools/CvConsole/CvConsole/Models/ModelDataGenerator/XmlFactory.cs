using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace CvConsole
{
	public static class XmlReflectionFactory<T>
	{
		public static T CreateFromXml(string xmlPath,string concretType)
		{
	        return default(T);
		}
	}
	
	public static class FilePath
	{
	    public static string GetFilePath(string folderName, string fileName)
	    {
	        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
	        string relativePath = Path.Combine(assemblyLocation, "../../../../" + folderName);
	        string contentPath = Path.GetFullPath(relativePath);
	        return fileName != "" ? contentPath + "\\" + fileName : contentPath;
	    }
	}
}
