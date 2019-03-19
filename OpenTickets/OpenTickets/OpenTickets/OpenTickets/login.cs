using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenTickets
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            int status;

            status = User.user.login(txtUsuario.Text, txtSenha.Text);

            if (status == 1)
            {
                DialogResult diaresult = MessageBox.Show("Login Efetuado com Sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaresult.ToString() == "OK")
                    this.Close();
            }
            else if (status == 0)
            {
                DialogResult diaresult = MessageBox.Show("A senha esta incorreta!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaresult.ToString() == "OK")
                    txtSenha.Text = "";
            }
            else if (status == 2)
            {
                DialogResult diaresult = MessageBox.Show("O usuario não esta registrado!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaresult.ToString() == "OK")
                {
                    txtSenha.Text = "";
                    txtUsuario.Text =  "";
                }
            }
        }
    }
}