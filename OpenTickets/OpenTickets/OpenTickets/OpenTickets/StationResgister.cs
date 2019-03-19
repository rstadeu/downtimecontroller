using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Xml;


namespace OpenTickets
{
    public partial class StationResgister : Form
    {
        
        DataSet dsPath = new DataSet();
        string temp;
        
        

        public StationResgister()
        {
            dir.dr.set_dir("Database");
            dir.dr.set_dPath("...\\Database\\");
            InitializeComponent();
            leCaminho();

            lblDescricao.Text = dir.dr.get_path();
            populaComboBox();
            

        }

        private void StationResgister_Load(object sender, EventArgs e)
        {

        }

        private void populaComboBox()
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("TestName");
            
            daTest.Fill(dsTest, "Test");
            

            dtTest = dsTest.Tables["Test"];

            cmbTestStation.ValueMember = "TestName";
            cmbTestStation.DataSource = dtTest;



            foreach (DataRow dlTest in dtTest.Rows)
            {
                if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                {
                    lblID.Text = dlTest["Código"].ToString();
                    lblDescricao.Text = dlTest["Descricao"].ToString();
                    lblCliente.Text = dlTest["Cliente"].ToString();
                    lblProduto.Text = dlTest["Produto"].ToString();

                }
            }


            
           

            cnTest.Close();

            
        

        }

