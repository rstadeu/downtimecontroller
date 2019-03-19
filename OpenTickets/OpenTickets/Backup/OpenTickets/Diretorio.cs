using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTickets
{
    class Diretorio
    {
        private string dPath;
        private string dir;
        private string path;

        public Diretorio()
        {
            path = "";
            dPath = "";
            dir = "";            
        }

        public void set_path(string pth)
        {
            path = pth;
        }

        public string get_path()
        {
            return path;
        }

        public void set_dir(string dr)
        {
            dir = dr;
        }

        public string get_dir()
        {
            return dir;
        }

        public string get_dPath()
        {
            return dPath;
        }

        public void set_dPath(string dicPath)
        {
            dPath = dicPath;
        }
    }
}
