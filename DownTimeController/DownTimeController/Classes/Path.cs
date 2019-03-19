using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace DownTimeController.Classes
{
    class Paths
    {
        private string absolutPath;


        public string getAbsolutePath()
        {
            absolutPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            absolutPath = Path.Combine(absolutPath, "XMLData");

            return absolutPath;

        }
        
    }
}
