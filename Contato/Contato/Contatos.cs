using System;
using System.Collections.Generic;
using System.Text;

namespace Contato
{
    class Contatos
    {
        private List<Contato> agenda;

        public List<Contato> Agenda
        {
            get { return agenda; }
        }

        public Contatos()
        {
            agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            if(pesquisar(c) != null)
            {
                return false;
            }
            agenda.Add(c);
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            if(this.Equals(c))
            {
                foreach(Contato contato in this.agenda)
                {
                    if(contato.Email == c.Email)
                    {
                        return contato;
                    }
                }
            }
            return null;
        }

        public bool alterar(Contato c)
        {
            Contato pesquisar = this.pesquisar(c);
            if (pesquisar != null)
            {
                Console.Write("Digite o novo email: ");
                string email = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o novo nome: ");
                string nome = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o novo telefone: ");
                string telefone = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Data de nascimento");
                Console.Write("Dia:");
                int dia = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mês:");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ano:");
                int ano = Convert.ToInt32(Console.ReadLine());
                Data dtNasc = new Data(dia, mes, ano);
                pesquisar.Email = email;
                pesquisar.Nome = nome;
                pesquisar.Telefone = telefone;
                pesquisar.DtNasc = dtNasc;
                return true;
            }
            return false;
        }

        public bool remover(Contato c)
        {
            Contato pesquisar = this.pesquisar(c);
            if(pesquisar != null)
            {
                agenda.Remove(pesquisar);
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            foreach (Contato c in this.agenda)
            {
                if (c.Email == ((Contato)obj).Email)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
