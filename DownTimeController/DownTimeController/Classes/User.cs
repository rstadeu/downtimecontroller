using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Reflection;
using System.IO;


namespace DownTimeController.Classes
{
    class User
    {
        private Encriptor encrip = new Encriptor();
        private static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string folder = Path.Combine(path, "XMLData");
        private static string file = Path.Combine(folder, "User.xml");
        private string id;
        private string firstName;
        private string lastName;
        private string userID;
        private string password;
        private string accessLevel;
        private bool logado;
        private int logginStatus;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }


        public int LogginStatus
        {
            get { return logginStatus; }
            set { logginStatus = value; }
        }
        /// <summary>
        /// This Method create a XMLUserFile
        /// </summary>
        /// <returns>Returns a integer</returns>
        public int CreateXMLUserFile()
        {
             

            if (!(File.Exists(file)))
            {
                try
                {
                    XDocument xmlUser = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("Users",
                                new XElement("User",
                                    new XElement("ID", encrip.stringEncryptor(Convert.ToString(1))),
                                    new XElement("FirstName", encrip.stringEncryptor("Developer")),
                                    new XElement("LastName", encrip.stringEncryptor("")),
                                    new XElement("UserID", encrip.stringEncryptor("dev")),
                                    new XElement("PWD", encrip.stringEncryptor("3ngT3st")),
                                    new XElement("AccessLevel", encrip.stringEncryptor(Convert.ToString(5))),
                                    new XElement("Logged", encrip.stringEncryptor(Convert.ToString(Convert.ToBoolean(1))))
                                    )
                                )


                    );

                    xmlUser.Save(file);
                    return 1;
                }
                catch
                {
                    return 0;
                }
            }

            return 2;

        }

        public User login(string userId, string pwd)
        {
            User user = new User();
            int returnResult;
            var loadXml = XDocument.Load(file);
            try
            {
            var result = (from u in loadXml.Descendants("User")
                          where encrip.stringDecryptor(Convert.ToString(u.Element("UserID").Value)) == userId
                          select new User
                          {
                              id = encrip.stringDecryptor(Convert.ToString(u.Element("ID").Value)),
                              FirstName = encrip.stringDecryptor(Convert.ToString(u.Element("FirstName").Value)),
                              LastName = encrip.stringDecryptor(Convert.ToString(u.Element("LastName").Value)),
                              UserID = encrip.stringDecryptor(Convert.ToString(u.Element("UserID").Value)),
                              Password = encrip.stringDecryptor(Convert.ToString(u.Element("PWD").Value)),
                              AccessLevel = encrip.stringDecryptor(Convert.ToString(u.Element("AccessLevel").Value)),
                              Logado = Convert.ToBoolean(encrip.stringDecryptor(Convert.ToString(u.Element("Logged").Value)))

                          }).First();

            user = result;

            if (user.password == pwd)
            {
                returnResult = 1;
            }
            else
            {
                returnResult = 0;
            }
            }
            catch
            {

                returnResult = 2;

            }

            user.LogginStatus = returnResult;
            
            return user;

        }

        public User logout()
        {
            User user = new User();

            return user;
        }
       
    }
}
