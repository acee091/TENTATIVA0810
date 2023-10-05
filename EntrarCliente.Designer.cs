﻿namespace BarbeariaPatrick
{
    partial class EntrarCliente
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
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtLogonSenha = new System.Windows.Forms.TextBox();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.btnVoltarADM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.BackColor = System.Drawing.Color.Black;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.ForeColor = System.Drawing.Color.White;
            this.lblSenhaLogin.Location = new System.Drawing.Point(326, 189);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(55, 16);
            this.lblSenhaLogin.TabIndex = 9;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Black;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(326, 110);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 16);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Black;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(329, 129);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(145, 29);
            this.txtLogin.TabIndex = 7;
            // 
            // txtLogonSenha
            // 
            this.txtLogonSenha.BackColor = System.Drawing.Color.Black;
            this.txtLogonSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogonSenha.ForeColor = System.Drawing.Color.White;
            this.txtLogonSenha.Location = new System.Drawing.Point(329, 208);
            this.txtLogonSenha.Name = "txtLogonSenha";
            this.txtLogonSenha.PasswordChar = '*';
            this.txtLogonSenha.Size = new System.Drawing.Size(145, 29);
            this.txtLogonSenha.TabIndex = 6;
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.ForeColor = System.Drawing.Color.White;
            this.btnEntrarLogin.Location = new System.Drawing.Point(329, 274);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(145, 67);
            this.btnEntrarLogin.TabIndex = 5;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = false;
            // 
            // btnVoltarADM
            // 
            this.btnVoltarADM.BackColor = System.Drawing.Color.White;
            this.btnVoltarADM.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarADM.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarADM.Name = "btnVoltarADM";
            this.btnVoltarADM.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarADM.TabIndex = 17;
            this.btnVoltarADM.Text = "Voltar";
            this.btnVoltarADM.UseVisualStyleBackColor = false;
            // 
            // EntrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarADM);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtLogonSenha);
            this.Controls.Add(this.btnEntrarLogin);
            this.Name = "EntrarCliente";
            this.Text = "EntrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtLogonSenha;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Button btnVoltarADM;
    }
}