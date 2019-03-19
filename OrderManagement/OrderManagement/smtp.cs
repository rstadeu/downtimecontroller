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
    public partial class smtp : Form
    {
        public smtp()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool thereIsServer;
            thereIsServer = false;
            if (txtServidor.Text != "")
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                OleDbCommand cmd = new OleDbCommand("Select * FROM SmtpServer", con);

                DataSet ds = new DataSet();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds, "smtp");
                DataTable dt = new DataTable();

                dt = ds.Tables["smtp"];

                foreach (DataRow dr in dt.Rows)
                {

                    thereIsServer = true;

                }

                con.Close();
                con.Dispose();
                if (thereIsServer)
                {

                    OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                    OleDbCommand cmd1 = new OleDbCommand("Update SmtpServer SET smtp = \'" + txtServidor.Text + "\'", con1);

                    con1.Open();
                    cmd1.ExecuteNonQuery();

                    con1.Close();

                    con1.Dispose();
                    this.Close();

                }
                else
                {

                    OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                    OleDbCommand cmd2 = new OleDbCommand("INSERT INTO SmtpServer(smtp) Values(@smtp)", con2);


                    cmd2.Parameters.Add("@smtp", OleDbType.VarChar, 50);
                    cmd2.Parameters["@smtp"].Value = txtServidor.Text;

                    con2.Open();
                    cmd2.ExecuteNonQuery();

                    con2.Close();

                    con2.Dispose();
                    this.Close();


                }

            }
        }
    }
}