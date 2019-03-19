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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
            populaComboBox();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            cmbCliente.Text = "";
        }

        private void CadProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_produto(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPartNumber.Text = "";
            txtDescricao.Text = "";
            txtPartNumber.Focus();
            cmbCliente.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtPartNumber.Text != "")
            {
                if (cmbCliente.Text != "")
                {
                    if (txtDescricao.Text != "")
                    {


                        OleDbConnection conn = new OleDbConnection();
                        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                        OleDbCommand cmd = new OleDbCommand();
                        //OleDbCommand cmd1 = new OleDbCommand();
                        // DateTime dTime = DateTime.Now;
                        string temp, temp1;


                        temp = txtPartNumber.Text;
                        temp1 = txtDescricao.Text;

                        temp = temp.ToUpper();
                        temp1 = temp1.ToUpper();


                        try
                        {
                            //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                            // Int32 Id = new Int32();
                            //Id = (Int32)cmd.Parameters["Código"].Value;

                            cmd = new OleDbCommand("Insert Into Produto(FlexPartNumber, Descricao, Cliente)" +
                                "Values(@FlexPartNumber, @Descricao, @Cliente)", conn);
                            cmd.Parameters.Add("@FlexPartNumber", OleDbType.VarChar, 50);
                            cmd.Parameters.Add("@Descricao", OleDbType.VarChar, 50);
                            cmd.Parameters.Add("@Cliente", OleDbType.VarChar, 50);


                            cmd.Parameters["@Cliente"].Value = cmbCliente.Text;
                            cmd.Parameters["@Descricao"].Value = temp1;
                            cmd.Parameters["@FlexPartNumber"].Value = temp1;






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
                    }
                    else
                        MessageBox.Show("Digite uma descricao para o Produto", "Descricao Nula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Escolha um cliente valido.", "Cliente Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Nao e permitido que o \nPart Number fique nulo.", "Part Number Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txtPartNumber.Text = "";
            txtDescricao.Text = "";
            txtPartNumber.Focus();
            //cmbCliente.Top = 0;
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

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}