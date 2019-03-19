using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownTimeController.Classes
{
    class StationBOM
    {
        private int _id;
        private string _partNumber;
        private string _description;
        private string _station;
        private string _location;
        private byte[] _image;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string PartNumber
        {
            get { return _partNumber; }
            set { _partNumber = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Station
        {
            get { return _station; }
            set { _station = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }

    }
}
