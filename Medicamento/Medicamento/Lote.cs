using System;
using System.Collections.Generic;
using System.Text;

namespace Medicamento
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public DateTime Venc
        {
            get { return venc; }
            set { venc = value; }
        }

        public Lote(int id, int qtde, DateTime venc)
        {
            this.id = id;
            this.qtde = qtde;
            this.venc = venc;
        }

        public Lote()
            : this(0, 0, DateTime.Now)
        { }

        public String toString()
        {
            return id + " - Quantide de medicamentos: " + qtde + " - Vencimento: " + venc.ToString("dd/MM/yyyy");
        }
    }
}