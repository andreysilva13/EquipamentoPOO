using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipamentoPOO.ConsoleApp
{
    class Chamados
    {
        private string titulosChamado;
        private string descricoesChamado;
        private int idsEquipamentoChamado;
        private int idChamado;
        private DateTime datasAberturaChamado;
        private string diasDif;

        public Chamados(int idC, int id, string titulo, string descricao, DateTime dataAbertura)
        {
            this.idChamado = idC;
            this.titulosChamado = titulo;
            this.descricoesChamado = descricao;
            this.idsEquipamentoChamado = id;
            this.datasAberturaChamado = dataAbertura;
        }

        public string TitulosChamado { get => titulosChamado; set => titulosChamado = value; }
        public string DescricoesChamado { get => descricoesChamado; set => descricoesChamado = value; }
        public int IdsEquipamentoChamado { get => idsEquipamentoChamado; set => idsEquipamentoChamado = value; }
        public int IdChamado { get => idChamado; set => idChamado = value; }
        public DateTime DatasAberturaChamado { get => datasAberturaChamado; set => datasAberturaChamado = value; }
        public string DiasDif { get => diasDif; set => diasDif = value; }

        public override string ToString()
        {
            return $"ID Chamado: {idChamado}\nID Equipamento: {idsEquipamentoChamado}\nTitulo chamado: {titulosChamado}\nDescrição: {descricoesChamado}" +
                $"\nData de abertura: {datasAberturaChamado}";
        }
    }
}
