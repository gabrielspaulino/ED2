using System;
using System.Collections.Generic;
using System.Text;

namespace Medicamento
{
    class Medicamentos
    {
        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos
        {
            get { return listaMedicamentos; }
        }

        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }

        public bool deletar(Medicamento medicamento)
        {
            foreach (Medicamento m in listaMedicamentos)
            {
                if (m.Equals(medicamento))
                {
                    if (m.qtdeDisponivel() == 0)
                    {
                        listaMedicamentos.Remove(medicamento);
                        return true;
                    }
                }
            }
            return false;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            foreach (Medicamento m in listaMedicamentos)
            {
                if (m.Equals(medicamento))
                {
                    return m;
                }
            }
            return null;
        }
    }
}