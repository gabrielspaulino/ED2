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
            List<Contato> agenda = new List<Contato>();
        }

        public bool adicionar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if(contato.Equals(c))
                {
                    return false;
                }
            }
            agenda.Add(c);
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if(contato.Equals(c))
                {
                    return contato;
                }
            }
            return null;
        }

        public bool alterar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (contato.Equals(c))
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
                    contato.Email = email;
                    contato.Nome = nome;
                    contato.Telefone = telefone;
                    contato.DtNasc = dtNasc;
                }
            }
            return false;
        }

        public bool remover(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (contato.Equals(c))
                {
                    agenda.Remove(contato);
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(Object obj)
        {
            Contato c = (Contato)obj;
            foreach (Contato contato in agenda)
            {
                if(contato.Telefone == c.Telefone)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
