using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
        }

        public Guiche()
        {
            atendimentos = new Queue<Senha>();
            id = 0;
        }

        public Guiche(int id)
        {
            atendimentos = new Queue<Senha>();
            this.id = id;
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if(filaSenhas.Count == 0)
            {
                return false;
            }
            Senha senha = filaSenhas.Dequeue();
            atendimentos.Enqueue(senha);
            senha.DataAtend = DateTime.Now;
            senha.HoraAtend = DateTime.Now;
            return true;
        }
    }
}
