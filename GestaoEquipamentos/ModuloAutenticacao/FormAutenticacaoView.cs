using GestaoEquipamentos.ModuloEquipamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEquipamentos.ModuloAutenticacao
{
    //VIEW
    public partial class FormAutenticacaoView : Form
    {
        //Controller
        AutenticadorController AutenticadorController { get; set; }
        public FormAutenticacaoView()
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();

            // dataGridView1.DataSource = AutenticadorController.ObterUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            try
            {
                if (AutenticadorController.Autenticar(login, senha))
                {
                    Hide();
                    FormTelaPrincipal equipamentosForm = new FormTelaPrincipal();
                    equipamentosForm.ShowDialog();
                    Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelInfo.Text = ex.Message;
            }
        }
    }
}
