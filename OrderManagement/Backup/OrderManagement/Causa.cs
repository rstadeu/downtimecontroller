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
    public partial class Causa : Form
    {
        public Causa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCausa.Text != "")
            {
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                OleDbCommand cmd = new OleDbCommand();
                //OleDbCommand cmd1 = new OleDbCommand();
                // DateTime dTime = DateTime.Now;
                string temp;


                temp = txtCausa.Text;
                //temp1 = txtDescricao.Text;

                temp = temp.ToUpper();
                // temp1 = temp1.ToUpper();


                try
                {
                    //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                    // Int32 Id = new Int32();
                    //Id = (Int32)cmd.Parameters["Código"].Value;

                    cmd = new OleDbCommand("Insert Into Problema(Problemas)" +
                        "Values(@Problemas)", conn);
                    cmd.Parameters.Add("@Problemas", OleDbType.VarChar, 50);



                    cmd.Parameters["@Problemas"].Value = txtCausa.Text;






                    conn.Open();
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    DialogResult dr = MessageBox.Show("Voce deseja adicionar outra causa?","Adicionar causa.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dr == DialogResult.Yes)
                    {
                        txtCausa.Text = "";
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
                DialogResult dr = MessageBox.Show("É necessário digitar algo no campo de texto.", "Dado Nulo.", MessageBoxButtons.OK);

                if (dr == DialogResult.OK)
                {
                    txtCausa.Text = "";
                }
            }
        }
    }
}