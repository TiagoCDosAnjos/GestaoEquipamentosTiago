﻿namespace GestaoEquipamentos
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            equipamentosToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonEquipamentos = new Button();
            panelListControl = new Panel();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4444447F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.55556F));
            tableLayoutPanel1.Size = new Size(1057, 505);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1057, 52);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { equipamentosToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 48);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // equipamentosToolStripMenuItem
            // 
            equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            equipamentosToolStripMenuItem.Size = new Size(150, 22);
            equipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 55);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelListControl);
            splitContainer1.Size = new Size(1051, 447);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonEquipamentos);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(135, 61);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonEquipamentos
            // 
            buttonEquipamentos.Image = (Image)resources.GetObject("buttonEquipamentos.Image");
            buttonEquipamentos.Location = new Point(3, 3);
            buttonEquipamentos.Name = "buttonEquipamentos";
            buttonEquipamentos.Size = new Size(89, 49);
            buttonEquipamentos.TabIndex = 0;
            buttonEquipamentos.UseVisualStyleBackColor = true;
            buttonEquipamentos.Click += buttonEquipamentos_Click;
            // 
            // panelListControl
            // 
            panelListControl.Dock = DockStyle.Fill;
            panelListControl.Location = new Point(0, 0);
            panelListControl.Name = "panelListControl";
            panelListControl.Size = new Size(861, 447);
            panelListControl.TabIndex = 0;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 505);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            Name = "FormTelaPrincipal";
            Text = "FormTelaPrincipal";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem equipamentosToolStripMenuItem;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonEquipamentos;
        private Panel panelListControl;
    }
}