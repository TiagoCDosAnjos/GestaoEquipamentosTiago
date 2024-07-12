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
       public EquipamentoModel EquipamentoModel { get; set; }
        public FormEquipamento()
        {
            InitializeComponent();
            EquipamentoModel = new EquipamentoModel();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            EquipamentoModel.Fabricante = txtFabricante.Text;
            EquipamentoModel.Nome = txtNome.Text;
            EquipamentoModel.Numero = int.Parse(txtNumero.Text);
            EquipamentoModel.NumeroSerie = txtNumeroDeSerie.Text;
            EquipamentoModel.Preco = decimal.Parse(txtPreco.Text);
            EquipamentoModel.DataFabricacao = dateTimePickerFabricacao.Value;
            EquipamentoModel.DataUltimaManutencao = dateTimePickerUltimaManutencao.Value;

            string resultado = EquipamentoModel.Validar();

            if(resultado.Length > 0)
            {
                toolStripStatusLabelEquipamentos.Text = resultado;
                return;
            }

            this.Close();

        }
    }
}
