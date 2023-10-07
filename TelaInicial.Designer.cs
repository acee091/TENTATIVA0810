﻿namespace BarbeariaPatrick
{
    partial class TelaInicial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnEntrarCliente = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(220, 346);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(227, 84);
            this.btnCadastrarCliente.TabIndex = 2;
            this.btnCadastrarCliente.Text = "Cadastrar-se";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnEntrarCliente
            // 
            this.btnEntrarCliente.BackColor = System.Drawing.Color.White;
            this.btnEntrarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarCliente.Location = new System.Drawing.Point(603, 340);
            this.btnEntrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntrarCliente.Name = "btnEntrarCliente";
            this.btnEntrarCliente.Size = new System.Drawing.Size(245, 90);
            this.btnEntrarCliente.TabIndex = 3;
            this.btnEntrarCliente.Text = "Entrar";
            this.btnEntrarCliente.UseVisualStyleBackColor = false;
            this.btnEntrarCliente.Click += new System.EventHandler(this.btnConsultarAgendamento_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Uighur", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCliente.Location = new System.Drawing.Point(203, 96);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(620, 190);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "SEJA BEM-VINDO À\r\nBARBEARIA ESTRELA";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnEntrarCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnEntrarCliente;
        private System.Windows.Forms.Label lblCliente;
    }
}