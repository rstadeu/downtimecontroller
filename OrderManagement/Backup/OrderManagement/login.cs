using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int status;

            status = User.user.login(txtUsuario.Text, txtSenha.Text);

            if (status == 1)
            {
                if ((int.Parse(User.user.get_accessLevel())) == 1)
                {
                    DialogResult dr = new DialogResult();

                    dr = MessageBox.Show("Voce nao tem direito de acesso a\neste aplicativo", "Sem direitos de acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (dr.ToString() == "OK")
                    {
                        User.user.set_logado(false);
                        txtSenha.Text = "";
                        txtUsuario.Text = "";
                        txtUsuario.Focus();
                        User.user.set_winOpen(false);
                    }

                }
                //DialogResult diaresult = MessageBox.Show("Login Efetuado com Sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //if (diaresult.ToString() == "OK")
                //    this.Close();
                //break;
            }
            else if (status == 0)
            {
                DialogResult diaresult = MessageBox.Show("A senha esta incorreta!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaresult.ToString() == "OK")
                {
                    txtSenha.Text = "";
                    txtSenha.Focus();
                }
            }
            else if (status == 2)
            {
                DialogResult diaresult = MessageBox.Show("O usuario não esta registrado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaresult.ToString() == "OK")
                {
                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                    txtUsuario.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (User.user.get_logado())
            {
                this.Close();
            }
        }
    }
}