        private void leCaminho()
        {
           

            try
            {
                //declara os objetos de manipulação do arquivo

                DataTable dtPath = new DataTable();
                // carregaXML();
                dsPath.ReadXml(dir.dr.get_dPath() + "database.xml");
                dtPath = dsPath.Tables["Caminho"];
                try
                {
                    //DataRow drPath in dtPath;
                    //temp = dtPath.Columns["Path"].ToString();

                    foreach (DataRow drPath in dtPath.Rows)
                    {
                        temp = drPath["Path"].ToString();
                    }
                    dir.dr.set_path(temp);

                    //tsslTemp.Text = temp;
                }
                catch (FileLoadException ex)
                {
                    MessageBox.Show("Erro ao Abrir o Arquivo ", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MissingPrimaryKeyException ex)
                {
                    MessageBox.Show("Erro ao Abrir o Arquivo ", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DeletedRowInaccessibleException ex)
                {
                    MessageBox.Show("Erro ao Abrir o Arquivo ", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DataException ex)
                {
                    MessageBox.Show("Erro ao Abrir o Arquivo ", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (AccessViolationException ex)
                {
                    MessageBox.Show("Erro ao Abrir o Arquivo ", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string dire;
                    dire = folderBrowserDialog1.SelectedPath.ToString();
                    dir.dr.set_path(dire);

                    carregaXML();
                   // tsslTemp.Text = dir.dr.get_path();



                }
                else
                    MessageBox.Show("Operação cancelada");
            }

        }

        private void carregaXML()
        {
            try
            {
                dsPath.ReadXml(dir.dr.get_dPath() + "database.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                dsPath = geraXML();

            }
        }


        private DataSet geraXML()
        {

            //Cria a estrutura do arquivo XML
            DataTable dtPath = new DataTable("Caminho");
            DataTable dtEstTeste = new DataTable("Nome_Estacao");
            Type strType = System.Type.GetType("System.String");



            // string que contem o caminho para o XML salvo

            string pathXML;

            pathXML = dir.dr.get_dPath() + "database.xml";

            DataRow row = dtPath.NewRow();





            // Adiciona Colunas as tabelas
            dtPath.Columns.Add("Id", strType);
            dtPath.Columns.Add("Path", strType);
            dtEstTeste.Columns.Add("idStation", strType);
            dtEstTeste.Columns.Add("nameStation", strType);
            dtEstTeste.Columns.Add("descStation", strType);
            dtEstTeste.Columns.Add("prodStation", strType);
            dtEstTeste.Columns.Add("custStation", strType);
            // DataColumn[] dc = new DataColumn[1];
            //dc[0] =  dtPath.Columns["Id"];
            //dtPath.PrimaryKey = dc;  
            row["Id"] = "1";
            row["Path"] = dir.dr.get_path();

            dtPath.Rows.Add(row);
            // adiciona as tabelas ao dataset

            dsPath.Tables.Add(dtPath);
            dsPath.Tables.Add(dtEstTeste);


            //cria o XML Schema

            dsPath.WriteXml(pathXML, XmlWriteMode.WriteSchema);

            //retorna o dataset populado com as informações

            return dsPath;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("TestName");


            // Cria os parametros de conexao
           
            daTest.Fill(dsTest, "Test");

            

            //cnTest.Open();

           

            dtTest = dsTest.Tables["Test"];

            // cmbTestStation.ValueMember = "TestName";
            //cmbTestStation.DataSource = dtTest;



            foreach (DataRow dlTest in dtTest.Rows)
            {
                if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                {
                    lblID.Text = dlTest["Código"].ToString();
                    lblDescricao.Text = dlTest["Descricao"].ToString();
                    lblCliente.Text = dlTest["Cliente"].ToString();
                    lblProduto.Text = dlTest["Produto"].ToString();

                }
            }





            cnTest.Close();

            

            



             
            

        }

        private void cmbTestStation_MouseClick(object sender, MouseEventArgs e)
        {
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("TestName");
            daTest.Fill(dsTest, "Test");


            foreach (DataRow dlTest in dtTest.Rows)
            {
                if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                {
                    lblID.Text = dlTest["Código"].ToString();
                    lblDescricao.Text = dlTest["Descricao"].ToString();
                    lblCliente.Text = dlTest["Cliente"].ToString();
                    lblProduto.Text = dlTest["Produto"].ToString();

                }
            }

            cnTest.Close();
        }

        private void cmbTestStation_MouseDown(object sender, MouseEventArgs e)
        {
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("TestName");
            daTest.Fill(dsTest, "Test");


            foreach (DataRow dlTest in dtTest.Rows)
            {
                if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                {
                    lblID.Text = dlTest["Código"].ToString();
                    lblDescricao.Text = dlTest["Descricao"].ToString();
                    lblCliente.Text = dlTest["Cliente"].ToString();
                    lblProduto.Text = dlTest["Produto"].ToString();

                }
            }

            cnTest.Close();
        }

        private void cmbTestStation_KeyDown(object sender, KeyEventArgs e)
        {
           

        }

        private void cmbTestStation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


                OleDbConnection cnTest = new OleDbConnection(ConnectionString);
                OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

                OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

                cnTest.Open();

                DataSet dsTest = new DataSet();
                DataTable dtTest = new DataTable("TestName");
                daTest.Fill(dsTest, "Test");


                foreach (DataRow dlTest in dtTest.Rows)
                {
                    if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                    {
                        lblID.Text = dlTest["Código"].ToString();
                        lblDescricao.Text = dlTest["Descricao"].ToString();
                        lblCliente.Text = dlTest["Cliente"].ToString();
                        lblProduto.Text = dlTest["Produto"].ToString();

                    }
                }

                cnTest.Close();
            }
        }

        private void cmbTestStation_Click(object sender, EventArgs e)
        {

           

                string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


                OleDbConnection cnTest = new OleDbConnection(ConnectionString);
                OleDbCommand cmdTest = new OleDbCommand("Select * from Test", cnTest);

                OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

                cnTest.Open();

                DataSet dsTest = new DataSet();
                DataTable dtTest = new DataTable("TestName");
                daTest.Fill(dsTest, "Test");


                foreach (DataRow dlTest in dtTest.Rows)
                {
                    if (dlTest["TestName"].ToString() == cmbTestStation.Text)
                    {
                        lblID.Text = dlTest["Código"].ToString();
                        lblDescricao.Text = dlTest["Descricao"].ToString();
                        lblCliente.Text = dlTest["Cliente"].ToString();
                        lblProduto.Text = dlTest["Produto"].ToString();

                    }
                }

                cnTest.Close();
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DataTable dtTest = new DataTable();
            dtTest = dsPath.Tables["Nome_Estacao"];

            DataRow drTest = dtTest.NewRow();

            drTest["idStation"] = lblID.Text;
            drTest["nameStation"] = cmbTestStation.Text;
            drTest["descStation"] = lblDescricao.Text;
            drTest["prodStation"] = lblProduto.Text;
            drTest["custStation"] = lblCliente.Text;

            dtTest.Rows.Add(drTest);

            //dsPath.Tables.Add(dtTest);

            dsPath.WriteXml(dir.dr.get_dPath() + "database.xml", XmlWriteMode.WriteSchema);
           DialogResult resultado =  MessageBox.Show("Dados salvos com sucesso", "Configuração da Estação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (resultado.ToString() == "OK")
            {
                this.Close();
            }

        }

    

    }
}