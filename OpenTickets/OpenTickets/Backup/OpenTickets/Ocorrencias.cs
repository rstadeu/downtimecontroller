using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace OpenTickets
{
    class Ocorrencias
    {
        private int id;
        private string station;
        private DateTime timeToStop;
        private DateTime timeToBack;
        private string userOpenTicket;
        private string engUser;
        private string reason;
        private string typeOfProblem;
        private string parteChanged;
        private bool itsRunning;
        private string customer;
        private string product;
        private bool chamado;


        public void set_chamado(bool ticket)
        {
            chamado = ticket;
        }

        public void set_id(int identification)
        {
            id = identification;
        }
        public void set_station(string estacao)
        {
            station = estacao;
        }
        public void set_timeToStop(DateTime horaParada)
        {
            timeToStop = horaParada;
        }
        public void set_timeToBack(DateTime horadaVolta)
        {
            timeToBack = horadaVolta;
        }
        public void set_userOpenTicket(string usuario)
        {
            userOpenTicket = usuario;
        }
        public void set_engUser(string suporte)
        {
            engUser = suporte;
        }
        public void set_reason(string motivo)
        {
            reason = motivo;
        }
        public void set_typeOfProblem(string tipoDeProblema)
        {
            typeOfProblem = tipoDeProblema;
        }
        public void set_parteChanged(string trocado)
        {
            parteChanged = trocado;
        }
        public void set_itsRunning(bool rodando)
        {
            itsRunning = rodando;
        }
        public void set_customer(string cliente)
        {
            customer = cliente;
        }
        public void set_product(string prod)
        {
            product = prod;
        }

        public int get_id()
        {
            return id;
        }
        public string get_station()
        {
            return station;
        }
        public DateTime get_timeToStop()
        {
            return timeToStop;
        }
        public DateTime get_timeToBack()
        {
            return timeToBack;
        }
        public string get_userOpenTicket()
        {
            return userOpenTicket;
        }
        public string get_engUser()
        {
            return engUser;
        }
        public string get_reason()
        {
            return reason;
        }
        public string get_typeOfProblem()
        {
            return typeOfProblem;
        }
        public string get_parteChanged()
        {
            return parteChanged;
        }
        public bool get_itsRunning()
        {
            return itsRunning;
        }
        public string get_customer()
        {
            return customer;
        }
        public string get_product()
        {
            return product;
        }
        public bool get_chamado()
        {
            return chamado;
        }


        public int geraChamado()
        {
            
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbCommand cmd = new OleDbCommand();
            //OleDbCommand cmd1 = new OleDbCommand();
            DateTime dTime = DateTime.Now;
            timeToStop = dTime;
            station = Test.teste.get_testName();
            userOpenTicket = User.user.get_userID();
            customer = Test.teste.get_cliente();
            product = Test.teste.get_produto();
            itsRunning = false;
            



            try
            {
                //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                // Int32 Id = new Int32();
                //Id = (Int32)cmd.Parameters["Código"].Value;

                cmd = new OleDbCommand("Insert Into Ocorrencias(Station , TimeToStop , UserOpenTicket, Reason, TypeOfProblem, Customer, Product)" +
                    "Values(@Station, @TimeToStop, @UserOpenTicket, @Reason, @TypeOfProblem, @Customer, @Product)", conn);
                cmd.Parameters.Add("@Station", OleDbType.VarChar, 50);
                cmd.Parameters.Add("@TimeToStop", OleDbType.Date, 50);
                cmd.Parameters.Add("@UserOpenTicket", OleDbType.VarChar, 50);
                cmd.Parameters.Add("@Reason", OleDbType.VarChar, 50);
                cmd.Parameters.Add("@TypeOfProblem", OleDbType.VarChar, 4000);
                cmd.Parameters.Add("@Customer", OleDbType.VarChar, 50);
                cmd.Parameters.Add("@Product", OleDbType.VarChar, 50);

                cmd.Parameters["@Station"].Value = Test.teste.get_testName();
                cmd.Parameters["@TimeToStop"].Value = dTime;
                cmd.Parameters["@UserOpenTicket"].Value = User.user.get_userID();
                cmd.Parameters["@Reason"].Value = reason;
                cmd.Parameters["@TypeOfProblem"].Value = typeOfProblem;
                cmd.Parameters["@Customer"].Value = Test.teste.get_cliente();
                cmd.Parameters["@Product"].Value = Test.teste.get_produto();






                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                chamado = true;
                return 1;

                //  MessageBox.Show("Dados salvos com sucesso!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch
            {
                return 0;
            }

            finally
            {
                if ((conn.State == ConnectionState.Open))
                {
                    conn.Close();
                }
                conn.Dispose();
                conn = null;
                cmd.Dispose();
                cmd = null;
            }

        }


        public void carregaValores()
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Ocorrencias", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Ocorrencias");

            daTest.Fill(dsTest, "Ocorrencias");


            dtTest = dsTest.Tables["Ocorrencias"];

            



            foreach (DataRow dlTest in dtTest.Rows)
            {
                if (dlTest["Station"].ToString() == Test.teste.get_testName())
                {
                    if(dlTest["Customer"].ToString() == Test.teste.get_cliente())
                    {
                        if(dlTest["Product"].ToString() == Test.teste.get_produto())
                        {
                            if (bool.Parse(dlTest["itsRunning"].ToString()) == false)
                            {
                                id = Convert.ToInt32( dlTest["Código"].ToString());
                                station = dlTest["Station"].ToString();
                                timeToStop = DateTime.Parse(dlTest["TimeToStop"].ToString());
                                userOpenTicket = dlTest["UserOpenTicket"].ToString();
                                reason = dlTest["Reason"].ToString();
                                typeOfProblem = dlTest["TypeOfProblem"].ToString();
                                customer = dlTest["Customer"].ToString();
                                product = dlTest["Product"].ToString();
                                itsRunning = bool.Parse(dlTest["itsRunning"].ToString());

                                
                            }
                    
                        }

                    }
                }
            }





            cnTest.Close();

            
        
        }

        public void fechaOrdem(string partChanged, string userID, string description, DateTime retorno, string problema)
        {
            string testName = Test.teste.get_testName();
            string customer = Test.teste.get_cliente();
            string produto = Test.teste.get_produto();

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbCommand cmd = new OleDbCommand();
            

            try
            {
                conn.Open();
                cmd = new OleDbCommand("UPDATE Ocorrencias SET TimeToBack =\' " + DateTime.Now + "\' , EngUser =\' " + userID + "\' , PartChanged =\' " + partChanged + "\',  DescricaoProblema =\' " + description + "\', Problema =\'" + problema + "\', ItsRunning = " + true + " WHERE Ocorrencias.Código = " + id, conn);
                /*
                //cmd = new OleDbCommand(, conn);
               
                cmd.Parameters.AddWithValue("@TimeToBack",DateTime.Now);
                cmd.Parameters.AddWithValue("@EngUser", userID);
                cmd.Parameters.AddWithValue("@PartChanged", partChanged);
                cmd.Parameters.AddWithValue("@DescricaoProblema", description);
                cmd.Parameters.AddWithValue("@Running", true);

                cmd.Parameters["@TimeToBack"].Value = retorno;
                cmd.Parameters["@EngUser"].Value = userID;
                cmd.Parameters["@PartChanged"].Value = partChanged;
                cmd.Parameters["@DescricaoProblema"].Value = description;*/
                

                
                cmd.ExecuteNonQuery();
                chamado = false;

                
            }
            finally
            {
                if ((conn.State == ConnectionState.Open))
                {
                    conn.Close();
                }
                conn.Dispose();
                conn = null;
                cmd.Dispose();
                cmd = null;
            }

            
        }




    }
}
