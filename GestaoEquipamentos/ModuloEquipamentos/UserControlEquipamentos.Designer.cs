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
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEquipamentos
            // 
            dataGridViewEquipamentos.AllowUserToAddRows = false;
            dataGridViewEquipamentos.AllowUserToDeleteRows = false;
            dataGridViewEquipamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEquipamentos.Dock = DockStyle.Fill;
            dataGridViewEquipamentos.Location = new Point(0, 0);
            dataGridViewEquipamentos.MultiSelect = false;
            dataGridViewEquipamentos.Name = "dataGridViewEquipamentos";
            dataGridViewEquipamentos.ReadOnly = true;
            dataGridViewEquipamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEquipamentos.Size = new Size(528, 310);
            dataGridViewEquipamentos.TabIndex = 2;
            // 
            // UserControlEquipamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewEquipamentos);
            Name = "UserControlEquipamentos";
            Size = new Size(528, 310);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEquipamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewEquipamentos;
    }
}
