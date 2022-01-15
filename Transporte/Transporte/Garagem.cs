using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
            veiculos = new Stack<Veiculo>();
        }

        public Garagem()
            : this(0, "")
        {
            veiculos = new Stack<Veiculo>();
        }

        public int Id
        {
            get { return id; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public Stack<Veiculo> Veiculos
        {
            get { return veiculos; }
        }

        public int qtdeVeiculos()
        {
            return veiculos.Count;
        }

        public int potencialDeTransporte()
        {
            int potencial = 0;
            foreach(Veiculo veiculo in veiculos)
            {
                potencial += veiculo.Lotacao;
            }
            return potencial;
        }

        public Veiculo pesquisarVeiculo(Veiculo veiculo)
        {
            foreach(Veiculo v in veiculos)
            {
                if (v.Equals(veiculo))
                {
                    return v;
                }
            }
            return null;
        }

        public override bool Equals(object obj)
        {
            Garagem garagem = (Garagem)obj;
            return garagem.Id.Equals(id);
        }

        public override string ToString()
        {
            string retorno = "ID: " + id + ", Local: " + local + ", Quantidade de veículos: " + veiculos.Count +
                ", Potencial de transporte: " + potencialDeTransporte() + "\nVeículos:";
            foreach(Veiculo veiculo in veiculos)
            {
                retorno += "\n" + veiculo.ToString();
            }
            return retorno;
        }
    }
}
