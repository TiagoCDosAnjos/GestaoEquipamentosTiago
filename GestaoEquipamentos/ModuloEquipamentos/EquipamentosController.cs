using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public class EquipamentosController
    {
        public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
        }

        public List<EquipamentoModel> ObterEquipamentos()
        {
            return _repositorioEquipamentos.ObterEquipamento();
        }

        public void AdicionarEquipamento()
        {
            FormEquipamento formEquipamento = new FormEquipamento();
            formEquipamento.ShowDialog();

            //Validar as regras de adição

            EquipamentoModel equipamento = formEquipamento.EquipamentoModel;


            _repositorioEquipamentos.AdicionarEquipamento(equipamento);
        }
    }
}
