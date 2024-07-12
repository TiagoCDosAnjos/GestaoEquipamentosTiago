namespace GestaoEquipamentos.ModuloAutenticacao
{
    partial class FormAutenticacaoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAutenticacaoView));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelInfo = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            btnLogin = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo });
            statusStrip1.Location = new Point(0, 281);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(543, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo
            // 
            toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            toolStripStatusLabelInfo.Size = new Size(0, 17);
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.logo_titulo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 35);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(186, 65);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(245, 31);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(252, 23);
            txtLogin.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(245, 63);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(252, 23);
            txtSenha.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(390, 101);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 30);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 160);
            panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(87, 69);
            dataGridView1.TabIndex = 7;
            dataGridView1.Visible = false;
            // 
            // FormAutenticacaoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(543, 303);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAutenticacaoView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Equipamentos - Autenticação";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelInfo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button btnLogin;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}