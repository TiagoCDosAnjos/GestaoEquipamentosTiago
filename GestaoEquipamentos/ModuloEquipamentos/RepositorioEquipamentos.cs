using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public class RepositorioEquipamentos
    {
        private List<EquipamentoModel> _equipamentos { get; set; } = new List<EquipamentoModel>();

        public RepositorioEquipamentos()
        {
            Semear();
        }

        private void Semear()
        {
            _equipamentos.Add(
                new EquipamentoModel()
                {
                    DataFabricacao = new DateTime(2020, 12, 09),
                    DataUltimaManutencao = new DateTime(2020, 12, 09),
                    Fabricante = "HP",
                    Nome = "LaserJet J666",
                    Numero = 1,
                    NumeroSerie = "12345678",
                    Preco = 1000,
                    Indice = Indice()
                });

            _equipamentos.Add(new EquipamentoModel()
            {
                DataFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "Samsung",
                Nome = "S21",
                Numero = 2,
                NumeroSerie = "87654321",
                Preco = 5000,
                Indice = Indice()
            });

            _equipamentos.Add(new EquipamentoModel()
            {
                DataFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "LEX",
                Nome = "SSS",
                Numero = 2,
                NumeroSerie = "9999999999",
                Preco = 5000,
                Indice = Indice()
            });
        }

        private int Indice()
        {
            return _equipamentos.Count;
        }

        public List<EquipamentoModel> ObterEquipamento()
        {
            return _equipamentos;
        }

        public void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            equipamento.Indice = Indice();
            _equipamentos.Add(equipamento);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            _equipamentos[equipamento.Indice] = equipamento;
        }

        public void ExcluirEquipamento(EquipamentoModel equipamento)
        {
            _equipamentos.Remove(equipamento);

        }
    }
}
