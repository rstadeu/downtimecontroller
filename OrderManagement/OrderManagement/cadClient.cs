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
    public partial class cadClient : Form
    {
        public cadClient()
        {
            InitializeComponent();
        }

        private void cadClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_cliente(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "")
            {

                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                OleDbCommand cmd = new OleDbCommand();
                //OleDbCommand cmd1 = new OleDbCommand();
                // DateTime dTime = DateTime.Now;
                string temp;


                temp = txtCustomer.Text;

                temp = temp.ToUpper();


                try
                {
                    //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                    // Int32 Id = new Int32();
                    //Id = (Int32)cmd.Parameters["Código"].Value;

                    cmd = new OleDbCommand("Insert Into Cliente(Clientes)" +
                        "Values(@Clientes)", conn);
                    cmd.Parameters.Add("@Clientes", OleDbType.VarChar, 50);
                    // cmd.Parameters.Add("@Componente", OleDbType.VarChar, 50);



                    cmd.Parameters["@Clientes"].Value = temp;
                    //cmd.Parameters["@Componente"].Value = txtComponente.Text;






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
                MessageBox.Show("Digite um nome valido para o Cliente", "Cliente Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            txtCustomer.Text = "";
            txtCustomer.Focus();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCustomer.Text = "";
            txtCustomer.Focus();
            
        }
    }
}