using System;
using System.Collections.Generic;
using System.Text;

namespace TP01
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas;

        public Vendedor()
            : this(0, "", 0.0)
        { }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;
            asVendas = new Venda[31];
            for(int i=0; i< 31; i++)
            {
                asVendas[i] = new Venda(0, 0.0);
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double PercComissao
        {
            get { return percComissao; }
            set { percComissao = value; }
        }

        public Venda[] AsVendas
        {
            get { return asVendas; }
        }

        public void registrarVenda(int dia, Venda venda)
        {
            if (dia > 0 && dia <= 31)
            {
                asVendas[dia - 1] = venda;
            }
        }

        public double valorVendas()
        {
            double valorVendas = 0;
            for (int i = 0; i < 31; i++)
            {
                valorVendas += asVendas[i].Valor;
            }
            return valorVendas;
        }

        public double valorComissao()
        {
            double valorComissao = valorVendas() * percComissao;
            return valorComissao;
        }
    }
}
