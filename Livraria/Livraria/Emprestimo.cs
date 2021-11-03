using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria
{
    class Emprestimo
    {
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;

        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }
        
        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }

        public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
        }

        public override string ToString()
        {
            return "Data de empréstimo: " + dtEmprestimo +
                "\nData de devolução: " + dtDevolucao;
        }
    }
}
