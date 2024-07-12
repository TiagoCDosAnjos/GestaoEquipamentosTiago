using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public class RepositorioEquipamentos
    {
        private List<EquipamentoModel> _equipamentos { get; set; }

        public RepositorioEquipamentos()
        {
            _equipamentos = new List<EquipamentoModel>();
            Semear();    
        }

        private void Semear()
        {
            _equipamentos.Add(new EquipamentoModel()
            {
                DataFabricacao = new DateTime(2020, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "HP",
                Nome = "LaserJet J666",
                Numero = 1,
                NumeroSerie = "12345678",
                Preco = 1000,
            }) ;

            _equipamentos.Add(new EquipamentoModel()
            {
                DataFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "Samsung",
                Nome = "S21",
                Numero = 2,
                NumeroSerie = "87654321",
                Preco = 5000,
            });
        }

        public List<EquipamentoModel> ObterEquipamento() 
        {
            return _equipamentos;
        }

        internal void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            _equipamentos.Add(equipamento);
        }
    }

}
