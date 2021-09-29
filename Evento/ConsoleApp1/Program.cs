using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("Digite o número máximo de eventos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Eventos eventos = new Eventos(n);

            do
            {
                Console.WriteLine("\nDigite de acordo com o que quer fazer:\n" +
                "0.Sair\n " +
                "1.Adicionar evento(escolher o dia, onde 1 = SEG, 2 = TER, ..., 6 = SAB)\n" +
                "2.Pesquisar evento(deverá retornar os dados do evento + participantes)\n" +
                "3.Listar eventos(informar dados básicos do evento + qtde participantes)\n" +
                "4.Adicionar participante(retornando o status da operação com mensagem)\n" +
                "5.Pesquisar participante(utilizar o e - mail como critério de pesquisa)\n" +
                "6.Informar quantidade total de participantes nos eventos da semana");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        break;
                    case 1:
                        Console.Write("Digite um número de acordo com o dia da semana: ");
                        int dia = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do evento: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a descrição do evento: ");
                        string descricao = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite a quantidade máxima de participantes: ");
                        int qtdeMaxParticipantes = Convert.ToInt32(Console.ReadLine());
                        Evento evento = new Evento(id, descricao, qtdeMaxParticipantes);
                        eventos.adicionarEvento(evento);
                        break;
                    case 2:
                        Console.Write("Digite o ID do evento que deseja pesquisar: ");
                        int idPesquisa = Convert.ToInt32(Console.ReadLine());
                        Evento pesquisa = new Evento(idPesquisa, "", 0);
                        foreach (Evento e in eventos.OsEventos)
                        {
                            if (e.Equals(pesquisa))
                            {
                                pesquisa = e;
                            }
                        }
                        if (pesquisa.Descricao == "")
                        {
                            Console.WriteLine("Evento não encontrado");
                        }
                        else
                        {
                            Console.WriteLine(pesquisa.ToString());
                        }
                        break;
                    case 3:
                        if (eventos.Adicionados == 0)
                        {
                            Console.WriteLine("Não há eventos");
                        }
                        else
                        {
                            Console.WriteLine(eventos.listaEventos());
                            break;
                        }
                        break;
                    case 4:
                        Console.Write("Digite o email do participante: ");
                        string email = Convert.ToString(Console.ReadLine());
                        Console.Write("Digite o nome do participante: ");
                        string nome = Convert.ToString(Console.ReadLine());
                        Participante add = new Participante(email, nome);
                        Console.Write("Digite o ID do evento em que deseja adicioná-lo: ");
                        int idEvento = Convert.ToInt32(Console.ReadLine());
                        Evento eventoAdd = new Evento(idEvento, "", 0);
                        if (add.podeInscrever(eventos) == false)
                        {
                            foreach (Evento e in eventos.OsEventos)
                            {
                                if (e.Equals(eventoAdd))
                                {
                                    eventoAdd = e;
                                }
                            }
                            if (eventoAdd.Descricao == "")
                            {
                                Console.WriteLine("Evento não encontrado");
                            }
                            else
                            {
                                eventoAdd.inscreverParticipante(add);
                                Console.WriteLine("Adicionado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não adicionado (já existente)");
                        }
                        break;
                    case 5:
                        Console.Write("Digite o email do participante: ");
                        string emailPesquisar = Convert.ToString(Console.ReadLine());
                        Participante pesquisar = new Participante(emailPesquisar, "");
                        Console.WriteLine(eventos.pesquisarParticipante(pesquisar));
                        break;
                    case 6:
                        Console.WriteLine(eventos.qtdeParticipantes() + " participantes");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao > 0 && opcao <= 6);
        }
    }
}
