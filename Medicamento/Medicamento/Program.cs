using System;

namespace Medicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Medicamentos medicamentos = new Medicamentos();
            do
            {
                Console.Write("\n0.Finalizar processo\n" +
                    "1.Cadastrar medicamento\n" +
                    "2.Consultar medicamento (sintético)\n" +
                    "3.Consultar medicamento (analítico)\n" +
                    "4.Comprar medicamento\n" +
                    "5.Vender medicamento\n" +
                    "6.Listar medicamentos\n" +
                    "Digite o que deseja fazer: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa finalizado");
                        break;
                    case 1:
                        Console.Write("Digite o ID do medicamento: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do medicamento: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o laboratório do medicamento: ");
                        string laboratorio = Console.ReadLine();
                        Medicamento medicamento = new Medicamento(id, nome, laboratorio);
                        Medicamento pesquisa = medicamentos.pesquisar(medicamento);
                        if (pesquisa != null)
                        {
                            Console.WriteLine("ID já existente");
                        }
                        else
                        {
                            medicamentos.adicionar(medicamento);
                            Console.WriteLine("Cadastrado");
                        }
                        break;
                    case 2:
                        Console.Write("Digite o ID do medicamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        medicamento = new Medicamento(id, "", "");
                        Medicamento encontrado = medicamentos.pesquisar(medicamento);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Medicamento não encontrado");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do medicamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        medicamento = new Medicamento(id, "", "");
                        encontrado = medicamentos.pesquisar(medicamento);
                        if (encontrado != null)
                        {
                            Console.WriteLine(encontrado.ToString());
                            Console.WriteLine("Lotes:");
                            foreach (Lote l in encontrado.Lotes)
                            {
                                Console.WriteLine(l.toString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Medicamento não encontrado");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o ID do lote: ");
                        int idLote = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a qtde de medicamentos: ");
                        int qtde = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a data de vencimento: ");
                        DateTime venc = DateTime.Parse(Console.ReadLine());
                        Lote lote = new Lote(idLote, qtde, venc);
                        Console.Write("Digite o ID do medicamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        medicamento = new Medicamento(id, "", "");
                        Boolean comprou = false;
                        foreach (Medicamento m in medicamentos.ListaMedicamentos)
                        {
                            if (m.Equals(medicamento))
                            {
                                m.comprar(lote);
                                Console.WriteLine("Medicamento comprado");
                                comprou = true;
                            }
                        }
                        if (comprou == false)
                        {
                            Console.WriteLine("Medicamento não encontrado");
                        }
                        break;
                    case 5:
                        Console.Write("Digite o ID do medicamento: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a quantidade: ");
                        qtde = Convert.ToInt32(Console.ReadLine());
                        medicamento = new Medicamento(id, "", "");
                        encontrado = medicamentos.pesquisar(medicamento);
                        Console.WriteLine(encontrado.vender(qtde) ? "Vendeu" : "Não vendeu");
                        break;
                    case 6:
                        foreach (Medicamento m in medicamentos.ListaMedicamentos)
                        {
                            Console.WriteLine(m.ToString());
                        }
                        break;
                }
            } while (opcao > 0 && opcao <= 6);
        }
    }
}