using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace GestaoEquipamentos.ModuloEquipamentos
{
    public partial class UserControlEquipamentos : UserControl
    {
        private EquipamentosController equipamentosController;
        public UserControlEquipamentos(EquipamentosController equipamentosController)
        {
            InitializeComponent();
            this.equipamentosController = equipamentosController;
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            this.dataGridViewEquipamentos.DataSource = null;
            this.dataGridViewEquipamentos.DataSource = equipamentosController.ObterEquipamentos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipamentosController.MostrarViewFormEquipamento();
            AtualizarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipamentos.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormEquipamento(equipamentoModel);
                AtualizarGrid();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewEquipamentos.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormDeleteEquipamento(equipamentoModel);
                AtualizarGrid();
            }
        }
    }
}
