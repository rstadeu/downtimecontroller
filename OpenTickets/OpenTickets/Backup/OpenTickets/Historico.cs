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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
           this.Text = "Historico - "+Test.teste.get_testName()+" - "+Test.teste.get_cliente();

           lblCliente.Text = Test.teste.get_cliente();
           lblEstacao.Text = Test.teste.get_testName();
           lblProduto.Text = Test.teste.get_produto();



          // part = txtPartNumber.Text;
           OleDbConnection conn1 = new OleDbConnection();

           conn1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir.dr.get_path();


           try
           {
               //limpa o listview
               lvwHistorico.Columns.Clear();
               lvwHistorico.Items.Clear();

               //abre a conexao
               conn1.Open();

               //cria um comando oledb
               OleDbCommand cmd1 = conn1.CreateCommand();
               //define o tipo do comando como texto 
               cmd1.CommandText = "Select TimeToStop, TimeToBack, UserOpenTicket, EngUser, Reason, TypeOfProblem, PartChanged, Customer, Product, DescricaoProblema, Problema FROM Ocorrencias WHERE ItsRunning = "+true;

               //executa o comando e gera um datareader
               OleDbDataReader dr = cmd1.ExecuteReader();

               //preenche o cabeçalho do listview com os nomes dos campos

               ColumnHeader ch = new ColumnHeader();
               ch.Text = "Hora Parada";
               lvwHistorico.Columns.Add(ch);
               ColumnHeader ch1 = new ColumnHeader();
               ch1.Text = "Hora Retorno";
               lvwHistorico.Columns.Add(ch1);
               
               ColumnHeader ch2 = new ColumnHeader();
               ch2.Text = "Usuario que Abriu o Ticket";
               lvwHistorico.Columns.Add(ch2);
               ColumnHeader ch3 = new ColumnHeader();
               ch3.Text = "Usuario que Fechou";
               lvwHistorico.Columns.Add(ch3);
               ColumnHeader ch4 = new ColumnHeader();
               ch4.Text = "Razao da Abertura";
               lvwHistorico.Columns.Add(ch4);
               ColumnHeader ch5 = new ColumnHeader();
               ch5.Text = "Descrição do problema";
               lvwHistorico.Columns.Add(ch5);
               ColumnHeader ch6 = new ColumnHeader();
               ch6.Text = "Trocado";
               lvwHistorico.Columns.Add(ch6);
               ColumnHeader ch7 = new ColumnHeader();
               ch7.Text = "Cliente";
               lvwHistorico.Columns.Add(ch7);
               ColumnHeader ch8 = new ColumnHeader();
               ch8.Text = "Produto";
               lvwHistorico.Columns.Add(ch8);
               ColumnHeader ch9 = new ColumnHeader();
               ch9.Text = "Descricao Solucao";
               lvwHistorico.Columns.Add(ch9);
               ColumnHeader ch10 = new ColumnHeader();
               ch10.Text = "Acao Tomada";
               lvwHistorico.Columns.Add(ch10);


               //define um item listview
               ListViewItem item;

               //inicia leitura do datareader
               while (dr.Read())
               {
                   item = new ListViewItem();
                   item.Text = dr.GetValue(0).ToString();

                   //preenche o listview com itens
                   for (int i = 1; i < dr.FieldCount; i++)
                   {
                       item.SubItems.Add(dr.GetValue(i).ToString());
                       
                   }
                   lvwHistorico.Items.Add(item);
                   
               }
               //fecha o datareader
               dr.Close();
           }
           catch (System.Data.OleDb.OleDbException ex)
           {
               MessageBox.Show("Ocorreu um erro durante a execução da instrução SQL." +
                       "Erro : " + ex.Message, "SQL");
           }
           finally
           {
               //fecha a conexao
               conn1.Close();
           }
        }
    }
}