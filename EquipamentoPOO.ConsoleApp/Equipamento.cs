using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentoPOO.ConsoleApp
{
    class Equipamento
    {
        private int idsEquipamento;
        private string nomesEquipamento;
        private double precosEquipamento;
        private string numerosSerieEquipamento;
        private DateTime datasFabricacaoEquipamento;

        private string fabricantesEquipamento;

        
        public Equipamento(int id, string nomeEquipamento, double precoEquipamento, string numeroSerie, DateTime dataFab, string fabricante)
        {
            this.idsEquipamento = id;
            this.nomesEquipamento = nomeEquipamento;
            this.precosEquipamento = precoEquipamento;
            this.numerosSerieEquipamento = numeroSerie;
            this.datasFabricacaoEquipamento = dataFab;
            this.fabricantesEquipamento = fabricante;
        }

        public int IdsEquipamento { get => idsEquipamento; set => idsEquipamento = value; }
        public string NomesEquipamento { get => nomesEquipamento; set => nomesEquipamento = value; }
        public double PrecosEquipamento { get => precosEquipamento; set => precosEquipamento = value; }
        public string NumerosSerieEquipamento { get => numerosSerieEquipamento; set => numerosSerieEquipamento = value; }
        public DateTime DatasFabricacaoEquipamento { get => datasFabricacaoEquipamento; set => datasFabricacaoEquipamento = value; }
        public string FabricantesEquipamento { get => fabricantesEquipamento; set => fabricantesEquipamento = value; }

        public override string ToString()
        {
            return $"ID: {idsEquipamento}\nNome equipamento: {nomesEquipamento}\nPreço: {precosEquipamento}\nNúmero de série: {numerosSerieEquipamento}" +
                $"\nData de fabricação: {datasFabricacaoEquipamento}\nFabricante: {fabricantesEquipamento}";
        }
    }

}

