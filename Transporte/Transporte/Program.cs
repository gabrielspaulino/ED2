using System;
using System.Collections.Generic;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Veiculos veiculos = new Veiculos();
            Garagens garagens = new Garagens();
            garagens.incluir(new Garagem(1, "Congonhas"));
            garagens.incluir(new Garagem(2, "Guarulhos"));
            garagens.pesquisarGaragem(new Garagem(1, "")).Veiculos.Push(new Veiculo(1, "AAA0000", 10));
            garagens.pesquisarGaragem(new Garagem(1, "")).Veiculos.Push(new Veiculo(2, "AAA1111", 10));
            garagens.pesquisarGaragem(new Garagem(1, "")).Veiculos.Push(new Veiculo(3, "AAA2222", 10));
            garagens.pesquisarGaragem(new Garagem(1, "")).Veiculos.Push(new Veiculo(4, "AAA3333", 10));
            garagens.pesquisarGaragem(new Garagem(2, "")).Veiculos.Push(new Veiculo(5, "AAA4444", 10));
            garagens.pesquisarGaragem(new Garagem(2, "")).Veiculos.Push(new Veiculo(5, "AAA5555", 10));
            garagens.pesquisarGaragem(new Garagem(2, "")).Veiculos.Push(new Veiculo(5, "AAA6666", 10));
            garagens.pesquisarGaragem(new Garagem(2, "")).Veiculos.Push(new Veiculo(5, "AAA7777", 10));
            Viagens viagens = new Viagens();

            do
            {
                Console.Write("\n1. Cadastrar veículo" +
                       "\n2. Cadastrar garagem" +
                       "\n3. Iniciar jornada" +
                       "\n4. Encerrar jornada" +
                       "\n5. Liberar viagem de uma determinada origem para um determinado destino" +
                       "\n6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)" +
                       "\n7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino" +
                       "\n8. Listar viagens efetuadas de uma determinada origem para um determinado destino" +
                       "\n9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino" +
                       "\nDigite de acordo com o que deseja fazer: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        break;
                    case 1:
                        Console.Write("Digite o ID do veículo: ");
                        int idVeiculo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a placa do veículo: ");
                        string placa = Console.ReadLine();
                        Console.Write("Digite a lotação: ");
                        int lotacao = Convert.ToInt32(Console.ReadLine());
                        Veiculo veiculo = new Veiculo(idVeiculo, placa, lotacao);
                        Boolean incluiu = veiculos.incluir(veiculo);
                        Console.WriteLine(incluiu ? "Cadastrado" : "Não cadastrado");
                        int idGaragem;
                        Garagem garagem;
                        if (incluiu == true)
                        {
                            Console.Write("Digite o ID da garagem: ");
                            idGaragem = Convert.ToInt32(Console.ReadLine());
                            garagem = garagens.pesquisarGaragem(new Garagem(idGaragem, ""));
                            if (garagem != null)
                            {
                                garagem.Veiculos.Push(veiculo);
                                Console.WriteLine("Veículo registrado na garagem");
                            }
                            else
                            {
                                Console.WriteLine("Garagem não encontrada");
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Digite o ID da garagem: ");
                        idGaragem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o local: ");
                        string local = Console.ReadLine();
                        garagem = new Garagem(idGaragem, local);
                        Console.WriteLine(garagens.incluir(garagem) ? "Cadastrada" : "ID já cadastrado");
                        break;
                    case 3:
                        if (garagens.JornadaAtiva != true)
                        {
                            garagens.iniciarJornada();
                            Console.WriteLine("Jornada iniciada");
                        }
                        else
                        {
                            Console.WriteLine("Jornada já em andamento");
                        }
                        break;
                    case 4:
                        List<Transporte> transportes = garagens.encerrarJornada();
                        Console.WriteLine("Transportes realizados na jornada:");
                        foreach(Transporte transporte in transportes)
                        {
                            Console.WriteLine(transporte.ToString());
                        }
                        break;
                    case 5:
                        int idOrigem;
                        int idDestino;
                        if (garagens.JornadaAtiva == true)
                        {
                            Console.Write("Digite o ID da viagem: ");
                            int idViagem = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o ID da origem: ");
                            idOrigem = Convert.ToInt32(Console.ReadLine());
                            Garagem garagemOrigem = garagens.pesquisarGaragem(new Garagem(idOrigem, ""));
                            if (garagemOrigem != null)
                            {
                                Console.Write("Digite o ID do destino: ");
                                idDestino = Convert.ToInt32(Console.ReadLine());
                                Garagem garagemDestino = garagens.pesquisarGaragem(new Garagem(idDestino, ""));
                                if (garagemDestino != null)
                                {
                                    if (garagemOrigem.qtdeVeiculos() > 0)
                                    {
                                        veiculo = garagemOrigem.Veiculos.Peek();
                                        Boolean liberou = viagens.incluir(new Viagem(idViagem, garagemOrigem, garagemDestino, veiculo));
                                        Console.WriteLine( liberou ? "Liberada" : "Não Liberada");
                                        if (liberou == true)
                                        {
                                            garagemOrigem.Veiculos.Pop();
                                            garagemDestino.Veiculos.Push(veiculo);
                                            garagens.Transportes.Add(new Transporte(veiculo, veiculo.Lotacao));
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Garagem vazia");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Garagem não encontrada");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Garagem não encontrada");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A jornada não está ativa");
                        }
                        break;
                    case 6:
                        Console.Write("Digite o ID da garagem: ");
                        idGaragem = Convert.ToInt32(Console.ReadLine());
                        garagem = garagens.pesquisarGaragem(new Garagem(idGaragem, ""));
                        if(garagem != null)
                        {
                            Console.WriteLine(garagem.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Garagem não encontrada");
                        }
                        break;
                    case 7:
                        int qtdeViagens = 0;
                        Console.Write("Digite o ID do local de origem da viagem: ");
                        idOrigem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ID do local de destino da viagem: ");
                        idDestino = Convert.ToInt32(Console.ReadLine());
                        foreach (Viagem v in viagens.QueueViagnes)
                        {
                            if (v.Origem.Equals(garagens.pesquisarGaragem(new Garagem(idOrigem, ""))) && v.Destino.Equals(garagens.pesquisarGaragem(new Garagem(idDestino, ""))))
                            {
                                qtdeViagens += 1;
                            }
                        }
                        Console.WriteLine("Total de viagens: " + qtdeViagens);
                        break;
                    case 8:
                        Console.Write("Digite o ID do local de origem da viagem: ");
                        idOrigem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ID do local de destino da viagem: ");
                        idDestino = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Viagens efetuadas: ");
                        foreach (Viagem v in viagens.QueueViagnes)
                        {
                            if (v.Origem.Equals(garagens.pesquisarGaragem(new Garagem(idOrigem, ""))) && v.Destino.Equals(garagens.pesquisarGaragem(new Garagem(idDestino, ""))))
                            {
                                Console.WriteLine(v.ToString());
                            }
                        }
                        break;
                    case 9:
                        int qtdePassageiros = 0;
                        Console.Write("Digite o ID do local de origem da viagem: ");
                        idOrigem = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ID do local de destino da viagem: ");
                        idDestino = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Quantidade de passageiros transportados: ");
                        foreach (Viagem v in viagens.QueueViagnes)
                        {
                            if (v.Origem.Equals(garagens.pesquisarGaragem(new Garagem(idOrigem, ""))) && v.Destino.Equals(garagens.pesquisarGaragem(new Garagem(idDestino, ""))))
                            {
                                qtdePassageiros += v.Veiculo.Lotacao;
                                Console.Write(qtdePassageiros);
                            }
                        }
                        break;
                }
            } while (opcao > 0 && opcao <= 9);
        }
    }
}
