using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentoPOO.ConsoleApp
{
    class ControladorDeChamados
    {
        Chamados[] chamados = new Chamados[100];
        int contador = 0;

        public void Cadastrar()
        {
            int idC; string titulo; int id; string descricao; DateTime data;

            Console.Clear();
            EntradaDeDadosChamado(out idC, out titulo, out id, out descricao, out data);

            Chamados chamado = new Chamados(idC, id, titulo, descricao, data);
            chamados[contador] = chamado;
            contador++;
        }

        private static void EntradaDeDadosChamado(out int idC, out string titulo, out int id, out string descricao, out DateTime data)
        {
            Console.Write("ID do chamado: ");
            idC = Convert.ToInt32(Console.ReadLine());
            Console.Write("ID do equipamento: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Titulo do chamado: ");
            titulo = Console.ReadLine();
            Console.Write("Descrição do produto: ");
            descricao = Console.ReadLine();
            data = DateTime.Now;
        }

        public void Listar()
        {
            Lista();
        }

        private void Lista()
        {
            for (int i = 0; i < contador; i++)
            {
                if (chamados[i].IdChamado != 0)
                {
                    Console.WriteLine(chamados[i]);
                    Console.WriteLine("-------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Nenhum produto encontrado!");
                }
            }
        }

        public void Editar()
        {
            int idC; string titulo; int id; string descricao; DateTime data;
            Console.Write("Digite o ID do chamado que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contador; i++)
            {
                if (idSelecionado == chamados[i].IdChamado)
                {
                    EntradaDeDadosEditar(out titulo, out id, out descricao);

                    data = chamados[i].DatasAberturaChamado;
                    idC = chamados[i].IdChamado;
                    chamados[i].TitulosChamado = titulo;
                    chamados[i].DescricoesChamado = descricao;
                    chamados[i].IdsEquipamentoChamado = id;
                    chamados[i].DatasAberturaChamado = data;

                    Chamados chamado = new Chamados(idC, id, titulo, descricao, data);
                    chamados[i] = chamado;
                }
                else
                {
                    Console.WriteLine("Chamado não encontrado");
                    Console.ReadLine();
                }
            }
        }

        private static void EntradaDeDadosEditar(out string titulo, out int id, out string descricao)
        {
            Console.Write("ID do equipamento: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Titulo do chamado: ");
            titulo = Console.ReadLine();
            Console.Write("Descrição do produto: ");
            descricao = Console.ReadLine();
        }

        public void Excluir()
        {
            Console.Write("Digite o ID do chamado que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                if (idSelecionado == chamados[i].IdChamado)
                {
                    chamados[i].IdChamado = 0;
                    chamados[i].TitulosChamado = null;
                    chamados[i].IdsEquipamentoChamado = 0;
                    chamados[i].DescricoesChamado = null;
                    chamados[i].DatasAberturaChamado = DateTime.MinValue;
                }
                else
                {
                    Console.WriteLine("Equipamento não encontrado");
                    Console.ReadLine();
                }
            }
        }
    }
}

