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
    public partial class rptDowntime : Form
    {
        public rptDowntime()
        {
            InitializeComponent();

            dtpIni.Format = DateTimePickerFormat.Custom;
            dtpIni.CustomFormat = "MM/dd/yyyy";

            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.CustomFormat = "MM/dd/yyyy";
            populaComboBox("Cliente","Clientes", comboBox1);
            btnGerar.Enabled = false;
        }

        private void rptDowntime_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_relatorio(false);
        }

        private void rptDowntime_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            dsRelatorio dsReport = new dsRelatorio();
            generalReport Relatorio = new generalReport();

            OleDbConnection conn1 = new OleDbConnection();

            conn1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path() ;
            OleDbCommand cmd1 = new OleDbCommand("SELECT Ocorrencias.Station, Ocorrencias.TimeToStop, Ocorrencias.TimeToBack, Ocorrencias.UserOpenTicket, Ocorrencias.EngUser, Ocorrencias.Reason, Ocorrencias.TypeOfProblem, Ocorrencias.PartChanged, Ocorrencias.Customer, Ocorrencias.Product, Ocorrencias.DescricaoProblema, Ocorrencias.Problema, Usuario.FirstName, Usuario.LastName FROM (Ocorrencias INNER JOIN Usuario ON Ocorrencias.EngUser = Usuario.UserID OR Ocorrencias.UserOpenTicket = Usuario.UserID) WHERE Ocorrencias.ItsRunning = " + true + " AND Ocorrencias.TimeToStop BETWEEN ? AND ?  ORDER BY  Ocorrencias.TimeToStop", conn1);

            cmd1.Parameters.Add("dtpIni", OleDbType.Date);
            cmd1.Parameters.Add("dtpFim", OleDbType.Date);
            cmd1.Parameters["dtpIni"].Direction =
            ParameterDirection.Input;
            cmd1.Parameters["dtpFim"].Direction =
            ParameterDirection.Input;
            cmd1.Parameters["dtpIni"].Value = dtpIni.Value;

            cmd1.Parameters["dtpFim"].Value = dtpFim.Value;



            try
            {
                conn1.Open();



                /*cmd1.Parameters.Add("dtInicio", OleDbType.Date);
                cmd1.Parameters.Add("dtFinal", OleDbType.Date);
                cmd1.Parameters["dtInicio"].Direction =
                    ParameterDirection.Input;
                cmd1.Parameters["dtFinal"].Direction =
                    ParameterDirection.Input;
                cmd1.Parameters["dtInicio"].Value =
                dtInicio.Value /*+ (DateTime)" " + (DateTime)cmbHoraIni.Text;
                cmd1.Parameters["dtFinal"].Value =
                dtFinal.Value /*+ (DateTime)" " + (DateTime)cmbHoraFin.Text;*/

                //cmd.Parameters.Add("@PartNumber", txtPartNumber.Text);

                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd1);
                da1.SelectCommand = cmd1;
                da1.Fill(dsReport.Tables["DataTable1"]);

                // relatorio.Load("~\\Relatorio.rpt");

                Relatorio.SetDataSource(dsReport);
                crvRelatorio.ReportSource = Relatorio;
                conn1.Close();
                // MessageBox.Show("Dado salvo com sucesso!", "Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if ((conn1.State == ConnectionState.Open))
                {
                    conn1.Close();
                }
                conn1.Dispose();
                conn1 = null;
                cmd1.Dispose();
                cmd1 = null;
            }

        }

        private void populaComboBox(string dado,string coluna, ComboBox cmb)
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * from "+dado, cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable(coluna);

            daTest.Fill(dsTest, dado);


            dtTest = dsTest.Tables[dado];

            cmb.ValueMember = coluna;
            cmb.DataSource = dtTest;


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


        private void populaComboBox(string dado, string coluna,string onde1,string onde2, ComboBox cmb)
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * FROM Test WHERE Test.Cliente = \'" + onde1 + "\' AND Test.Produto = \'" + onde2 + "\'", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable(coluna);

            daTest.Fill(dsTest, dado);


            dtTest = dsTest.Tables[dado];

            cmb.ValueMember = coluna;
            cmb.DataSource = dtTest;


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



        private void populaComboBox(string dado, string coluna, string onde1, ComboBox cmb)
        {
            // Cria os parametros de conexao
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();
            OleDbConnection cnTest = new OleDbConnection(ConnectionString);
            OleDbCommand cmdTest = new OleDbCommand("Select * FROM Produto WHERE Produto.Cliente = \'" + onde1 + "\'", cnTest);

            OleDbDataAdapter daTest = new OleDbDataAdapter(cmdTest);
            cnTest.Open();

            DataSet dsTest = new DataSet();
            DataTable dtTest = new DataTable(coluna);

            daTest.Fill(dsTest, dado);


            dtTest = dsTest.Tables[dado];

            cmb.ValueMember = coluna;
            cmb.DataSource = dtTest;


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





        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {


               populaComboBox("Produto","Descricao",comboBox1.Text, comboBox3);

            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {


                populaComboBox("Test", "TestName",comboBox1.Text, comboBox3.Text, comboBox2);

            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaPressionada = (char)13;
            if (e.KeyChar == teclaPressionada)
            {


                btnGerar.Enabled = true;

            }

        }

        
    }
}