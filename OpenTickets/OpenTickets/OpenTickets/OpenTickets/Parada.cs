using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTickets
{
    class Parada
    {
        private int id;
        private string station;
        private DateTime timeToStop;
        private DateTime timeToBack;
        private string userOpenTicket;
        private string engUser;
        private string reason;
        private string typeOfProblem;
        private string parteChanged;
        private bool itsRunning;


        public void set_id(int identification)
        {
            id = identification;
        }
        public void set_station(string estacao)
        {
            station = estacao;
        }
        public void set_timeToStop(DateTime horaParada)
        {
            timeToStop = horaParada;
        }
        public void set_timeToBack(DateTime horadaVolta)
        {
            timeToBack = horadaVolta;
        }
        public void set_userOpenTicket(string usuario)
        {
            userOpenTicket = usuario;

        }
        public void set_engUser(string engenharia)
        {
            engUser = engenharia;
        }

        public void set_reason(string razao)
        {
            reason = razao;
        }
        public void set_typeOfProblem(string tipoDeProblema)
        {
            typeOfProblem = tipoDeProblema;
        }
        public void set_parteChanged(string mudanca)
        {
            parteChanged = mudanca;
        }
        public void set_itsRunning(bool rodando)
        {
            itsRunning = rodando;
        }
        public int get_id()
        {
            return id;
        }
        public string get_station()
        {
            return station;
        }
        public DateTime get_timeToStop()
        {
            return timeToStop;
        }
        public DateTime get_timeToBack()
        {
            return timeToBack;
        }
        public string get_userOpenTicket()
        {
            return userOpenTicket;
        }

        public string get_engUser()
        {
            return engUser;
        }
        public string get_reason()
        {
            return reason;
        }
        public string get_typeOfProblem()
        {
            return typeOfProblem;
        }

        public string get_parteChanged()
        {
            return parteChanged;
        }
        public bool get_itsRunning()
        {
            return itsRunning;
        }
     }
}
