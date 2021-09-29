using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Evento
    {
        private int id;
        private string descricao;
        private int qtdeMaxParticipantes;
        private int inscritos;
        private Participante[] participantes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int QtdeMaxParticipantes
        {
            get { return qtdeMaxParticipantes; }
            set { qtdeMaxParticipantes = value; }
        }

        public Participante[] Participantes
        {
            get { return participantes; }
        }

        public Evento(int id, string descricao, int qtdeMaxParticipantes)
        {
            this.id = id;
            this.descricao = descricao;
            this.qtdeMaxParticipantes = qtdeMaxParticipantes;
            inscritos = 0;
            participantes = new Participante[qtdeMaxParticipantes];
            for(int i=0; i<qtdeMaxParticipantes; i++)
            {
                participantes[i] = new Participante("", "");
            }
        }

        public Evento()
            : this(0, "", 0)
        { }

        public int inscreverParticipante(Participante p)
        {
            if(qtdeParticipantes() >= qtdeMaxParticipantes)
            {
                return 1;
            }
            foreach (Participante part in participantes)
            {
                if (p.Equals(part))
                {
                    return 2;
                }
            }
            participantes[inscritos] = p;
            inscritos++;
            return 0;
        }

        public int qtdeParticipantes()
        {
            return inscritos;
        }

        public string listaParticipantes()
        {
            string lista = "";
            foreach(Participante p in participantes)
            {
                lista += p.ToString();
            }
            return lista;
        }

        public bool Equals(Evento e)
        {
            if(e.Id == this.id)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            if (descricao != "")
            {
                return "Id: " + id +
                    ", Descrição: " + descricao +
                    ", Limite de participantes: " + qtdeMaxParticipantes + "\n";
            }
            return null;
        }
    }
}
