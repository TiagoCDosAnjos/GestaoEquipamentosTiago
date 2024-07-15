namespace GestaoEquipamentos.ModuloEquipamentos
{
    partial class FormEquipamento
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumero = new TextBox();
            txtNumeroDeSerie = new TextBox();
            txtFabricante = new TextBox();
            label7 = new Label();
            txtNome = new TextBox();
            dateTimePickerFabricacao = new DateTimePicker();
            dateTimePickerUltimaManutencao = new DateTimePicker();
            txtPreco = new TextBox();
            btnAdicionar = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelEquipamentos = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Data fabricação";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 2;
            label3.Text = "Data Ultima Manutenção";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Fabricante";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 187);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Número de série";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 225);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Preço";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.Moccasin;
            txtNumero.Location = new Point(157, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(221, 23);
            txtNumero.TabIndex = 6;
            // 
            // txtNumeroDeSerie
            // 
            txtNumeroDeSerie.BackColor = Color.Moccasin;
            txtNumeroDeSerie.Location = new Point(157, 179);
            txtNumeroDeSerie.Name = "txtNumeroDeSerie";
            txtNumeroDeSerie.Size = new Size(221, 23);
            txtNumeroDeSerie.TabIndex = 7;
            // 
            // txtFabricante
            // 
            txtFabricante.BackColor = Color.Moccasin;
            txtFabricante.Location = new Point(157, 142);
            txtFabricante.Name = "txtFabricante";
            txtFabricante.Size = new Size(221, 23);
            txtFabricante.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 48);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 9;
            label7.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Moccasin;
            txtNome.Location = new Point(157, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 23);
            txtNome.TabIndex = 10;
            // 
            // dateTimePickerFabricacao
            // 
            dateTimePickerFabricacao.Location = new Point(157, 78);
            dateTimePickerFabricacao.Name = "dateTimePickerFabricacao";
            dateTimePickerFabricacao.Size = new Size(249, 23);
            dateTimePickerFabricacao.TabIndex = 11;
            // 
            // dateTimePickerUltimaManutencao
            // 
            dateTimePickerUltimaManutencao.Location = new Point(157, 112);
            dateTimePickerUltimaManutencao.Name = "dateTimePickerUltimaManutencao";
            dateTimePickerUltimaManutencao.Size = new Size(249, 23);
            dateTimePickerUltimaManutencao.TabIndex = 12;
            // 
            // txtPreco
            // 
            txtPreco.BackColor = Color.Moccasin;
            txtPreco.Location = new Point(157, 217);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(221, 23);
            txtPreco.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(303, 258);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelEquipamentos });
            statusStrip1.Location = new Point(0, 284);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(415, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelEquipamentos
            // 
            toolStripStatusLabelEquipamentos.Name = "toolStripStatusLabelEquipamentos";
            toolStripStatusLabelEquipamentos.Size = new Size(0, 17);
            // 
            // FormEquipamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 306);
            Controls.Add(statusStrip1);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPreco);
            Controls.Add(dateTimePickerUltimaManutencao);
            Controls.Add(dateTimePickerFabricacao);
            Controls.Add(txtNome);
            Controls.Add(label7);
            Controls.Add(txtFabricante);
            Controls.Add(txtNumeroDeSerie);
            Controls.Add(txtNumero);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEquipamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Equipamentos";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumero;
        private TextBox txtNumeroDeSerie;
        private TextBox txtFabricante;
        private Label label7;
        private TextBox txtNome;
        private DateTimePicker dateTimePickerFabricacao;
        private DateTimePicker dateTimePickerUltimaManutencao;
        private TextBox txtPreco;
        private Button btnAdicionar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelEquipamentos;
    }
}