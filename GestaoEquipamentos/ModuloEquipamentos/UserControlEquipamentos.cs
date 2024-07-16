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
    }
}
