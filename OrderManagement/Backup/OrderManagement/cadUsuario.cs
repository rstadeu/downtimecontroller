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
    public partial class cadUsuario : Form
    {
        bool user;
        public cadUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_usuario(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            OleDbConnection conn1 = new OleDbConnection();
            conn1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbCommand cmd1 = new OleDbCommand("Select * from Usuario", conn1);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
            conn1.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);

            user = false;

            try
            {




                foreach (DataRow linhas in dt.Rows)
                {



                    if (linhas["UserID"].ToString() == txtUserID.Text)
                    {
                        user = true;


                    }



                }






                // MessageBox.Show("Dado salvo com sucesso!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if ((conn1.State == ConnectionState.Open))
                {
                    conn1.Close();
                }
                da.Dispose();
                dt.Dispose();
                conn1.Dispose();
                conn1 = null;
                cmd1.Dispose();
                cmd1 = null;
            }


            if (!user)
            {


                if (txtConfSenha.Text == txtSenha.Text)
                {

                    if (txtNome.Text != "")
                    {

                        if (txtSobreNome.Text != "")
                        {
                            if (txtUserID.Text != "")
                            {
                                if (cmbAccessLevel.Text != "")
                                {
                                    if (txtSenha.Text != "")
                                    {

                                        OleDbConnection conn = new OleDbConnection();
                                        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                                        OleDbCommand cmd = new OleDbCommand();
                                        //OleDbCommand cmd1 = new OleDbCommand();
                                        // DateTime dTime = DateTime.Now;
                                        string tempEstacao, tempDescricao;


                                        tempEstacao = txtNome.Text;
                                        tempDescricao = txtSobreNome.Text;

                                        tempEstacao = tempEstacao.ToUpper();
                                        tempDescricao = tempDescricao.ToUpper();


                                        try
                                        {
                                            //cmd1 =  new OleDbCommand("Select * From PartNumber WHERE = " + cmbPartNumber.Text, conn);
                                            // Int32 Id = new Int32();
                                            //Id = (Int32)cmd.Parameters["Código"].Value;

                                            cmd = new OleDbCommand("Insert Into Usuario(FirstName, LastName, UserID, PW, AccessLevel) " +
                                                "Values(@FirstName, @LastName, @UserID, @Password, @AccessLevel)", conn);
                                            cmd.Parameters.Add("@FirstName", OleDbType.VarChar, 50);
                                            cmd.Parameters.Add("@LastName", OleDbType.VarChar, 50);
                                            cmd.Parameters.Add("@UserID", OleDbType.VarChar, 50);
                                            cmd.Parameters.Add("@Password", OleDbType.VarChar, 50);
                                            cmd.Parameters.Add("@AccessLevel", OleDbType.VarChar, 50);


                                            cmd.Parameters["@FirstName"].Value = tempEstacao;
                                            cmd.Parameters["@LastName"].Value = tempDescricao;
                                            cmd.Parameters["@UserID"].Value = txtUserID.Text;
                                            cmd.Parameters["@Password"].Value = txtSenha.Text;
                                            cmd.Parameters["@AccessLevel"].Value = cmbAccessLevel.Text;






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
                                        MessageBox.Show("Digite uma senha", "Senha Nula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                    MessageBox.Show("Escolha um nivel de acesso entre 1 e 5", "Nivel de Acesso Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                                MessageBox.Show("Digite um ID de usuario.", "UserID nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Digite um sobrenome valido.", "Sobrenome Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Digite um nome valido", "Nome Nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                    MessageBox.Show("As Senhas nao combinam.", "Senha com valores diferentes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Selecione um outro nome de usuario", "UserID ja em uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            txtSenha.Text = "";
            txtSobreNome.Text = "";
            txtNome.Text = "";
            txtUserID.Text = "";
            cmbAccessLevel.Text = "";
            txtConfSenha.Text = "";
            txtNome.Focus();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSobreNome.Text = "";
            txtNome.Text = "";
            txtConfSenha.Text = "";
            txtUserID.Text = "";
            cmbAccessLevel.Text = "";
            txtNome.Focus();
        }

        private void cadUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}