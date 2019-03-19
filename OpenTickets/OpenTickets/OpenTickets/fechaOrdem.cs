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
    public partial class fechaOrdem : Form
    {
        public fechaOrdem()
        {
            InitializeComponent();

            Chamado.chamado.carregaValores();

            lblCliente.Text = Chamado.chamado.get_customer();
            lblEstação.Text = Chamado.chamado.get_station();
            lblHoraParada.Text = Convert.ToString(Chamado.chamado.get_timeToStop());
            lblProduto.Text = Chamado.chamado.get_product();
            lblReason.Text = Chamado.chamado.get_typeOfProblem();
            lblUser.Text = Chamado.chamado.get_userOpenTicket();



            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fechaOrdem_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();

            string test = Test.teste.get_testName();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select Problemas FROM Problema", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Problema");
            daTest.Fill(dtTest);

            
             cmbProblema.ValueMember = "Problemas";
             cmbProblema.DataSource = dtTest;



            cnTest.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescProblem.Text != "")
            {
                Chamado.chamado.fechaOrdem(txtPartChanged.Text, User.user.get_userID(), txtDescProblem.Text, DateTime.Now,cmbProblema.Text);
                txtDescProblem.Text = "";
                txtPartChanged.Text = "";
                txtPartChanged.Focus();
                this.Close();
            }
            else
            {
                DialogResult diaR = MessageBox.Show("É necessário descrever o que aconteceu para dar \nna ordem.", "Descrever o Problema encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (diaR.ToString() == "OK")
                {
                    txtDescProblem.Focus();
                }
            }
        }

        private void fechaOrdem_FormClosing(object sender, FormClosingEventArgs e)
        {
            CJ.controlJanela.set_FechaOrdem(false);
        }
    }
}