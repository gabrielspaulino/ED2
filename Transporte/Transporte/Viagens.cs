using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Viagens
    {
        private Queue<Viagem> queueViagens;

        public Viagens()
        {
            queueViagens = new Queue<Viagem>();
        }

        public Queue<Viagem> QueueViagnes
        {
            get { return queueViagens; }
        }

        public bool incluir(Viagem viagem)
        {
            foreach(Viagem v in queueViagens)
            {
                if (v.Equals(viagem))
                {
                    return false;
                }
            }
            queueViagens.Enqueue(viagem);
            return true;
        }
    }
}
