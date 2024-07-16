namespace GestaoEquipamentos.ModuloEquipamentos
{
    partial class UserControlEquipamentos
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewEquipamentos = new DataGridView();
            menuStripEquipamentos = new MenuStrip();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).BeginInit();
            menuStripEquipamentos.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewEquipamentos
            // 
            dataGridViewEquipamentos.AllowUserToAddRows = false;
            dataGridViewEquipamentos.AllowUserToDeleteRows = false;
            dataGridViewEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipamentos.Dock = DockStyle.Fill;
            dataGridViewEquipamentos.Location = new Point(0, 24);
            dataGridViewEquipamentos.MultiSelect = false;
            dataGridViewEquipamentos.Name = "dataGridViewEquipamentos";
            dataGridViewEquipamentos.ReadOnly = true;
            dataGridViewEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipamentos.Size = new Size(688, 365);
            dataGridViewEquipamentos.TabIndex = 2;
            // 
            // menuStripEquipamentos
            // 
            menuStripEquipamentos.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, editarToolStripMenuItem, removerToolStripMenuItem });
            menuStripEquipamentos.Location = new Point(0, 0);
            menuStripEquipamentos.Name = "menuStripEquipamentos";
            menuStripEquipamentos.Size = new Size(688, 24);
            menuStripEquipamentos.TabIndex = 3;
            menuStripEquipamentos.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(70, 20);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(66, 20);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // UserControlEquipamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewEquipamentos);
            Controls.Add(menuStripEquipamentos);
            Name = "UserControlEquipamentos";
            Size = new Size(688, 389);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).EndInit();
            menuStripEquipamentos.ResumeLayout(false);
            menuStripEquipamentos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEquipamentos;
        private MenuStrip menuStripEquipamentos;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
    }
}
