using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownTimeController.Classes
{
    class ControlWindow
    {
        private bool findErrorCode;
        private bool openTicket;
        private bool firstTime;

        public bool FindErrorCode
        {
            get { return findErrorCode; }
            set { findErrorCode = value; }
        }

        public bool OpenTicket
        {
            get { return openTicket; }
            set { openTicket = value; }
        }

        public bool FirstTime
        {
            get { return firstTime; }
            set { firstTime = value; }
        }
    }
}
