using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DownTimeController.Classes
{
    class Station
    {
        private string stationName;
        private string product;
        private string customer;
        private string stationType;


        public string StationName
        {
            get { return stationName; }
            set { stationName = value; }
        }

        public string Product
        {
            get { return product; }
            set { product = value; }
        }


        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string StationType
        {
            get { return stationType; }
            set { stationType = value; }
        }
    }
}
