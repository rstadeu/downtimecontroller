using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OpenTickets
{
    public partial class TrocaSenha : Form
    {
        public TrocaSenha()
        {
            InitializeComponent();

            txtUsuario.Enabled = false;

            txtUsuario.Text = User.user.get_firstName() + " "+ User.user.get_lastName();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtSenhaNova.Text == txtConfirmaSenha.Text)
            {
                if (txtSenhaNova.Text != "")
                {
                    string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


                    OleDbConnection cnTest = new OleDbConnection(ConnectionString);
                    OleDbCommand cmdTest = new OleDbCommand("Select * from Usuario", cnTest);

                    OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

                    cnTest.Open();

                    DataSet dsTest = new DataSet();
                    DataTable dtTest = new DataTable("Usuario");
                    daTest.Fill(dtTest);


                    foreach (DataRow dlTest in dtTest.Rows)
                    {
                        if (dlTest["UserID"].ToString() == txtUsuario.Text)
                        {
                            if (dlTest["PW"].ToString() == txtSenhaVelha.Text)
                            {
                                cnTest.Close();
                                OleDbConnection cnSenha = new OleDbConnection(ConnectionString);
                                OleDbCommand cmd = new OleDbCommand("Update Usuario SET PW =\'"+txtSenhaNova.Text+"\' WHERE UserID =\'" + txtUsuario.Text + "\'", cnSenha);

                                cnSenha.Open();
                                cmd.ExecuteNonQuery();
                                cnSenha.Close();
                                
                                DialogResult dr = MessageBox.Show("A sua Senha foi alterada com Sucesso!", "Senha Alterada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                if (dr.ToString() == "OK")
                                {
                                    this.Close();
                                }

                            }

                        }
                    }

                    if(cnTest.State == ConnectionState.Open)
                    cnTest.Close();


                }
                else
                {
                    DialogResult dr = MessageBox.Show("A senha não deve ser um valor nulo", "Senha com valor nulo.", MessageBoxButtons.OK);
                    if (dr.ToString() == "OK")
                    {
                        txtConfirmaSenha.Text = "";
                        txtSenhaNova.Text = "";

                    }

                }


            }
            else
            {
                DialogResult dr = MessageBox.Show("A senha deve ter os mesmo valores nos campos\nSenha Nova e Confirma Senha.", "As senhas não combinam", MessageBoxButtons.OK);
                if (dr.ToString() == "OK")
                {
                    txtConfirmaSenha.Text = "";
                    txtSenhaNova.Text = "";

                }

            }
        }
    }
}