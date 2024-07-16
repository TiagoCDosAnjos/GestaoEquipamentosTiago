using GestaoEquipamentos.ModuloEquipamentos;

namespace GestaoEquipamentos
{
    public partial class FormTelaPrincipal : Form
    {
        //private BaseController baseControllerAtual;

        private EquipamentosController equipamentosController;

        public FormTelaPrincipal()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();
        }

        private void buttonEquipamentos_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
           // this.baseControllerAtual = this.equipamentosController;
            this.panelListControl.Controls.Add(equipamentosController.View);
        }
    }
}
