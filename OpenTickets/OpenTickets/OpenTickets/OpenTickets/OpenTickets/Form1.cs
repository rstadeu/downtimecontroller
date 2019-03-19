using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Xml;
using System.Data.OleDb;



namespace OpenTickets
{
    public partial class Form1 : Form
    {
        
        
        string temp;
       
        public Form1()
        {
            InitializeComponent();

            dir.dr = new Diretorio();

           dir.dr.set_dir("Database");
            dir.dr.set_dPath("...\\Database\\");


            

            Directory.CreateDirectory(dir.dr.get_dir());

            dAToolStripMenuItem.Enabled = false;
            //configurarEstaçãoToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            consultarOrdensAbertasToolStripMenuItem.Enabled = false;
            fecharOrdemToolStripMenuItem.Enabled = false;


            leCaminho();


            carregaXML();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void dAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            { 
                string dire;
                dire = folderBrowserDialog1.SelectedPath.ToString();
                dir.dr.set_path(dire);

                
                //row.AcceptChanges();
                //dsPath.WriteXml(dir.dr.get_dPath());

             

                /* using (StreamWriter sw = new StreamWriter(dir.dr.get_dPath()))
        
                {
                    sw.Write(dir.dr.get_path());
                }
                */


            }
            else
                MessageBox.Show("Operação cancelada");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

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
            row["Path"] = dir.dr.get_path() + "\\DownTimeControl.mdb";

            dtPath.Rows.Add(row);
            // adiciona as tabelas ao dataset

            dsPath.Tables.Add(dtPath);
            dsPath.Tables.Add(dtEstTeste);


            //cria o XML Schema

            dsPath.WriteXml( pathXML, XmlWriteMode.WriteSchema);

            //retorna o dataset populado com as informações

            return dsPath;
            
        }

        private void carregaXML()
        {
            try
            {
                dsPath.ReadXml(dir.dr.get_dPath()+ "database.xml");
            }
            catch (System.IO.FileNotFoundException)
            {
                dsPath = geraXML();

            }
        }

        private void baixaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria a janela de Login
            login newlogin = new login();
            newlogin.Show();
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
                    dir.dr.set_path("temp");

                    tsslTemp.Text = temp;
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
                    tsslTemp.Text = dir.dr.get_path();



                }
                else
                    MessageBox.Show("Operação cancelada");
            }

        }

        private void configurarEstaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationResgister newStation = new StationResgister();

            newStation.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }





    }

     
}