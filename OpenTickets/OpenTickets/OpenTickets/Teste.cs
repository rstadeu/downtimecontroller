using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace OpenTickets
{
    class Teste
    {
        private int id;
        private string testName;
        private string descricao;
        private string produto;
        private string cliente;

        public void set_id(int identify)
        {
            id = identify;
        }
        public void set_testName(string nameStation)
        {
            testName = nameStation;
        }
        public void set_descricao(string desc)
        {
            descricao = desc;
        }
        public void set_produto(string product)
        {
            produto = product;
        }
        public void set_cliente(string customer)
        {
            cliente = customer;
        }

        public int get_id()
        {
            return id;
        }
        public string get_testName()
        {
            return testName;
        }
        public string get_descricao()
        {
            return descricao;
        }
        public string get_produto()
        {
            return produto;
        }
        public string get_cliente()
        {
            return cliente;
        }
    }
}
