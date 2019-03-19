using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OrderManagement
{
    public partial class Form1 : Form
    {
        //bool loginOpen = new bool();

        bool firstTime = new bool();
        //DataSet dsPath = new DataSet();
        string temp;
            
        public Form1()
        {
            InitializeComponent();

            controlWindows.cw = new ControlaJanelas();

            User.user = new Usuario();
            dir.dr = new Diretorio();
            firstTime = true;

            dir.dr.set_dir("Database");
            dir.dr.set_dPath("...\\Database\\");




            Directory.CreateDirectory(dir.dr.get_dPath());

            leCaminho();

           // geraXML();
            

            carregaXML();
            login logar = new login();

            logar.MdiParent = this;
            logar.Show();
            User.user.set_winOpen(true);
            arquivoToolStripMenuItem.Enabled = false;
            cadastroToolStripMenuItem.Enabled = false;
            controleDeOrdensToolStripMenuItem.Enabled = false;
            relatorioToolStripMenuItem.Enabled = false;
            configuracoesToolStripMenuItem.Enabled = false;
           // MessageBox.Show(dir.dr.get_path());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadProduto Produto = new CadProduto();
            Produto.MdiParent = this;
            Produto.Show();

            controlWindows.cw.set_produto(true);

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadClient cliente = new cadClient();
            cliente.MdiParent = this;
            cliente.Show();
            controlWindows.cw.set_cliente(true);
            
        }

        private void estaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadStation estacao = new cadStation();
            estacao.MdiParent = this;
            estacao.Show();
            controlWindows.cw.set_estacao(true);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadUsuario usuario = new cadUsuario();
            usuario.MdiParent = this;
            usuario.Show();
            controlWindows.cw.set_usuario(true);

        }

        private void controleDeOrdensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizador controle = new Visualizador();
            controle.MdiParent = this;
            controle.Show();
            controlWindows.cw.set_conOrdens(true);

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptDowntime relatoio = new rptDowntime();
            relatoio.MdiParent = this;
            relatoio.Show();
            controlWindows.cw.set_relatorio(true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            

            if (User.user.get_logado())
            {

                loginToolStripMenuItem.Enabled = false;
                logoutToolStripMenuItem.Enabled = true;
                

                if ((int.Parse(User.user.get_accessLevel())) > 3)
                {
                    arquivoToolStripMenuItem.Enabled = true;
                    cadastroToolStripMenuItem.Enabled = true;
                    controleDeOrdensToolStripMenuItem.Enabled = true;
                    relatorioToolStripMenuItem.Enabled = true;
                    configuracoesToolStripMenuItem.Enabled = true;

                    if (!(controlWindows.cw.get_contOrdens()))
                    {
                        if (firstTime)
                        {
                            Visualizador ticketControl = new Visualizador();
                            ticketControl.MdiParent = this;
                            ticketControl.Show();
                            controlWindows.cw.set_conOrdens(true);
                            firstTime = false;
                        }
                    }


                    if (controlWindows.cw.get_cliente())
                        clienteToolStripMenuItem.Enabled = false;
                    else
                        clienteToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_database())
                        databaseToolStripMenuItem.Enabled = false;
                    else
                        databaseToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_estacao())
                        estaçãoToolStripMenuItem.Enabled = false;
                    else
                        estaçãoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_produto())
                        produtoToolStripMenuItem.Enabled = false;
                    else
                        produtoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_relatorio())
                        relatorioToolStripMenuItem.Enabled = false;
                    else
                        relatorioToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_contOrdens())
                        controleDeOrdensToolStripMenuItem.Enabled = false;
                    else
                        controleDeOrdensToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_usuario())
                        usuarioToolStripMenuItem.Enabled = false;
                    else
                        usuarioToolStripMenuItem.Enabled = true;
                   

                }
                else if ((int.Parse(User.user.get_accessLevel())) == 3)
                {
                    arquivoToolStripMenuItem.Enabled = true;
                    cadastroToolStripMenuItem.Enabled = false;
                    controleDeOrdensToolStripMenuItem.Enabled = true;
                    relatorioToolStripMenuItem.Enabled = false;
                    //databaseToolStripMenuItem.Enabled = false;
                    emailToolStripMenuItem.Enabled = false;

                    if (!(controlWindows.cw.get_contOrdens()))
                    {
                        if (firstTime)
                        {
                            Visualizador ticketControl = new Visualizador();
                            ticketControl.MdiParent = this;
                            ticketControl.Show();
                            controlWindows.cw.set_conOrdens(true);
                            firstTime = false;
                        }
                    }


                    if (controlWindows.cw.get_cliente())
                        clienteToolStripMenuItem.Enabled = false;
                    else
                        clienteToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_database())
                        databaseToolStripMenuItem.Enabled = false;
                    else
                        databaseToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_estacao())
                        estaçãoToolStripMenuItem.Enabled = false;
                    else
                        estaçãoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_produto())
                        produtoToolStripMenuItem.Enabled = false;
                    else
                        produtoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_relatorio())
                        relatorioToolStripMenuItem.Enabled = false;
                    else
                        relatorioToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_contOrdens())
                        controleDeOrdensToolStripMenuItem.Enabled = false;
                    else
                        controleDeOrdensToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_usuario())
                        usuarioToolStripMenuItem.Enabled = false;
                    else
                        usuarioToolStripMenuItem.Enabled = true;

                }
                else if ((int.Parse(User.user.get_accessLevel())) == 2)
                {
                    arquivoToolStripMenuItem.Enabled = true;
                    cadastroToolStripMenuItem.Enabled = false;
                    controleDeOrdensToolStripMenuItem.Enabled = true;
                    relatorioToolStripMenuItem.Enabled = false;
                    databaseToolStripMenuItem.Enabled = false;

                    if (!(controlWindows.cw.get_contOrdens()))
                    {
                        if (firstTime)
                        {
                            Visualizador ticketControl = new Visualizador();
                            ticketControl.MdiParent = this;
                            ticketControl.Show();
                            controlWindows.cw.set_conOrdens(true);
                            firstTime = false;
                        }
                    }

                    if (controlWindows.cw.get_cliente())
                        clienteToolStripMenuItem.Enabled = false;
                    else
                        clienteToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_database())
                        databaseToolStripMenuItem.Enabled = false;
                    else
                        databaseToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_estacao())
                        estaçãoToolStripMenuItem.Enabled = false;
                    else
                        estaçãoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_produto())
                        produtoToolStripMenuItem.Enabled = false;
                    else
                        produtoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_relatorio())
                        relatorioToolStripMenuItem.Enabled = false;
                    else
                        relatorioToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_contOrdens())
                        controleDeOrdensToolStripMenuItem.Enabled = false;
                    else
                        controleDeOrdensToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_usuario())
                        usuarioToolStripMenuItem.Enabled = false;
                    else
                        usuarioToolStripMenuItem.Enabled = true;

                }
                else if ((int.Parse(User.user.get_accessLevel())) == 1)
                {
                    arquivoToolStripMenuItem.Enabled = false;
                    cadastroToolStripMenuItem.Enabled = false;
                    controleDeOrdensToolStripMenuItem.Enabled = false;
                    relatorioToolStripMenuItem.Enabled = false;



                    if (controlWindows.cw.get_cliente())
                        clienteToolStripMenuItem.Enabled = false;
                    else
                        clienteToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_database())
                        databaseToolStripMenuItem.Enabled = false;
                    else
                        databaseToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_estacao())
                        estaçãoToolStripMenuItem.Enabled = false;
                    else
                        estaçãoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_produto())
                        produtoToolStripMenuItem.Enabled = false;
                    else
                        produtoToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_relatorio())
                        relatorioToolStripMenuItem.Enabled = false;
                    else
                        relatorioToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_contOrdens())
                        controleDeOrdensToolStripMenuItem.Enabled = false;
                    else
                        controleDeOrdensToolStripMenuItem.Enabled = true;
                    if (controlWindows.cw.get_usuario())
                        usuarioToolStripMenuItem.Enabled = false;
                    else
                        usuarioToolStripMenuItem.Enabled = true;

                }


            }
            else if (!(User.user.get_logado()))
            {
                if (!(User.user.get_winOpen()))
                {

                    login log = new login();
                    log.MdiParent = this;
                    log.Show();
                    User.user.set_winOpen(true);
                }
                arquivoToolStripMenuItem.Enabled = false;
                cadastroToolStripMenuItem.Enabled = false;
                controleDeOrdensToolStripMenuItem.Enabled = false;
                relatorioToolStripMenuItem.Enabled = false;
                configuracoesToolStripMenuItem.Enabled = false;

            }
        }

        private DataSet geraXML()
        {

            //Cria a estrutura do arquivo XML
            DataTable dtPath = new DataTable("Caminho");
            //DataTable dtEstTeste = new DataTable("Nome_Estacao");
            Type strType = System.Type.GetType("System.String");



            // string que contem o caminho para o XML salvo

            string pathXML;

            pathXML = dir.dr.get_dPath() + "database.xml";

            DataRow row = dtPath.NewRow();





            // Adiciona Colunas as tabelas
            dtPath.Columns.Add("Id", strType);
            dtPath.Columns.Add("Path", strType);
            /*dtEstTeste.Columns.Add("idStation", strType);
            dtEstTeste.Columns.Add("nameStation", strType);
            dtEstTeste.Columns.Add("descStation", strType);
            dtEstTeste.Columns.Add("prodStation", strType);
            dtEstTeste.Columns.Add("custStation", strType);
            // DataColumn[] dc = new DataColumn[1];
            //dc[0] =  dtPath.Columns["Id"];
            //dtPath.PrimaryKey = dc;  */
            row["Id"] = "1";
            row["Path"] = dir.dr.get_path() + "\\DownTimeControl.mdb";

            dtPath.Rows.Add(row);
            // adiciona as tabelas ao dataset

            dsPath.Tables.Add(dtPath);
            //dsPath.Tables.Add(dtEstTeste);


            //cria o XML Schema

            dsPath.WriteXml(pathXML, XmlWriteMode.WriteSchema);

            //retorna o dataset populado com as informações

            return dsPath;

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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.user.set_logado(false);

            login log = new login();
            log.MdiParent = this;

            log.Show();
        }

        private void trabalharOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trabalharOfflineToolStripMenuItem.Checked == false)
            {
                timer1.Enabled = false;
                trabalharOfflineToolStripMenuItem.Checked = true;
            }
            else
            {
                timer1.Enabled = true;
                trabalharOfflineToolStripMenuItem.Checked = false;
            }
        }

        private void causaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Causa cs = new Causa();
            cs.Show();

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            email popEmail = new email();

            popEmail.MdiParent = this;
            popEmail.Show();
        }

        private void servidorSMTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smtp smtp = new smtp();
            smtp.MdiParent = this;
            smtp.Show();
        }

        private void contaDeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emailSw email = new emailSw();
            email.MdiParent = this;
            email.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}