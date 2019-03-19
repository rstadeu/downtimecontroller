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
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            InitializeComponent();
            
            
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= "+ dir.dr.get_path());

            OleDbCommand cm = new OleDbCommand("Select Station, TimeToStop, UserOpenTicket, Reason, TypeOfProblem, Customer, Product FROM Ocorrencias where ItsRunning = " + false + " ORDER BY TimeToStop DESC", cn);

            cn.Open();

            cm.CommandType = CommandType.Text;
            OleDbDataAdapter daVisualizar = new OleDbDataAdapter(cm);


            DataTable dtVisualizar = new DataTable("Ocorrencias");

            daVisualizar.Fill(dsPopulaGrid, "Ocorrencias");
            dtVisualizar = dsPopulaGrid.Tables["Ocorrencias"];

            dataGridView1.DataSource = dtVisualizar;

            cn.Close();

            popula();
            //treeView1.ExpandAll();
        }

        private void Visualizador_Load(object sender, EventArgs e)
        {

            
        }

        private void Visualizador_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlWindows.cw.set_conOrdens(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            dsPopulaGrid.Clear();
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + dir.dr.get_path());

            OleDbCommand cm = new OleDbCommand("Select Station, TimeToStop, UserOpenTicket, Reason, TypeOfProblem, Customer, Product FROM Ocorrencias where ItsRunning = " + false + " ORDER BY TimeToStop DESC", cn);

            cn.Open();

            cm.CommandType = CommandType.Text;
            OleDbDataAdapter daVisualizar = new OleDbDataAdapter(cm);
            dataGridView1.ClearSelection();


            DataTable dtVisualizar = new DataTable("Ocorrencias");

         daVisualizar.Fill(dsPopulaGrid, "Ocorrencias");
            /*if (dsPopulaGrid.HasChanges())
            {
                DataSet dsPopulaGridUp = new DataSet();
                dsPopulaGridUp = dsPopulaGrid.GetChanges();
               // dtVisualizar = dsPopulaGrid.Tables["Ocorrencias"];
                daVisualizar.Update(dsPopulaGridUp);
                dataGridView1.DataSource = dsPopulaGridUp;
                //dataGridView1.Update();
            }
            */
           // daVisualizar.Fill(dsPopulaGrid, "Ocorrencias");
            dtVisualizar = dsPopulaGrid.Tables["Ocorrencias"];

            dataGridView1.Update();

            cn.Close();

            //cn.Close();


        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            /*
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + dir.dr.get_path());
            OleDbCommand cm = new OleDbCommand("Select Station, TimeToStop, UserOpenTicket, Reason, TypeOfProblem, Customer, Product FROM Ocorrencias where ItsRunning = " + false , cn);


            cn.Open();

            cm.CommandType = CommandType.Text;
            OleDbDataAdapter daVisualizar = new OleDbDataAdapter(cm);


            DataTable dtVisualizar = new DataTable("Ocorrencias");

            daVisualizar.Fill(dsPopulaGrid, "Ocorrencias");
            dtVisualizar = dsPopulaGrid.Tables["Ocorrencias"];

            //dataGridView1.DataSource = dtVisualizar;




            this.listView1.Clear();
           foreach(TreeNode tr in treeView1.Nodes)
           {
               
               //MessageBox.Show(tr.Text);
               if (tr.IsSelected)
               {
                   foreach (DataRow dr in dtVisualizar.Rows)
                   {
                       if (dr["Customer"].ToString() == tr.Text)
                       {
                           ListViewItem lvI;
                           lvI = listView1.Items.Add(dr["Station"].ToString());
                           lvI.SubItems.Add(dr["UserOpenTicket"].ToString());
                          // MessageBox.Show(tr.Text);
                       }
                       else if (dr["Product"].ToString() == tr.Text)
                       {
                           ListViewItem lvI;
                           lvI = listView1.Items.Add(dr["Station"].ToString());
                           lvI.SubItems.Add(dr["UserOpenTicket"].ToString());
                       }
                       else if (dr["Station"].ToString() == tr.Text)
                       {
                           ListViewItem lvI;
                           lvI = listView1.Items.Add(dr["Station"].ToString());
                           lvI.SubItems.Add(dr["UserOpenTicket"].ToString());
                       }

                   }
               }

           }

            cn.Close();*/
        }

        private DataSet TreeViewData()
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + dir.dr.get_path());

            //OleDbCommand cm = new OleDbCommand("Select Station, TimeToStop, UserOpenTicket, Reason, TypeOfProblem, Customer, Product FROM Ocorrencias where ItsRunning = " + false, cn);

            con.Open();

            OleDbDataAdapter dadCats = new OleDbDataAdapter("SELECT * FROM Cliente", con);
            OleDbDataAdapter dadTest = new OleDbDataAdapter("SELECT * FROM Test", con);
            OleDbDataAdapter daProduto = new OleDbDataAdapter("SELECT * FROM Produto", con);

            DataSet dst = new DataSet();
            dadCats.Fill(dst, "Cliente");
            dadTest.Fill(dst, "Test");
            daProduto.Fill(dst, "Produto");

            DataRelation relacao = new DataRelation("Estacao",dst.Tables["Cliente"].Columns["Clientes"],dst.Tables["Test"].Columns["Cliente"]);
            DataRelation relacaoi = new DataRelation("Produto", dst.Tables["Cliente"].Columns["Clientes"], dst.Tables["Produto"].Columns["Cliente"]);
            dst.Relations.Add(relacao);
            dst.Relations.Add(relacaoi);

            return dst;

        }

        private void popula()
        {

            
	        DataSet dst = TreeViewData();
	        foreach (DataRow masterRow in dst.Tables["Cliente"].Rows)
	        {
                
		        TreeNode masterNode =
		          new TreeNode(Convert.ToString(masterRow["Clientes"]));
                treeView1.Nodes.Add(masterNode);
		        foreach (DataRow childRow in masterRow.GetChildRows("Produto"))
		        {
			        TreeNode childNode = new TreeNode();
                    childNode.Text = childRow["Descricao"].ToString();

                   // childNode.Text = childRow[""].ToString();
                    masterNode.Nodes.Add(childNode);

                    foreach (DataRow innerRow in masterRow.GetChildRows("Estacao"))
                    {
                        if (innerRow["Produto"].ToString() == childNode.Text)
                        {

                            TreeNode innerNode = new TreeNode();
                            innerNode.Text = innerRow["TestName"].ToString();

                            // childNode.Text = childRow[""].ToString();
                            childNode.Nodes.Add(innerNode);
                        }
                    }

		        }
	        }
        }

      



        
    }
}