using System;
using System.Data.SqlClient;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Cadastro cadastro = new Cadastro();
            cadastro.download();
            do
            {
                Console.Write("\n0.Sair" +
                    "\n1.Cadastrar ambiente" +
                    "\n2.Consultar ambiente" +
                    "\n3.Excluir ambiente" +
                    "\n4.Cadastrar usuario" +
                    "\n5.Consultar usuario" +
                    "\n6.Excluir usuario" +
                    "\n7.Conceder permissão de acesso ao usuario" +
                    "\n8.Revogar permissão de acesso ao usuario" +
                    "\n9.Registrar acesso" +
                    "\n10.Consultar logs de acesso" +
                    "\nDigite de acordo com a opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        //cadastro.upload();
                        Console.WriteLine("Programa finalizado");
                        break;
                    case 1:
                        Console.Write("Digite o ID do ambiente: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome: ");
                        string nome = Convert.ToString(Console.ReadLine());
                        cadastro.adicionarAmbiente(new Ambiente(id, nome));
                        break;
                    case 2:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (cadastro.pesquisarAmbiente(new Ambiente(id, "")) != null)
                        {
                            Console.WriteLine(cadastro.pesquisarAmbiente(new Ambiente(id, "")).ToString());
                        }
                        else
                        {
                            Console.WriteLine("Ambiente não encontrado");
                        }
                        break;
                    case 3:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cadastro.removerAmbiente(new Ambiente(id, "")) ? "Removido" : "Não removido");
                        break;
                    case 4:
                        Console.Write("Digite o id do usuário: ");
                        int idUsuario = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o nome do usuário: ");
                        nome = Convert.ToString(Console.ReadLine());
                        cadastro.adicionarUsuario(new Usuario(idUsuario, nome));
                        break;
                    case 5:
                        Console.Write("Digite o id do usuário: ");
                        idUsuario = Convert.ToInt32(Console.ReadLine());
                        if (cadastro.pesquisarUsuario(new Usuario(idUsuario, "")) != null)
                        {
                            Console.WriteLine(cadastro.pesquisarUsuario(new Usuario(idUsuario, "")).ToString());
                        }
                        else
                        {
                            Console.WriteLine("Usuário não encontrado");
                        }
                        break;
                    case 6:
                        Console.Write("Digite o id do usuário: ");
                        idUsuario = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cadastro.removerUsuario(new Usuario(idUsuario, "")) ? "Removido" : "Não removido");
                        break;
                    case 7:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do usuário: ");
                        idUsuario = Convert.ToInt32(Console.ReadLine());
                        bool concedeu = cadastro.pesquisarUsuario(new Usuario(idUsuario, "")).concederPermissao(cadastro.pesquisarAmbiente(new Ambiente(id, "")));
                        Console.WriteLine(concedeu ? "Concedida" : "Não concedida");
                        break;
                    case 8:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o id do usuário: ");
                        idUsuario = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cadastro.pesquisarUsuario(new Usuario(idUsuario, "")).revogarPermissao(cadastro.pesquisarAmbiente(new Ambiente(id, ""))) ? "Revogada" : "Não revogada");
                        break;
                    case 9:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o ID do usuário: ");
                        idUsuario = Convert.ToInt32(Console.ReadLine());
                        Usuario usuario = cadastro.pesquisarUsuario(new Usuario(idUsuario, ""));
                        bool registrou = false;
                        foreach (Ambiente a in usuario.Ambientes)
                        {
                            if (a.Id == id)
                            {
                                if (usuario.concederPermissao(cadastro.pesquisarAmbiente(new Ambiente(id, ""))) == false)
                                {
                                    a.registrarLog(new Log(DateTime.Now, usuario, true));
                                }
                                else
                                {
                                    a.registrarLog(new Log(DateTime.Now, usuario, false));
                                }
                                registrou = true;
                            }
                        }
                        if (registrou == true)
                        {
                            Console.WriteLine("Acesso registrado");
                        }
                        else
                        {
                            Console.WriteLine("Acesso não registrado - usuário não tem permissão de acesso");
                        }
                        break;
                    case 10:
                        Console.Write("Digite o ID do ambiente: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Ambiente ambiente = cadastro.pesquisarAmbiente(new Ambiente(id, ""));
                        Console.WriteLine(ambiente.ToString() + "\nLogs:");
                        foreach (Log log in ambiente.Logs)
                        {
                            Console.WriteLine(log.ToString());
                        }
                        break;
                }
            } while (opcao > 0 && opcao <= 10);
            cadastro.upload();
        }
    }
}