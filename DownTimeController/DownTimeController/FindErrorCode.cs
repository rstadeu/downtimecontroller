using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DownTimeController.Classes;
using System.Linq;
using System.Xml.Linq;

using System.IO;
using System.Reflection;

namespace DownTimeController
{
    public partial class FindErrorCode : Telerik.WinControls.UI.RadForm
    {
        string pathAssy = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        DataSet dataS = new DataSet();
        ErrorCode er = new ErrorCode();
        public FindErrorCode()
        {
           

            InitializeComponent();
            /*
            ColumnHeader id = new ColumnHeader();
            id.Text = "ID";
            ColumnHeader errorCode = new ColumnHeader();
            errorCode.Text = "Error Code";
            ColumnHeader description = new ColumnHeader();
            description.Text = "Description";
            ColumnHeader errorGroup = new ColumnHeader();
            errorGroup.Text = "Error Group";

            lvwErrorCode.Columns.Add(id);
            lvwErrorCode.Columns.Add(errorCode);
            lvwErrorCode.Columns.Add(description);
            lvwErrorCode.Columns.Add(errorGroup);
            */
            grvErrorCode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            pathAssy = Path.Combine(pathAssy, "XMLData");
            pathAssy = Path.Combine(pathAssy, "ErrorCode.xml");
            if (File.Exists(pathAssy))
            {
                try
                {
                    /*
                    string file = Path.Combine(AbsolutePath.absPath.getAbsolutePath(), "ErrorCode.xml");
                    string loadXML = Convert.ToString( XDocument.Load(file));
                    var loadXML1 = XDocument.Parse(loadXML);
                    IEnumerable<ErrorCode> query = (from q in loadXML1.Descendants("Table")
                                                    select new ErrorCode
                                                    {
                                                         Id = Convert.ToInt16(q.Element("ID").Value),
                                                         Error_Code = q.Element("ErrorCode").Value,
                                                         Description = q.Element("Description").Value,
                                                         ErrorGroup = q.Element("ErrorGroup").Value
                                                     }).ToList();
                    
                    foreach (ErrorCode error in query)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = error.ToString();
                        item.SubItems.Add(error.ToString());
                        lvwErrorCode.Items.Add(item);

                    }*/
            

                    
                    dataS.ReadXml(pathAssy);
                   grvErrorCode.DataSource = dataS.Tables[0];
                  // grvErrorCode.TableElement.BestFitColumns();
                     
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void FindErrorCode_Load(object sender, EventArgs e)
        {

        }

        private void txtErrorCode_TextChanged(object sender, EventArgs e)
        {
            if (txtErrorCode.Text.Length <= 0)
            {
                 string file = Path.Combine(AbsolutePath.absPath.getAbsolutePath(), "ErrorCode.xml");
                var loadXML = XDocument.Load(file);
                var query = (from q in loadXML.Descendants("ID")
                             select new
                             {
                                      Id = Convert.ToInt16(q.Element("ID").Value),
                                      Error_Code = q.Element("ErrorCode").Value,
                                      Description = q.Element("Description").Value,
                                      ErrorGroup = q.Element("ErrorGroup").Value
                             }).ToList();
                
               grvErrorCode.DataSource = query.ToList();
            }
            else
            {
                if (txtErrorCode.Text.Substring(0) == "0" &&
                    string.IsNullOrEmpty(txtErrorCode.Text.Substring(1)))
                {
                    grvErrorCode.DataSource = dataS.Tables[0];
                }
                else if (txtErrorCode.Text.Substring(0, 1) == "0" &&
                    txtErrorCode.Text.Substring(1, 1) == "x" && txtErrorCode.Text.Length == 2)
                {

                    grvErrorCode.DataSource = dataS.Tables[0];
                }
                else
                {
                    //txtErrorCode.Text = txtErrorCode.Text.Substring(2, (txtErrorCode.Text.Length - 2)).ToUpper();
                    string file = Path.Combine(AbsolutePath.absPath.getAbsolutePath(), "ErrorCode.xml");
                    var loadXML = XDocument.Load(file);

                    try
                    {

                        var result1 = loadXML.Descendants("Table");
                        var result = (from er in loadXML.Descendants("Table")
                                      where er.Element("ErrorCode").Value.StartsWith((txtErrorCode.Text.Trim()))
                                      select new ErrorCode
                                      {
                                          Id = Convert.ToInt16(er.Element("ID").Value),
                                          Error_Code = er.Element("ErrorCode").Value,
                                          Description = er.Element("Description").Value,
                                          ErrorGroup = er.Element("ErrorGroup").Value


                                      });

                        IEnumerable<ErrorCode> error = result.ToList();
                        //error = error;
                        grvErrorCode.DataSource = error;

                        //string text = grvErrorCode.ToString();



                    }
                    catch (Exception ex)
                    {
                        // MessageBox.Show(ex.ToString(), "Error");
                    }

                }
            }
        }

        private void grvErrorCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            ErrorCodeExtender.erro.Id = Convert.ToInt16(grvErrorCode.CurrentRow.Cells[0].Value.ToString());
            ErrorCodeExtender.erro.Error_Code = grvErrorCode.CurrentRow.Cells[1].Value.ToString();
            ErrorCodeExtender.erro.Description = grvErrorCode.CurrentRow.Cells[2].Value.ToString();
            ErrorCodeExtender.erro.ErrorGroup = grvErrorCode.CurrentRow.Cells[3].Value.ToString();

            ControlWinExtender.window.OpenTicket = false;
            ControlWinExtender.window.FirstTime = true;

            this.Close();

           
        }
    }
}
