using System;

namespace Livraria
{
    class Program
    {
        static void Main(string[] args)
        {
            Livros livros = new Livros();
            int opcao = 0;

            do
            {
                Console.Write("--------------------------------------" +
                    "\n| 0. Sair                            |" +
                    "\n| 1. Adicionar livro                 |" +
                    "\n| 2. Pesquisar livro (sintético)*    |" +
                    "\n| 3. Pesquisar livro (analítico)**   |" +
                    "\n| 4. Adicionar exemplar              |" +
                    "\n| 5. Registrar empréstimo            |" +
                    "\n| 6. Registrar devolução             |" +
                    "\n--------------------------------------" +
                    "\nDigite de acordo com a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        break;
                    case 1:
                        Console.Write("Digite o ISBN do livro: ");
                        int isbn = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o título do livro: ");
                        string titulo = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite o autor do livro: ");
                        string autor = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite a editora do livro: ");
                        string editora = Convert.ToString(Console.ReadLine());
                        Livro livro = new Livro(isbn, titulo, autor, editora);
                        livros.adicionar(livro);
                        break;
                    case 2:
                        Console.Write("Digite o ISBN do livro que deseja pesquisar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro pesquisar = new Livro(isbn, "", "", "");
                        Livro encontrado = livros.pesquisar(pesquisar);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ISBN do livro que deseja pesquisar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        pesquisar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(pesquisar);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                            Console.WriteLine("Empréstimos registrados");
                            foreach (Exemplar e in encontrado.Exemplares)
                            {
                                Console.WriteLine(e.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ISBN do livro que deseja adicionar um exemplar: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro addExemplar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(addExemplar);
                        if(encontrado != null)
                        {
                            Console.Write("Digite o número do tombo: ");
                            int tombo = Convert.ToInt32(Console.ReadLine());
                            Exemplar exemplar = new Exemplar(tombo);
                            encontrado.adicionarExemplar(exemplar);
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                    case 5:
                        Console.Write("Digite o ISBN do livro: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro emprestar = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(emprestar);
                        int encontrou = 0;
                        if(encontrado != null)
                        {
                            Console.Write("Digite o número do tombo: ");
                            int tomboEmprestar = Convert.ToInt32(Console.ReadLine());
                            foreach(Exemplar e in encontrado.Exemplares)
                            {
                                if(e.Tombo == tomboEmprestar)
                                {
                                    Console.WriteLine(e.emprestar() ? "Emprestado" : "Não foi possível emprestar");
                                    encontrou = 1;
                                }
                            }
                            if(encontrou == 0)
                            {
                                Console.WriteLine("Exemplar não encontrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                    case 6:
                        Console.Write("Digite o ISBN do livro: ");
                        isbn = Convert.ToInt32(Console.ReadLine());
                        Livro devolver = new Livro(isbn, "", "", "");
                        encontrado = livros.pesquisar(devolver);
                        encontrou = 0;
                        if (encontrado != null)
                        {
                            Console.Write("Digite o número do tombo: ");
                            int tomboEmprestar = Convert.ToInt32(Console.ReadLine());
                            foreach (Exemplar e in encontrado.Exemplares)
                            {
                                if (e.Tombo == tomboEmprestar)
                                {
                                    Console.WriteLine(e.devolver() ? "Devolvido" : "Livro não emprestado");
                                    encontrou = 1;
                                }
                            }
                            if (encontrou == 0)
                            {
                                Console.WriteLine("Exemplar não encontrado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Livro não encontrado");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao >= 0 && opcao < 7);
        }
    }
}
