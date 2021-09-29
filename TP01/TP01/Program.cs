using System;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores(10);

            int opcao = 1;
            do
            {
                Console.WriteLine("\n0.Sair" +
                    "\n1.Cadastrar vendedor" +
                    "\n2.Consultar vendedor" +
                    "\n3.Excluir vendedor" +
                    "\n4.Registrar venda" +
                    "\n5.Listar vendedores");
                Console.Write("\nDigite uma das opcoes: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        {
                            opcao = 10;
                        }
                        break;
                    case 1:
                        {
                            Console.Write("Digite o ID do vendedor: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o nome do vendedor: ");
                            string nome =  Convert.ToString(Console.ReadLine());
                            double percComissao = 0;
                            do
                            {
                                Console.Write("Digite a porcentagem de comissão do vendedor: ");
                                percComissao = Convert.ToDouble(Console.ReadLine());
                            } while (percComissao < 0 || percComissao > 1);
                            Vendedor vendedor = new Vendedor(id, nome, percComissao);
                            Console.WriteLine(vendedores.addVendedor(vendedor) ? "Cadastrado" : "Não cadastrado");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Digite o ID do vendedor que deseja consultar: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Vendedor consultar = new Vendedor(id, "", 0.0);
                            Vendedor encontrado = vendedores.searchVendedor(consultar);
                            if (encontrado.Nome != "")
                            {
                                Console.WriteLine("\nID: " + encontrado.Id);
                                Console.WriteLine("Nome: " + encontrado.Nome);
                                Console.WriteLine("Valor de vendas: " + String.Format("{0:0.00}", encontrado.valorVendas()));
                                Console.WriteLine("Comissão: " + String.Format("{0:0.00}", encontrado.valorComissao()));
                            }
                            else
                            {
                                Console.WriteLine("Vendedor não encontrado");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Digite o ID do vendedor que deseja excluir: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Vendedor x = new Vendedor(id, "", 0.0);
                            Vendedor excluir = vendedores.searchVendedor(x);
                            if(excluir.Nome == "")
                            {
                                Console.WriteLine("Vendedor não encontrado");
                            }
                            else if (excluir.valorVendas() == 0)
                            {
                                vendedores.delVendedor(excluir);
                                Console.WriteLine("Vendedor excluído");
                            }
                            else
                            {
                                Console.WriteLine("Você não pode excluir esse vendedor pois ele já realizou vendas");
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Digite a quantidade vendida: ");
                            int qtde = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o valor vendido: ");
                            double valor = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Digite o dia da venda: ");
                            int dia = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite o ID do vendedor: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Vendedor pesquisar = new Vendedor(id, "", 0.0);
                            Vendedor vendedor = vendedores.searchVendedor(pesquisar);
                            if (vendedor.Nome == "")
                            {
                                Console.WriteLine("Venda não registrada");
                            }
                            else
                            {
                                vendedor.registrarVenda(dia, new Venda(qtde, valor));
                                Console.WriteLine("Venda registrada");
                            }
                        }
                        break;
                    case 5:
                        {
                            foreach(Vendedor v in vendedores.OsVendedores)
                            {
                                if (v.Id != 0)
                                {
                                    Console.WriteLine("\nID: " + v.Id);
                                    Console.WriteLine("Nome: " + v.Nome);
                                    Console.WriteLine("Valor de vendas: " + String.Format("{0:0.00}", v.valorVendas()));
                                    Console.WriteLine("Comissão: " + String.Format("{0:0.00}", v.valorComissao()));
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (opcao <= 5);

            Console.Write("\nPrograma Finalizado");

            Console.ReadKey();
        }
    }
}
