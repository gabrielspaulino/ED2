using System;
using System.Collections.Generic;
using System.Text;

namespace Medicamento
{
    class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

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

        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public Queue<Lote> Lotes
        {
            get { return lotes; }
        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.id = id;
            this.nome = nome;
            this.laboratorio = laboratorio;
            lotes = new Queue<Lote>();
        }

        public Medicamento()
            : this(0, "", "")
        {
            lotes = new Queue<Lote>();
        }

        public int qtdeDisponivel()
        {
            int qtde = 0;
            foreach (Lote lote in lotes)
            {
                qtde += lote.Qtde;
            }
            return qtde;
        }

        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            int total = 0;
            if (qtde <= this.qtdeDisponivel())
            {
                while (total < qtde)
                {
                    foreach (Lote l in lotes)
                    {
                        if (l.Qtde >= qtde - total)
                        {
                            l.Qtde -= qtde - total;
                            total += qtde;
                        }
                        else
                        {
                            total += l.Qtde;
                            l.Qtde = 0;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return id + " - " + nome + " - " + laboratorio + " - Quantidade disponível: " + qtdeDisponivel();
        }

        public override bool Equals(object obj)
        {
            Medicamento medicamento = (Medicamento)obj;
            return this.id.Equals(medicamento.Id);
        }
    }
}