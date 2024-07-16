using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEquipamentos.ModuloEquipamentos
{
    public partial class FormEquipamento : Form
    {
        private EquipamentoModel _equipamentoModel { get; set; }
        private IAdicionarEquipamento _adicionarEquipamento { get; set; }
        private IAtualizarEquipamento _atualizarEquipamento { get; set; }

        public FormEquipamento(
            IAdicionarEquipamento equipamentoControllerBase,
            IAtualizarEquipamento atualizarEquipamento,
            EquipamentoModel equipamentoModel)
        {
            InitializeComponent();
            if (equipamentoModel != null)
            {
                _equipamentoModel = equipamentoModel;

                txtFabricante.Text = _equipamentoModel.Fabricante;
                txtNome.Text = _equipamentoModel.Nome;
                txtNumero.Text = _equipamentoModel.Numero.ToString();
                txtNumeroDeSerie.Text = _equipamentoModel.NumeroSerie;
                txtPreco.Text = _equipamentoModel.Preco.ToString();
                dateTimePickerFabricacao.Value = _equipamentoModel.DataFabricacao;
                dateTimePickerUltimaManutencao.Value = _equipamentoModel.DataUltimaManutencao;
                btnAdicionar.Text = "Atualizar";
            }
            else
            {
                _equipamentoModel = new EquipamentoModel();
                btnAdicionar.Text = "Adicionar";
            }

            toolStripStatusLabelEquipamentos.Text = "";
            _adicionarEquipamento = equipamentoControllerBase;
            _atualizarEquipamento = atualizarEquipamento;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                _equipamentoModel.Fabricante = txtFabricante.Text;
                _equipamentoModel.Nome = txtNome.Text;
                _equipamentoModel.Numero = int.Parse(txtNumero.Text);
                _equipamentoModel.NumeroSerie = txtNumeroDeSerie.Text;
                _equipamentoModel.Preco = decimal.Parse(txtPreco.Text);
                _equipamentoModel.DataFabricacao = dateTimePickerFabricacao.Value;
                _equipamentoModel.DataUltimaManutencao = dateTimePickerUltimaManutencao.Value;

                if (_equipamentoModel.Indice == -1)
                {
                    _adicionarEquipamento.AdicionarEquipamento(_equipamentoModel);
                }
                else
                {
                    _atualizarEquipamento.AtualizarEquipamento(_equipamentoModel);
                }
                //se deu certo
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (AdicionarEquipamentoException ax)
            {
                ExibirMensagemErro(ax.Message);
            }
            catch
            {
                ExibirMensagemErro("Preencha todos os campos corretamente!");
            }
        }
        internal void ExibirMensagemErro(string resultado)
        {
            toolStripStatusLabelEquipamentos.Text = resultado;
            this.DialogResult = DialogResult.Abort;
        }
    }
}
