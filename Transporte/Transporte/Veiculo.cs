using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Veiculo
    {
        private int id;
        private string placa;
        private int lotacao;

        public Veiculo(int id, string placa, int lotacao)
        {
            this.id = id;
            this.placa = placa;
            this.lotacao = lotacao;
        }

        public Veiculo()
            : this(0, "", 0)
        { }

        public int Id
        {
            get { return id; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }

        public override bool Equals(object obj)
        {
            Veiculo veiculo = (Veiculo)obj;
            return veiculo.Id.Equals(id);
        }

        public override string ToString()
        {
            return "ID: " + id + ", Placa: " + placa + ", Lotação: " + lotacao;
        }
    }
}
