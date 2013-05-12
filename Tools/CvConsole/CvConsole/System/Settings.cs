using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IgepCore.CV.InputSystem;

namespace CvConsole
{
    public class Setting
    {
        public String InputType { get; set; }
        public String SourceType { get; set; }
        public String[] Source { get; set; }
        public List<string> Models { get; set; }
    }

    public static class SystemSettings
    {
        public static Setting Setting { get; set; }
    }
}
