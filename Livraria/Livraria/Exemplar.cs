using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
        }

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            emprestimos = new List<Emprestimo>();
        }

        public Exemplar()
            : this(0)
        { }

        public bool emprestar()
        {
            if (disponivel() == true)
            {
                emprestimos.Add(new Emprestimo(DateTime.Now, DateTime.Now.AddMonths(1)));
                return true;
            }
            return false;
        }

        public bool devolver()
        {
            foreach (Emprestimo e in emprestimos)
            {
                if (DateTime.Now >= e.DtEmprestimo && DateTime.Now <= e.DtDevolucao)
                {
                    emprestimos.Remove(e);
                    return true;
                }
            }
            return false;
        }

        public bool disponivel()
        {
            foreach(Emprestimo e in emprestimos)
            {
                if(DateTime.Now >= e.DtEmprestimo && DateTime.Now <= e.DtDevolucao)
                {
                    return false;
                }
            }
            return true;
        }

        public int qtdeDisponivel()
        {
            if(disponivel() == true)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            string toString = "";
            foreach(Emprestimo e in emprestimos)
            {
                toString += "Tombo: " + tombo + "\n" + e.ToString();
            }
            return toString;
        }

        public override bool Equals(object obj)
        {
            Exemplar exemplar = (Exemplar)obj;
            if(exemplar.Tombo == this.tombo)
            {
                return true;
            }
            return false;
        }
    }
}
