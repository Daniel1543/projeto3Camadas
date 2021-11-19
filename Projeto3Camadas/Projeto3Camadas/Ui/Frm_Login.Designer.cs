namespace Projeto3Camadas.Ui
{
    partial class Frm_Login
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lnkLabEsqueceu = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picEntrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(362, 175);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(362, 110);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(365, 131);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(151, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '*';
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lnkLabEsqueceu
            // 
            this.lnkLabEsqueceu.AutoSize = true;
            this.lnkLabEsqueceu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLabEsqueceu.Location = new System.Drawing.Point(362, 270);
            this.lnkLabEsqueceu.Name = "lnkLabEsqueceu";
            this.lnkLabEsqueceu.Size = new System.Drawing.Size(154, 18);
            this.lnkLabEsqueceu.TabIndex = 5;
            this.lnkLabEsqueceu.TabStop = true;
            this.lnkLabEsqueceu.Text = "Esqueceu sua senha?";
            this.lnkLabEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabEsqueceu_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(365, 222);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(151, 30);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picEntrar
            // 
            this.picEntrar.Image = global::Projeto3Camadas.Properties.Resources.exitdoor_87195__2_;
            this.picEntrar.Location = new System.Drawing.Point(59, 85);
            this.picEntrar.Name = "picEntrar";
            this.picEntrar.Size = new System.Drawing.Size(245, 263);
            this.picEntrar.TabIndex = 4;
            this.picEntrar.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lnkLabEsqueceu);
            this.Controls.Add(this.picEntrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSenha);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            ((System.ComponentModel.ISupportInitialize)(this.picEntrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picEntrar;
        private System.Windows.Forms.LinkLabel lnkLabEsqueceu;
        private System.Windows.Forms.Button btnEntrar;
    }
}