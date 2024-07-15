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

    public abstract class BaseController
    {
        public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
    }


    //Pedir interação do usuário
    //Tem o retorno do Model feito na interação do usuário

    //SOLID - Fazer código limpo
    //S - SRP - Simple responsability principle - (responsabilidade única)

    //public abstract class EquipamentoControllerBase
    //{
    //    public abstract void AdicionarEquipamento(EquipamentoModel equipamento);
    //}

    public class EquipamentosController :
        BaseController,
        IAdicionarEquipamento,
        IAtualizarEquipamento
    {
       // public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
        }

        //Read
        public List<EquipamentoModel> ObterEquipamentos()
        {
            return _repositorioEquipamentos.ObterEquipamento();
        }

        public void MostrarViewFormEquipamento(EquipamentoModel model = null)
        {
            FormEquipamento formEquipamento = new FormEquipamento(this, this, model);
            formEquipamento.ShowDialog();
        }

        //C ou Registrar
        public  void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.AdicionarEquipamento(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if(string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.AtualizarEquipamento(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }
        public class AdicionarEquipamentoException : Exception
        {
            public AdicionarEquipamentoException(string message) : base(message)
            {

            }
        }
    }
}

