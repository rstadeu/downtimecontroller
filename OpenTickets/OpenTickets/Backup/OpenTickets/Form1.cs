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

        bool janela;
        string temp;
       
        public Form1()
        {
            InitializeComponent();

            CJ.controlJanela = new WindowControl();
            dir.dr = new Diretorio();


           dir.dr.set_dir("Database");
            dir.dr.set_dPath("...\\Database\\");


            

            Directory.CreateDirectory(dir.dr.get_dir());

            dAToolStripMenuItem.Enabled = false;
            configurarEstaçãoToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            consultarOrdensAbertasToolStripMenuItem.Enabled = false;
            fecharOrdemToolStripMenuItem.Enabled = false;
            btnFF.Enabled = false;
            btnPreventiva.Enabled = false;
            btnStopped.Enabled = false;
            trocarSenhaToolStripMenuItem.Enabled = false;
            abirChamadoOutraEstacaoToolStripMenuItem.Enabled = false;

           // geraXML();


            leCaminho();
            
            carregaXML();
            User.user = new Usuario();
            Chamado.chamado = new Ocorrencias();
            Test.teste = new Teste();

            leEstacao();

            janela = false;
            //tsslTemp.Text = dir.dr.get_path();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (janela)
            {
                this.Hide();
                janela = false;
            }
            else
            {
                this.Show();
                janela = true;
            }
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

            CJ.controlJanela.set_Login(true);
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

                  //  tsslTemp.Text = temp;
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
                    //tsslTemp.Text = dir.dr.get_path();



                }
                else
                    MessageBox.Show("Operação cancelada");
            }

        }

        private void configurarEstaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StationResgister newStation = new StationResgister();

            newStation.Show();

            CJ.controlJanela.set_StationRegister(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            lblssStation.Text = "Estacao: " + Test.teste.get_testName();
            //lblssCliente.Text = "Cliente: " + Test.teste.get_cliente();

            if(!User.user.get_logado())
            {
                if (CJ.controlJanela.get_Login())
                {
                    loginToolStripMenuItem.Enabled = false;
                    logoutToolStripMenuItem.Enabled = true;
                }
                else
                {
                    loginToolStripMenuItem.Enabled = true;
                    logoutToolStripMenuItem.Enabled = false;

                }

            }
            


            if (User.user.get_logado())
            {
                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                if ((int.Parse(User.user.get_accessLevel())) >= 2)
                {
                    //MessageBox.Show(User.user.get_accessLevel(), "Nivel de acesso", MessageBoxButtons.OK);
                    dAToolStripMenuItem.Enabled = true;
                    configurarEstaçãoToolStripMenuItem.Enabled = true;
                    //logoutToolStripMenuItem.Enabled = true;
                    consultarOrdensAbertasToolStripMenuItem.Enabled = true;
                    fecharOrdemToolStripMenuItem.Enabled = true;
                    if (!Chamado.chamado.get_chamado())
                    {
                        btnStopped.Enabled = true;
                        btnPreventiva.Enabled = true;
                        btnFF.Enabled = true;
                    }
                    trocarSenhaToolStripMenuItem.Enabled = true;
                    abirChamadoOutraEstacaoToolStripMenuItem.Enabled = true;
                    tsslTemp.Text = User.user.get_firstName() + " " + User.user.get_lastName();

                    if (CJ.controlJanela.get_AbreTicket())
                    {

                        btnFF.Enabled = false;
                        btnPreventiva.Enabled = false;
                        btnStopped.Enabled = false;
                    }
                    else
                    {
                        if (!Chamado.chamado.get_chamado())
                        {
                            btnStopped.Enabled = true;
                            btnPreventiva.Enabled = true;
                            btnFF.Enabled = true;
                        }

                    }

            if (CJ.controlJanela.get_FechaOrdem())
                fecharOrdemToolStripMenuItem.Enabled = false;
            else
                fecharOrdemToolStripMenuItem.Enabled = true;
            //if (CJ.controlJanela.get_Login())
            //    loginToolStripMenuItem.Enabled = false;
            
            if (CJ.controlJanela.get_StationRegister())
                configurarEstaçãoToolStripMenuItem.Enabled = false;
            else
                configurarEstaçãoToolStripMenuItem.Enabled = true;
                   



                }
                else
                {
                    dAToolStripMenuItem.Enabled = false;
                    configurarEstaçãoToolStripMenuItem.Enabled = false;
                    //logoutToolStripMenuItem.Enabled = false;
                    consultarOrdensAbertasToolStripMenuItem.Enabled = false;
                    fecharOrdemToolStripMenuItem.Enabled = false;
                    if (!Chamado.chamado.get_chamado())
                    {
                        btnStopped.Enabled = true;
                        btnPreventiva.Enabled = true;
                        btnFF.Enabled = true;
                    }
                    trocarSenhaToolStripMenuItem.Enabled = true;
                    abirChamadoOutraEstacaoToolStripMenuItem.Enabled = false;
                    tsslTemp.Text =User.user.get_firstName() + " " + User.user.get_lastName();


                    if (CJ.controlJanela.get_AbreTicket())
                    {

                        btnFF.Enabled = false;
                        btnPreventiva.Enabled = false;
                        btnStopped.Enabled = false;
                    }
                    else
                    {
                        if (!Chamado.chamado.get_chamado())
                        {
                            btnStopped.Enabled = true;
                            btnPreventiva.Enabled = true;
                            btnFF.Enabled = true;
                        }

                    }
                }
            }
            else
            {
                loginToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = false;
                tsslTemp.Text = "Não logado";
                dAToolStripMenuItem.Enabled = false;
                configurarEstaçãoToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = false;
                consultarOrdensAbertasToolStripMenuItem.Enabled = false;
                fecharOrdemToolStripMenuItem.Enabled = false;
                btnFF.Enabled = false;
                btnPreventiva.Enabled = false;
                btnStopped.Enabled = false;
                trocarSenhaToolStripMenuItem.Enabled = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.user.set_logado(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chamado.chamado.set_reason("Falha Falsa");
            AbreTicket ordemServico = new AbreTicket();

            ordemServico.Show();
            CJ.controlJanela.set_AbreTicket(true);
        }

        private void btnStopped_Click(object sender, EventArgs e)
        {
            Chamado.chamado.set_reason("Parada");
            AbreTicket ordemServico = new AbreTicket();

            ordemServico.Show();

            CJ.controlJanela.set_AbreTicket(true);
        }
        private void leEstacao()
        {
            try
            {
                //declara os objetos de manipulação do arquivo

                DataTable dtPath = new DataTable();
                // carregaXML();
                dsPath.ReadXml(dir.dr.get_dPath() + "database.xml");
                dtPath = dsPath.Tables["Nome_Estacao"];
                try
                {
                    //DataRow drPath in dtPath;
                    //temp = dtPath.Columns["Path"].ToString();

                    foreach (DataRow drPath in dtPath.Rows)
                    {
                        if (drPath["idStation"].ToString() == "1")
                        {
                            Test.teste.set_id( int.Parse(drPath["idStation"].ToString()));
                            Test.teste.set_testName(drPath["nameStation"].ToString());
                            Test.teste.set_descricao(drPath["descStation"].ToString());
                            Test.teste.set_produto(drPath["prodStation"].ToString());
                            Test.teste.set_cliente(drPath["custStation"].ToString());
                        }
                            
                    }
                    dir.dr.set_path(temp);

                    //  tsslTemp.Text = temp;
                }
                catch
                {
                }
            }catch           
            {

            }
        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void expandirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPreventiva_Click(object sender, EventArgs e)
        {
            Chamado.chamado.set_reason("Preventiva");
            AbreTicket ordemServico = new AbreTicket();

            ordemServico.Show();
            CJ.controlJanela.set_AbreTicket(true);
        }

        private void fecharOrdemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fechaOrdem closeTicket = new fechaOrdem();

            closeTicket.Show();

            CJ.controlJanela.set_FechaOrdem(true);
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocaSenha tSenha = new TrocaSenha();
            tSenha.Show();


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            statusStrip1.Dispose();
        }

        private void consultarOrdensAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historico hr = new Historico();
            hr.Show();

        }

        private void abirChamadoOutraEstacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamadoOutraEstacao ch = new ChamadoOutraEstacao();
            ch.Show();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            

        }




    }

     
}