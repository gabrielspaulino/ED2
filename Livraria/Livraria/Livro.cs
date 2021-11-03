using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
        }

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            exemplares = new List<Exemplar>();
        }

        public Livro()
            : this(0, "", "", "")
        { }

        public void adicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int qtde = 0;
            foreach(Exemplar e in exemplares)
            {
                if (e.disponivel() == true)
                {
                    qtde++;
                }
            }
            return qtde;
        }

        public int qtdeEmprestimos()
        {
            int qtde = 0;
            foreach(Exemplar e in exemplares)
            {
                qtde += e.Emprestimos.Count;
            }
            return qtde;
        }

        public double percDisponibilidade()
        {
            if(qtdeExemplares() != 0 )
            {
                return 0;
            }
            return qtdeDisponiveis() * 100 / qtdeExemplares();
        }

        public override bool Equals(object obj)
        {
            Livro livro = (Livro)obj;
            if(livro.Isbn == isbn)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "ISBN: " + isbn +
                "\nTítulo: " + titulo +
                "\nAutor: " + autor +
                "\nEditora: " + editora +
                "\nTotal de exemplares: " + qtdeExemplares() +
                "\nTotal de exemplares disponíveis: " + qtdeDisponiveis() +
                "\nPercentual de disponibilidade: " + percDisponibilidade();
        }
    }
}
