using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    class Veiculos
    {
        public List<Veiculo> listaVeiculos;

        public Veiculos()
        {
            listaVeiculos = new List<Veiculo>();
        }

        public List<Veiculo> ListaVeiculos
        {
            get { return listaVeiculos; }
        }

        public bool incluir(Veiculo veiculo)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v.Equals(veiculo))
                {
                    return false;
                }
            }
            listaVeiculos.Add(veiculo);
            return true;
        }
    }
}
