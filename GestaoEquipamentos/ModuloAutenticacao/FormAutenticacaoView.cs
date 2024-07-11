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
    public partial class FormAutenticacaoView : Form
    {
        AutenticadorController AutenticadorController { get; set; }
        public FormAutenticacaoView()
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (AutenticadorController.Autenticar(login, senha)) 
            {
                Hide();
                FormEquipamento equipamentosForm = new FormEquipamento();
                equipamentosForm.ShowDialog();
                Close();
            }
            else
            {
                toolStripStatusLabelInfo.Text = "Usuário ou senha invalidos!";
            }

           

        }
    }
}
