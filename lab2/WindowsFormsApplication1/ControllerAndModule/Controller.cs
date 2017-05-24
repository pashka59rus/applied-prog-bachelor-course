using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerAndModel
{
    public  class Controller
    {
        public static string ProcessFilePath(string path)
        {
            if (path != null)
            {
                return path;
            }
            else
            {
                return null;
            }
        }

        public static string ProcessText(Stream s)
        {
            var reader = new StreamReader(s);
            string text = reader.ReadToEnd();
            reader.Close();
            s.Close();
            return text;
        }

        public static void ProcessWriteText(Stream s, string text)
        {
            var writer = new StreamWriter(s);
            writer.Write(text);
            writer.Close();
        }
    }
}
