using System;
using System.Collections.Generic;
using System.Text;

namespace FormContato
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
            setData(dia, mes, ano);
        }

        public Data()
            : this(1, 1, 2021)
        { }

        public void setData(int dia, int mes, int ano)
        {
            DateTime data = new DateTime(ano, mes, dia);
        }

        public override string ToString()
        {
            return dia + "/" + mes + "/" + ano;
        }
    }
}