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
    public partial class email : Form
    {
        public email()
        {
            InitializeComponent();
            populaComboBox();
            
        }

        private void email_Load(object sender, EventArgs e)
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
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Produto WHERE Cliente = \'" + cmbCliente.Text +"\'", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Produto");

            daTest.Fill(dsTest, "Produto");


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

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
             char teclaPressionada = (char)13;
             if (e.KeyChar == teclaPressionada)
             {
                 populaComboBox1();

             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string endereco;

            endereco = txtEmail.Text;
            endereco =  endereco.ToLower();
            if (endereco.EndsWith("@br.flextronics.com"))
            {
                if (cmbCliente.Text != "")
                {
                    if (cmbProduto.Text != "")
                    {



                        OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                OleDbCommand cmd = new OleDbCommand();
                //OleDbCommand cmd1 = new OleDbCommand();
                // DateTime dTime = DateTime.Now;
                


                try
                {
                    //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                    // Int32 Id = new Int32();
                    //Id = (Int32)cmd.Parameters["Código"].Value;

                    cmd = new OleDbCommand("Insert Into ListaEmail(endereco, produto, cliente)" +
                        "Values(@endereco, @produto, @cliente)", conn);
                    cmd.Parameters.Add("@endereco", OleDbType.VarChar, 50);
                    cmd.Parameters.Add("@produto", OleDbType.VarChar, 50);
                    cmd.Parameters.Add("@cliente", OleDbType.VarChar, 50);

                    cmd.Parameters["@endereco"].Value = endereco;
                    cmd.Parameters["@produto"].Value = cmbProduto.Text;
                    cmd.Parameters["@cliente"].Value = cmbCliente.Text;





                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DialogResult dr = MessageBox.Show("Voce deseja adicionar outro Email?","Adicionar Email.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dr == DialogResult.Yes)
                    {
                        txtEmail.Text = "";
                        cmbCliente.Text = "";
                        cmbProduto.Text = "";
                        txtEmail.Focus();
                    }
                    else if (dr == DialogResult.No)
                    {
                        this.Close();
                    }


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
            






                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Você precisar selecionar um valor para o campo Produto.");
                        if (dr.ToString() == "OK")
                        {
                            txtEmail.Text = "";
                            cmbProduto.Text = "";
                            cmbCliente.Text = "";
                            txtEmail.Focus();
                        }
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Você precisar selecionar um valor para o campo Cliente.");
                    if (dr.ToString() == "OK")
                    {
                        txtEmail.Text = "";
                        cmbProduto.Text = "";
                        cmbCliente.Text = "";
                        txtEmail.Focus();
                    }
                }

            }
            else
            {
                DialogResult dr = MessageBox.Show("Este endereco nao e um endereco valido", "Email fora do padrao @br.flextronics.com");
                if (dr.ToString() == "OK")
                    txtEmail.Text = "";
            }
        }

    }
}