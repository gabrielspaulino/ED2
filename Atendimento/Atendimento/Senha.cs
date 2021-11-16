using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }

        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }

        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }

        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        public Senha(int id)
        {
            this.id = id;
            dataGerac = DateTime.Now;
            HoraGerac = DateTime.Now;
        }

        public Senha()
            : this(0)
        { }

        public string dadosParciais()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos()
        {
            return id + " - " + DataGerac.ToString("dd/MM/yyyy") + " - " + HoraGerac.ToString("HH:mm:ss") + " - " +
                DataAtend.ToString("dd/MM/yyyy") + " - " + DataAtend.ToString("HH:mm:ss");
        }
    }
}
