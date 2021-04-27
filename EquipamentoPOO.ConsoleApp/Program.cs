using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentoPOO.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorDeEquipamento controladorE = new ControladorDeEquipamento();
            ControladorDeChamados controladorC = new ControladorDeChamados();

            while (true)
            {
                string opcao = ObterOpcao();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    break;

                if (opcao == "1")
                {
                    string opcaoCadastroEquipamentos = ObterOpcaoCadastroEquipamentos();

                    if (opcaoCadastroEquipamentos.Equals("s", StringComparison.OrdinalIgnoreCase))
                        break;

                    if (opcaoCadastroEquipamentos == "1")
                    {
                        controladorE.Cadastrar();
                    }

                    else if (opcaoCadastroEquipamentos == "2")
                    {
                        Console.Clear();
                        controladorE.Listar();
                        Console.ReadLine();
                    }
                    else if (opcaoCadastroEquipamentos == "3")
                    {
                        controladorE.Listar();
                        controladorE.Editar();
                    }


                    else if (opcaoCadastroEquipamentos == "4")
                    {
                        controladorE.Listar();
                        controladorE.Excluir();
                    }
                    
                }
                else if (opcao == "2")
                {
                    string opcaoControleChamados = ObterOpcaoControleChamados();

                    if (opcaoControleChamados.Equals("s", StringComparison.OrdinalIgnoreCase))
                        break;

                    if (opcaoControleChamados == "1")
                    {
                        controladorE.Listar();
                        controladorC.Cadastrar();
                    }
                    else if (opcaoControleChamados == "2")
                    {
                        Console.Clear();
                        controladorC.Listar();
                        Console.ReadLine();
                    }

                    else if (opcaoControleChamados == "3")
                    {
                        controladorE.Listar();
                        controladorC.Listar();
                        controladorC.Editar();
                    }

                    else if (opcaoControleChamados == "4")
                    {
                        controladorC.Listar();
                        controladorC.Excluir();
                    }

                }
            }
        }
        private static string ObterOpcao()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para o Cadastro de Equipamentos");
            Console.WriteLine("Digite 2 para o Controle de Chamados");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }

        private static string ObterOpcaoCadastroEquipamentos()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para inserir novo equipamento");
            Console.WriteLine("Digite 2 para visualizar equipamentos");
            Console.WriteLine("Digite 3 para editar um equipamento");
            Console.WriteLine("Digite 4 para excluir um equipamento");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private static string ObterOpcaoControleChamados()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para inserir novo chamado");
            Console.WriteLine("Digite 2 para visualizar chamados");
            Console.WriteLine("Digite 3 para editar um chamado");
            Console.WriteLine("Digite 4 para excluir um chamado");

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}


