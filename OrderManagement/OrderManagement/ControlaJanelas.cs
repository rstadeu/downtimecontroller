using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class ControlaJanelas
    {
        private bool database;
        private bool login;
        private bool logout;
        private bool cliente;
        private bool usuario;
        private bool estacao;
        private bool produto;
        private bool contOrdens;
        private bool relatorio;


        public void set_database(bool janela)
        {
            database = janela;
        }
        public void set_login(bool janela)
        {
            login = janela;
        }
        public void set_logout(bool janela)
        {
            logout = janela;
        }
        public void set_cliente(bool janela)
        {
            cliente = janela;
        }
        public void set_usuario(bool janela)
        {
            usuario = janela;
        }
        public void set_estacao(bool janela)
        {
            estacao = janela;
        }
        public void set_produto(bool janela)
        {
            produto = janela;
        }
        public void set_conOrdens(bool janela)
        {
            contOrdens = janela;
        }
        public void set_relatorio(bool janela)
        {
            relatorio = janela;
        }


        public bool get_database()
        {
            return database;
        }
        public bool get_login()
        {
            return login;
        }
        public bool get_logout()
        {
            return logout;
        }
        public bool get_cliente()
        {
            return cliente;
        }
        public bool get_usuario()
        {
            return usuario;
        }
        public bool get_estacao()
        {
            return estacao;
        }
        public bool get_produto()
        {
            return produto;
        }
        public bool get_relatorio()
        {
            return relatorio;
        }
        public bool get_contOrdens()
        {
            return contOrdens;
        }






    }
}
