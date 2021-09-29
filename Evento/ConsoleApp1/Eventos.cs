using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Eventos
    {
        private Evento[] osEventos;
        private int adicionados;

        public Evento[] OsEventos
        {
            get { return osEventos; }
        }

        public int Adicionados
        {
            get { return adicionados; }
        }

        public Eventos(int n)
        {
            osEventos = new Evento[n];
            for(int i=0; i<n; i++)
            {
                osEventos[i] = new Evento(0, "", 0);
            }
            adicionados = 0;
        }

        public void adicionarEvento(Evento e)
        {
            osEventos[adicionados] = e;
            adicionados++;
        }

        public string pesquisarParticipante (Participante p)
        {
            for(int i=0; i<adicionados; i++)
            {
                foreach(Participante participante in osEventos[i].Participantes)
                {
                    if(participante.Equals(p))
                    {
                        return "Encontrado";
                    }
                }
            }
            return "Não encontrado";
        }

        public int qtdeParticipantes()
        {
            int total = 0;
            foreach(Evento e in osEventos)
            {
                total += e.qtdeParticipantes();
            }
            return total;
        }

        public string listaEventos()
        {
            string lista = "";
            foreach(Evento e in osEventos)
            {
                lista += e.ToString();
            }
            return lista;
        }
    }
}
