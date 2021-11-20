using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Bot
{
    class Debug
    {
        public static string debugString = string.Empty;
        public static List<string> inputs = new List<string>();
        public static void Log(MethodBase method, int type, bool system, string text)
        {

            // types:
            // 0 = default
            // 1 = called
            // 2 = started

            if (text.Replace(" ", "").Length != 0)
            {
                string prefix = string.Empty;
                DateTime now = DateTime.Now;
                var culture = new CultureInfo("ru-RU");
                if (!system && type == 0)
                {
                    inputs.Add(text);
                }

                if (system)
                {
                    prefix = "SYSTEM";
                }
                else if (!system)
                {
                    prefix = "USER";
                }

                if (type == 0)
                {
                    debugString += "[" + prefix + "] [" + now.ToString(culture) + "] " + method.Name + "()=" + text + "\n";
                }

                if (type == 1)
                {
                    debugString += "[" + prefix + "] [" + now.ToString(culture) + "] " + method.Name + "()=" + text + " CALLED\n";
                }

                if (type == 2)
                {
                    debugString += "[" + prefix + "] [" + now.ToString(culture) + "] " + method.Name + "()=" + text + " STARTED\n";
                }
            }
        }
    }
}
