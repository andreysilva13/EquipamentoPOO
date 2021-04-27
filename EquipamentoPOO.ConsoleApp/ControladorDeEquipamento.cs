using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentoPOO.ConsoleApp
{
    class ControladorDeEquipamento
    {
        Equipamento[] equipamentos = new Equipamento[100];
        int contador = 0;
        public void Cadastrar()
        {
            int id; string nome; double preco; string numero; DateTime data; string fabricante;
            Console.Clear();
            EntradaDeDadosEquip(out id, out nome, out preco, out numero, out data, out fabricante);
            Equipamento equipamento = new Equipamento(id, nome, preco, numero, data, fabricante);
            equipamentos[contador] = equipamento;
            contador++;
        }

        private static void EntradaDeDadosEquip(out int id, out string nome, out double preco, out string numero, out DateTime data, out string fabricante)
        {
            Console.Write("ID do produto: ");
            id = Convert.ToInt32(Console.ReadLine());
            nome = ValidaNome();
            Console.Write("Preço do produto: ");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero do produto: ");
            numero = Console.ReadLine();
            data = ValidaData();
            Console.Write("Nome do fabricante: ");
            fabricante = Console.ReadLine();
        }

        private static DateTime ValidaData()
        {
            DateTime data;
            bool dataInvalida = false;
            do
            {
                Console.Write("Digite a data de fabricação: ");
                data = Convert.ToDateTime(Console.ReadLine());
                if (data > DateTime.Now)
                {
                    dataInvalida = true;
                    Console.WriteLine("Data inválida, produto não pode ser do futuro");
                }
                else
                {
                    dataInvalida = false;
                }
            } while (dataInvalida);
            return data;
        }

        private static string ValidaNome()
        {
            string nome;
            bool nomeInvalido = false;
            do
            {
                Console.Write("Digite nome do produto: ");
                nome = Console.ReadLine();
                if (nome.Length < 6)
                {
                    nomeInvalido = true;
                    Console.WriteLine("Nome inválido, no minimo 6 caracteres");
                }
                else
                {
                    nomeInvalido = false;
                }
            } while (nomeInvalido);
            return nome;
        }

        public void Listar()
        {
            Lista();
        }

        private void Lista()
        {
            for (int i = 0; i < contador; i++)
            {
                if (equipamentos[i].IdsEquipamento != 0 )
                {
                    Console.WriteLine(equipamentos[i]);
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
            int id; string nome; double preco; string numero; DateTime data; string fabricante;
            Console.Write("Digite o ID do equipamento que deseja editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contador; i++)
            {
                if (idSelecionado == equipamentos[i].IdsEquipamento)
                {
                    EntradaDeDadosEditar(out nome, out preco, out numero, out data, out fabricante);

                    id = equipamentos[i].IdsEquipamento;
                    equipamentos[i].NomesEquipamento = nome;
                    equipamentos[i].PrecosEquipamento = preco;
                    equipamentos[i].NumerosSerieEquipamento = numero;
                    equipamentos[i].FabricantesEquipamento = fabricante;
                    equipamentos[i].DatasFabricacaoEquipamento = data;

                    Equipamento equipamento = new Equipamento(id, nome, preco, numero, data, fabricante);
                    equipamentos[i] = equipamento;
                }
                else
                {
                    Console.WriteLine("Chamado não encontrado");
                    Console.ReadLine();
                }

            }
        }

        private static void EntradaDeDadosEditar(out string nome, out double preco, out string numero, out DateTime data, out string fabricante)
        {
            nome = ValidaNome();
            Console.Write("Preço do produto: ");
            preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero do produto: ");
            numero = Console.ReadLine();
            Console.Write("Data de fabricação (00-00-0000): ");
            data = ValidaData();
            Console.Write("Nome do fabricante: ");
            fabricante = Console.ReadLine();
        }

        public void Excluir()
        {
            Console.Write("Digite o ID do equipamento que deseja excluir: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contador; i++)
            {
                if (idSelecionado == equipamentos[i].IdsEquipamento)
                {
                    equipamentos[i].IdsEquipamento = 0;
                    equipamentos[i].NomesEquipamento = null;
                    equipamentos[i].PrecosEquipamento = 0;
                    equipamentos[i].NumerosSerieEquipamento = null;
                    equipamentos[i].FabricantesEquipamento = null;
                    equipamentos[i].DatasFabricacaoEquipamento = DateTime.MinValue;
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


