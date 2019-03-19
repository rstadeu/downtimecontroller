using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTickets
{
    class Usuario
    {
        private int id;       
        private string firstName ;
        private string lastName;
        private string userID;
        private string password;
        private int accessLevel;

        public int _id { get{return id;} set{ id = value;}}
        public string _firstName { get { return firstName; } set { firstName = value; } }
        public string _lastName { get { return lastName; } set { lastName = value; } }
        public string _userID { get { return userID; } set { userID = value; } }
        public string _password { get { return password; } set { password = value; } }
        public int _accessLevel { get { return accessLevel; } set { accessLevel = value; } }



    }
}
