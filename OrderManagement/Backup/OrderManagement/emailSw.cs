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
    public partial class emailSw : Form
    {
        public emailSw()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            bool thereIsEmail;
            thereIsEmail = false;
            if (txtEmail.Text != "")
            {
                if (txtPW.Text != "")
                {


                    OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                    OleDbCommand cmd = new OleDbCommand("Select * FROM email", con);

                    DataSet ds = new DataSet();

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(ds, "email");
                    DataTable dt = new DataTable();

                    dt = ds.Tables["email"];

                    foreach (DataRow dr in dt.Rows)
                    {

                        thereIsEmail = true;

                    }

                    con.Close();
                    con.Dispose();

                    if (thereIsEmail)
                    {

                        OleDbConnection con1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                        OleDbCommand cmd1 = new OleDbCommand("Update email SET endereco = \'" + txtEmail.Text + "\', pw = \'"+txtPW.Text+"\'" , con1);

                        con1.Open();
                        cmd1.ExecuteNonQuery();

                        con1.Close();

                        con1.Dispose();
                        this.Close();

                    }
                    else
                    {

                        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path());

                        OleDbCommand cmd2 = new OleDbCommand("INSERT INTO email(endereco, pw) Values(@endereco, @pw)", con2);


                        cmd2.Parameters.Add("@endereco", OleDbType.VarChar, 50);
                        cmd2.Parameters.Add("@pw", OleDbType.VarChar, 50);
                        cmd2.Parameters["@endereco"].Value = txtEmail.Text;
                        cmd2.Parameters["@pw"].Value = txtPW.Text;

                        con2.Open();
                        cmd2.ExecuteNonQuery();

                        con2.Close();

                        con2.Dispose();
                        this.Close();


                    }




                }
                else
                {
                    DialogResult dr = MessageBox.Show("Você precisar digitar uma senha.");
                    if (dr.ToString() == "OK")
                    {
                        txtPW.Text = "";
                        txtEmail.Text = "";
                        txtEmail.Focus();
                    }

                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Você precisar digitar o email.");
                if (dr.ToString() == "OK")
                {
                    txtPW.Text = "";
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }

            }
        }
    }
}