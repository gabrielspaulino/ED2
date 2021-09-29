using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TP01
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde;

        public Vendedores()
            : this(0)
        { }

        public Vendedores(int max)
        {
            osVendedores = new Vendedor[max];
            for(int i=0; i<max; i++)
            {
                osVendedores[i] = new Vendedor(0, "", 0.0);
            }
            this.max = max;
            this.qtde = 0;
        }

        public Vendedor[] OsVendedores
        {
            get { return osVendedores; }
            set { osVendedores = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public bool addVendedor(Vendedor v)
        {
            Vendedor encontrado = searchVendedor(v);
            if (qtde < max && encontrado.Nome == "")
            {
                osVendedores[qtde] = v;
                qtde++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool delVendedor(Vendedor v)
        {
            if (qtde > 0)
            {
                foreach (Vendedor x in osVendedores)
                {
                    if (v.Id.Equals(x.Id))
                    {
                        x.Id = 0;
                        x.Nome = "";
                        x.PercComissao = 0.0;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public Vendedor searchVendedor(Vendedor v)
        {
            Vendedor x = new Vendedor(0, "", 0.0);
            int i = 0;
            while (i<max && !v.Id.Equals(osVendedores[i].Id))
            {
                i++;
            }
            if(i < this.max)
            {
                x = osVendedores[i];
            }
            return x;
        }

        public double valorVendas()
        {
            double valorVendas = 0;
            foreach(Vendedor x in osVendedores)
            {
                valorVendas += x.valorVendas();
            }
            return valorVendas;
        }

        public double valorComissao()
        {
            double valorComissao = 0;
            foreach (Vendedor x in osVendedores)
            {
                valorComissao += x.valorComissao();
            }
            return valorComissao;
        }
    }
}
