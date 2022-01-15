using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Transporte
    {
        private Veiculo veiculo;
        private int qtdeTransportada;

        public Transporte(Veiculo veiculo, int qtdeTransportada)
        {
            this.veiculo = veiculo;
            this.qtdeTransportada = qtdeTransportada;
        }

        public Transporte()
            : this(new Veiculo(0, "", 0), 0)
        { }

        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public int QtdeTransportada
        {
            get { return qtdeTransportada; }
            set { qtdeTransportada = value; }
        }

        public override string ToString()
        {
            return "Veículo:\n" + veiculo.ToString() + "\nQuantidade transportada: " + qtdeTransportada;
        }
    }
}
