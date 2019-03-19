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
    public partial class AbreTicket : Form
    {
        public AbreTicket()
        {
            InitializeComponent();

            lblEstacao.Text = Test.teste.get_testName();
            //lblProduto.Text = Test.teste.get_produto();
            lblCliente.Text = Test.teste.get_cliente();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescProblema.Text = "";
            txtDescProblema.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string produto;
            produto = Test.teste.get_produto();
            if (txtDescProblema.Text != "")
            {
                
                Test.teste.set_produto(cmbProduto.Text);
                Chamado.chamado.set_typeOfProblem(txtDescProblema.Text);

                int atualizacao = Chamado.chamado.geraChamado();

                if (atualizacao == 1)
                {
                    Test.teste.set_produto(produto);
                    this.Close();
                }
                else if (atualizacao == 0)
                {

                    MessageBox.Show("erro");
                }
            }
            else
            {
                DialogResult diaResult = MessageBox.Show("É necessário descrever o problema", "Sem descrição do problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (diaResult.ToString() == "OK")
                {
                    txtDescProblema.Focus();
                }
            }
        }

        private void AbreTicket_Load(object sender, EventArgs e)
        {

            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();

            string test = Test.teste.get_testName();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select Produto FROM Test WHERE Test.TestName =\'" + test+"\'", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);

            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Test");
            daTest.Fill(dtTest);

            cmbProduto.ValueMember = "Produto";
            cmbProduto.DataSource = dtTest;

           

            cnTest.Close();



        }

        private void AbreTicket_FormClosing(object sender, FormClosingEventArgs e)
        {
            CJ.controlJanela.set_AbreTicket(false);
        }
    }
}