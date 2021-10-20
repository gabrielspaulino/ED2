using System;
using System.Collections.Generic;
using System.Text;

namespace FormContato
{
    class Contato
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Data DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }

        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public Contato()
            : this("", "", "", null)
        { }

        public int getIdade()
        {
            if (dtNasc.Mes < DateTime.Now.Month || (dtNasc.Mes == DateTime.Now.Month && dtNasc.Dia >= DateTime.Now.Day))
            {
                return DateTime.Now.Year - dtNasc.Ano;
            }
            return DateTime.Now.Year - dtNasc.Ano - 1;
        }

        public override string ToString()
        {
            return "\nEmail: " + email +
                "\nNome: " + nome +
                "\nTelefone: " + telefone +
                "\nData de nascimento: " + dtNasc.ToString() +
                "\nIdade: " + getIdade();
        }
    }
}