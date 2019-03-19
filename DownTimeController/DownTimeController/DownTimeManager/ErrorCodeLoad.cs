using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Reflection;
using System.IO;
using System.Data.OleDb;


namespace DownTimeController.DownTimeManager
{
    public partial class ErrorCodeLoad : Telerik.WinControls.UI.RadForm
    {
        DataSet dataS = new DataSet();
        public ErrorCodeLoad()
        {
            InitializeComponent();
            string pathAssy = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                pathAssy = Path.Combine(pathAssy, "XMLData");
                pathAssy = Path.Combine(pathAssy, "ErrorCode.xml");
                if (File.Exists(pathAssy))
                {
                    try
                    {
                        dataS.ReadXml(pathAssy);
                        gvwExcel.DataSource = dataS.Tables[0];
                        gvwExcel.TableElement.BestFitColumns();
                    }
                    catch (Exception ex)
                    {

                    }
                }

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            string path;
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Select an Excel File :: Ticket Manager";
            openFileDialog1.AddExtension = true;
            openFileDialog1.DefaultExt = "*.xlsx | xlsx";
            openFileDialog1.Filter = "Microsoft Excel File|*.xlsx";

            openFileDialog1.ShowDialog();


            if (openFileDialog1.FileName != "")
            {
                path = openFileDialog1.FileName;
                string pathAssy = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                pathAssy = Path.Combine(pathAssy, "XMLData");
                pathAssy = Path.Combine(pathAssy, "ErrorCode.xml");
                lblFileName.Text = openFileDialog1.FileName;

                string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+path+
                                @";Extended Properties=""Excel 12.0;HDR=YES""";

                OleDbConnection connection = new OleDbConnection(conn);

                string commandQuery = "Select* from [Plan1$A1:D65000]";

                OleDbCommand comm = new OleDbCommand(commandQuery, connection);

                try
                {
                    connection.Open();
                    ds.Clear();
                    adp.SelectCommand = comm;
                    adp.Fill(ds);
                    gvwExcel.DataSource = ds.Tables[0];
                    gvwExcel.TableElement.BestFitColumns();

                    if (!File.Exists(pathAssy))
                    {
                        ds.WriteXml(pathAssy);

                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ErrorCodeLoad_Load(object sender, EventArgs e)
        {

        }
    }
}
