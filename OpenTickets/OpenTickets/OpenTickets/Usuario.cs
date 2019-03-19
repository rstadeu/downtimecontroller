using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace OpenTickets
{
    class Usuario
    {
        private string id;       
        private string firstName ;
        private string lastName;
        private string userID;
        private string password;
        private string accessLevel;
        private bool logado;

        public string get_id()
        {
            return id;
        }

        public string get_firstName()
        {
            return firstName;
        }

        public string get_lastName()
        {
            return lastName;
        }

        public string get_userID()
        {
            return userID;
        }

        public string get_password()
        {
            return password;
        }

        public string get_accessLevel()
        {
            return accessLevel;
        }

        public bool get_logado()
        {
            return logado;
        }
        public void set_id(string identificacao)
        {
            id = identificacao;
        }
        public void set_firstName(string primeiroNome)
        {
            firstName = primeiroNome;
        }
        public void set_lastName(string sobreNome)
        {
            lastName = sobreNome;
        }
        public void set_userID(string usuario)
        {
            userID = usuario;
        }
        public void set_password(string senha)
        {
            password = senha;
        }
        public void set_accessLevel(string nivelAcesso)
        {
            accessLevel = nivelAcesso;
        }
        public void set_logado(bool login)
        {
            logado = login;
        }
        public string _id { get{return id;} set{ id = value;}}
        public string _firstName { get { return firstName; } set { firstName = value; } }
        public string _lastName { get { return lastName; } set { lastName = value; } }
        public string _userID { get { return userID; } set { userID = value; } }
        public string _password { get { return password; } set { password = value; } }
        public string _accessLevel { get { return accessLevel; } set { accessLevel = value; } }
        public bool _logado { get { return logado; } set { logado = value; } }

        public int login(string user, string pw)
        {
            int value = 0;
            string conexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();

            OleDbConnection lgConnection = new OleDbConnection(conexao);

            OleDbCommand lgCommand =  new OleDbCommand("Select * From Usuario", lgConnection);
            OleDbDataAdapter daLogin = new OleDbDataAdapter(lgCommand);

            lgConnection.Open();

            DataSet dsLogin = new DataSet();
            DataTable dtLogin = new DataTable("Usuario");
            
            daLogin.Fill(dsLogin,"Usuario");
            dtLogin = dsLogin.Tables["Usuario"];

            foreach (DataRow drLogin in dtLogin.Rows)
            {
                if (drLogin["UserID"].ToString() == user)
                {
                    if (drLogin["PW"].ToString() == pw)
                    {
                        id = drLogin["Código"].ToString();
                        firstName = drLogin["FirstName"].ToString();
                        lastName = drLogin["LastName"].ToString();
                        userID = drLogin["UserID"].ToString();
                        password = drLogin["PW"].ToString();
                        accessLevel = drLogin["AccessLevel"].ToString();

                        logado = true;

                        value = 1;
                    }
                    else
                    {
                        value = 0;
                    }

                }
                else
                {
                    value = 2;
                }
                

            }

            lgConnection.Close();

            return value;


        }



    }
}
