using GestaoEquipamentos.ModuloCompartilhado;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public interface IAdicionarEquipamento
    {
        public abstract void AdicionarEquipamento(EquipamentoModel equipamento);
    }

    public interface IAtualizarEquipamento
    {
        void AtualizarEquipamento(EquipamentoModel equipamento);
    }

    //Pedir interação do usuário
    //Tem o retorno do Model feito na interação do usuário

    //SOLID - Fazer código limpo
    //S - SRP - Simple responsability principle - (responsabilidade única)

    public class EquipamentosController :
        BaseController,
        IAdicionarEquipamento,
        IAtualizarEquipamento
    {
        private RepositorioEquipamentos _repositorioEquipamentos { get; set; }

        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
            View = new UserControlEquipamentos(this);
        }

        //Read
        public List<EquipamentoModel> ObterEquipamentos()
        {
            return _repositorioEquipamentos.ObterTodos();
        }

        public void MostrarViewFormEquipamento(EquipamentoModel model = null)
        {
            FormEquipamento formEquipamento = new FormEquipamento(this, this, model);
            formEquipamento.ShowDialog();
        }

        //C ou Registrar
        public void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.Adicionar(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.AtualizarEquipamento(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void MostrarViewFormDeleteEquipamento(EquipamentoModel equipamentoModel)
        {
            var resultado =
                MessageBox.
                Show("Remover Equipamento",
                $"Você confirma a remoção do equipamento {equipamentoModel} ? ",
                MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _repositorioEquipamentos.Excluir(equipamentoModel);

            }
        }

        public class AdicionarEquipamentoException : Exception
        {
            public AdicionarEquipamentoException(string message) : base(message)
            {

            }
        }
    }
}

