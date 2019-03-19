using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownTimeController.Classes
{
    class ErrorCode
    {
        private int id;
        private string error_Code;
        private string description;
        private string errorGroup;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Error_Code
        {
            get { return error_Code; }
            set { error_Code = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string ErrorGroup
        {
            get { return errorGroup; }
            set { errorGroup = value; }
        }


    }
}
