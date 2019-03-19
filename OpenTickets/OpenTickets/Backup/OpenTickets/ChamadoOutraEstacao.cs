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
    public partial class ChamadoOutraEstacao : Form
    {
        public ChamadoOutraEstacao()
        {
            InitializeComponent();

            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from Cliente", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable("Cliente");

            daTest.Fill(dsTest, "Cliente");


            dtTest = dsTest.Tables["Cliente"];


           // dtTest = dsTest.Tables["Test"];
            cmbCliente.ValueMember = "Clientes";
            cmbCliente.DataSource = dtTest;



           





            cnTest.Close();

            
        

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChamadoOutraEstacao_Load(object sender, EventArgs e)
        {

        }

        private void cmbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {
                string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                OleDbConnection cnTest = new OleDbConnection(ConnectionString);
                OleDbCommand cmdTest = new OleDbCommand("Select * from Produto WHERE Cliente =\'"+cmbCliente.Text+"\'", cnTest);

                OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
                cnTest.Open();

                DataSet dsTest = new DataSet();
                DataTable dtTest = new DataTable("Produto");

                daTest.Fill(dsTest, "Produto");


                dtTest = dsTest.Tables["Produto"];


                // dtTest = dsTest.Tables["Test"];
                cmbProduto.ValueMember = "Descricao";
                cmbProduto.DataSource = dtTest;



            }
        }

        private void cmbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {
                string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
                OleDbConnection cnTest = new OleDbConnection(ConnectionString);
                OleDbCommand cmdTest = new OleDbCommand("Select * from Test WHERE Cliente =\'" + cmbCliente.Text + "\' AND Produto =\'"+cmbProduto.Text+"\'", cnTest);

                OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
                cnTest.Open();

                DataSet dsTest = new DataSet();
                DataTable dtTest = new DataTable("Test");

                //daTest.Fill(dtTest);
                daTest.Fill(dsTest, "Test");


                dtTest = dsTest.Tables["Test"];

                // dtTest = dsTest.Tables["Test"];
                cmbEstacao.ValueMember = "TestName";
                cmbEstacao.DataSource = dtTest;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                if (cmbCliente.Text != "")
                {
                    if (cmbProduto.Text != "")
                    {
                        if (cmbEstacao.Text != "")
                        {
                            if (cmbReason.Text != "")
                            {
                                string produto, cliente, estacao;

                                produto = Test.teste.get_produto();
                                cliente = Test.teste.get_cliente();
                                estacao = Test.teste.get_testName();

                                Test.teste.set_produto(cmbProduto.Text);
                                Test.teste.set_testName(cmbEstacao.Text);
                                Test.teste.set_cliente(cmbCliente.Text);

                                Chamado.chamado.set_typeOfProblem(txtDescricao.Text);
                                Chamado.chamado.set_reason(cmbReason.Text);

                                int atualizacao = Chamado.chamado.geraChamado();
                                if (atualizacao == 1)
                                {

                                    Test.teste.set_produto(produto);
                                    Test.teste.set_testName(estacao);
                                    Test.teste.set_cliente(cliente);
                                    this.Close();
                                }
                                else if (atualizacao == 0)
                                {

                                    MessageBox.Show("erro");
                                }

                            }
                            else
                            {
                                DialogResult diaResult = MessageBox.Show("Todos os campos devem estar preenchidos", "Campo Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (diaResult.ToString() == "OK")
                                {
                                    txtDescricao.Focus();
                                }
                            }
                        }
                        else
                        {
                            DialogResult diaResult = MessageBox.Show("Todos os campos devem estar preenchidos", "Campo Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (diaResult.ToString() == "OK")
                            {
                                txtDescricao.Focus();
                            }
                        }

                    }
                    else
                    {
                        DialogResult diaResult = MessageBox.Show("Todos os campos devem estar preenchidos", "Campo Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (diaResult.ToString() == "OK")
                        {
                            txtDescricao.Focus();
                        }
                    }
                }
                else
                {
                    DialogResult diaResult = MessageBox.Show("Todos os campos devem estar preenchidos", "Campo Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (diaResult.ToString() == "OK")
                    {
                        txtDescricao.Focus();
                    }
                }

               
            }
            else
            {
                DialogResult diaResult = MessageBox.Show("É necessário descrever o problema", "Sem descrição do problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (diaResult.ToString() == "OK")
                {
                    txtDescricao.Focus();
                }
            }
        }
    }
}