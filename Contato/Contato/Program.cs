using System;

namespace Contato
{
    class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            int opcao = 0;
            do
            {
                Console.Write("\n 0. Sair \n" +
                    " 1.Adicionar contato \n" +
                    " 2.Pesquisar contato \n" +
                    " 3.Alterar contato \n" +
                    " 4.Remover contato \n" +
                    " 5.Listar contatos \n" +
                    "-------------------------\n" +
                    "Digite de acordo com a opcão: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nPrograma finalizado");
                        break;
                    case 1:
                        Console.WriteLine("\nDados do contato");
                        Console.Write("Digite o email: ");
                        string email = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite o nome: ");
                        string nome = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite o telefone: ");
                        string telefone = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Data de nascimento");
                        Console.Write("Dia: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mês: ");
                        int mes = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ano: ");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Data dtNasc = new Data(dia, mes, ano);
                        Contato contato = new Contato(email, nome, telefone, dtNasc);
                        contatos.adicionar(contato);
                        break;
                    case 2:
                        Console.Write("\nDigite o email do contato que deseja pesquisar: ");
                        string emailPesquisar = Convert.ToString(Console.ReadLine());
                        Contato pesquisar = new Contato(emailPesquisar, "", "", null);
                        Contato encontrado = contatos.pesquisar(pesquisar);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Contato não encontrado");
                        }
                        break;
                    case 3:
                        Console.Write("\nDigite o email do contato que deseja alterar: ");
                        string emailAlterar = Convert.ToString(Console.ReadLine());
                        Contato alterar = new Contato(emailAlterar, "", "", null);
                        Console.WriteLine(contatos.alterar(alterar) ? "Alterado" : "Contato não encontrado");
                        break;
                    case 4:
                        Console.Write("\nDigite o email do contato que deseja remover: ");
                        string emailRemover = Convert.ToString(Console.ReadLine());
                        Contato remover = new Contato(emailRemover, "", "", null);
                        Console.WriteLine(contatos.remover(remover) ? "Removido" : "Contato não encontrado");
                        break;
                    case 5:
                        foreach(Contato c in contatos.Agenda)
                        {
                            Console.WriteLine(c.ToString());
                        }
                        break;
                }
            } while (opcao > 0 && opcao <= 5);
        }
    }
}