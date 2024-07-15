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
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController _equipamentosController { get; set; }
        public TelaPrincipalForm()
        {
            InitializeComponent();
            _equipamentosController = new EquipamentosController();

            //this.dataGridViewEquipamentos.DataSource = _equipamentosController.ObterEquipamentos();
            AtualizarGrid();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _equipamentosController.MostrarViewFormEquipamento();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            this.dataGridViewEquipamentos.DataSource = null;
            this.dataGridViewEquipamentos.DataSource = _equipamentosController.ObterEquipamentos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var equipamentoSelecionado = dataGridViewEquipamentos.SelectedRows[0].DataBoundItem as EquipamentoModel;
            //EquipamentoModel equipamentoModel = (EquipamentoModel)equipamentoSelecionado;

            _equipamentosController.MostrarViewFormEquipamento(equipamentoSelecionado);
        }
    }
}
