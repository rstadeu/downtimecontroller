using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OrderManagement
{
    public partial class cadStation : Form
    {
        public cadStation()
        {
            InitializeComponent();
            populaComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadStation_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_estacao(false);
        }

        private void cadStation_Load(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
        }


        private void populaComboBox()
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Cliente", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Clientes");

            daTest.Fill(dsTest, "Cliente");


            dtTest = dsTest.Tables["Cliente"];
            
            cmbCliente.ValueMember = "Clientes";
            cmbCliente.DataSource = dtTest;


            /*
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
            */




            cnTest.Close();




        }


        private void populaComboBox1()
        {

            //MessageBox.Show(cmbCliente.Text);
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * FROM Produto WHERE Produto.Cliente = \'" + cmbCliente.Text+"\'", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Descricao");

            daTest.Fill(dsTest, "Produto");

           // MessageBox.Show(cmbCliente.Text);
            dtTest = dsTest.Tables["Produto"];

            cmbProduto.ValueMember = "Descricao";
            cmbProduto.DataSource = dtTest;


            /*
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
            */




            cnTest.Close();




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!(cmbCliente.Text == ""))
            {
                

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!(txtDescricao.Text == ""))
            {
                if (!(txtEstacao.Text == ""))
                {
                    if (!(cmbCliente.Text == ""))
                    {
                        if (!(cmbProduto.Text == ""))
                        {
                            OleDbConnection conn = new OleDbConnection();
                            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                            OleDbCommand cmd = new OleDbCommand();
                            //OleDbCommand cmd1 = new OleDbCommand();
                            // DateTime dTime = DateTime.Now;
                            string tempEstacao, tempDescricao;


                            tempEstacao = txtEstacao.Text;
                            tempDescricao = txtDescricao.Text;

                            tempEstacao = tempEstacao.ToUpper();
                            tempDescricao = tempDescricao.ToUpper();


                            try
                            {
                                //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                                // Int32 Id = new Int32();
                                //Id = (Int32)cmd.Parameters["Código"].Value;

                                cmd = new OleDbCommand("Insert Into Test(TestName, Descricao, Produto, Cliente)" +
                                    "Values(@TestName, @Descricao, @Produto, @Cliente)", conn);
                                cmd.Parameters.Add("@TestName", OleDbType.VarChar, 50);
                                cmd.Parameters.Add("@Descricao", OleDbType.VarChar, 50);
                                cmd.Parameters.Add("@Produto", OleDbType.VarChar, 50);
                                cmd.Parameters.Add("@Cliente", OleDbType.VarChar, 50);


                                cmd.Parameters["@Cliente"].Value = cmbCliente.Text;
                                cmd.Parameters["@Descricao"].Value = tempDescricao;
                                cmd.Parameters["@TestName"].Value = tempEstacao;
                                cmd.Parameters["@Produto"].Value = cmbProduto.Text;






                                conn.Open();
                                cmd.ExecuteNonQuery();

                                conn.Close();

                                //  MessageBox.Show("Dados salvos com sucesso!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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


                            txtDescricao.Text = "";
                            txtEstacao.Text = "";
                            cmbProduto.Text = "";
                            cmbCliente.Text = "";

                            txtEstacao.Focus();
                        }
                        else
                            MessageBox.Show("Selecione um Produto para\nvincular a estacao","Estacao sem Produto",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Selecionar o Cliente", "Cliente nao Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                }
                else
                    MessageBox.Show("E necessario digitar um nome\npara a estacao", "Estacao sem Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Defina, brevemente, a funcionalidade\nda estacao","Descricao da Estacao",MessageBoxButtons.OK, MessageBoxIcon.Warning);







        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {


                populaComboBox1();

            }
        }


    }
}