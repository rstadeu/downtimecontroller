using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTickets
{
    class WindowControl
    {
        private bool AbreTicket;
        private bool FechaOrdem;
        private bool login;
        private bool StationRegister;


        public void set_AbreTicket(bool janela)
        {
            AbreTicket = janela;
        }
        public void set_FechaOrdem(bool janela)
        {
            FechaOrdem = janela;
        }
        public void set_Login(bool janela)
        {
            login = janela;
        }
        public void set_StationRegister(bool janela)
        {
            StationRegister = janela;
        }

        public bool get_AbreTicket()
        {
            return AbreTicket;
        }
        public bool get_FechaOrdem()
        {
            return FechaOrdem;
        }
        public bool get_Login()
        {
            return login;
        }
        public bool get_StationRegister()
        {
            return StationRegister;
        }







    }
}
