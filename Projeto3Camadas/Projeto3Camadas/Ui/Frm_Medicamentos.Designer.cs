namespace Projeto3Camadas.Ui
{
    partial class Frm_Medicamentos
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblmedicamento = new System.Windows.Forms.Label();
            this.lblcomposicao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMedicamentos = new System.Windows.Forms.TextBox();
            this.txtComposicao = new System.Windows.Forms.TextBox();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(70, 153);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 25);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(274, 153);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(182, 25);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(488, 153);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(178, 25);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(68, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 14);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID";
            // 
            // lblmedicamento
            // 
            this.lblmedicamento.AutoSize = true;
            this.lblmedicamento.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedicamento.Location = new System.Drawing.Point(178, 64);
            this.lblmedicamento.Name = "lblmedicamento";
            this.lblmedicamento.Size = new System.Drawing.Size(92, 14);
            this.lblmedicamento.TabIndex = 4;
            this.lblmedicamento.Text = "MEDICAMENTO";
            // 
            // lblcomposicao
            // 
            this.lblcomposicao.AutoSize = true;
            this.lblcomposicao.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomposicao.Location = new System.Drawing.Point(428, 64);
            this.lblcomposicao.Name = "lblcomposicao";
            this.lblcomposicao.Size = new System.Drawing.Size(84, 14);
            this.lblcomposicao.TabIndex = 5;
            this.lblcomposicao.Text = "COMPOSIÇÃO";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(70, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(74, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtMedicamentos
            // 
            this.txtMedicamentos.Location = new System.Drawing.Point(181, 81);
            this.txtMedicamentos.Name = "txtMedicamentos";
            this.txtMedicamentos.Size = new System.Drawing.Size(233, 20);
            this.txtMedicamentos.TabIndex = 7;
            // 
            // txtComposicao
            // 
            this.txtComposicao.Location = new System.Drawing.Point(431, 81);
            this.txtComposicao.Name = "txtComposicao";
            this.txtComposicao.Size = new System.Drawing.Size(235, 20);
            this.txtComposicao.TabIndex = 8;
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(71, 201);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(595, 237);
            this.dgvMedicamentos.TabIndex = 9;
            this.dgvMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellContentClick);
            // 
            // Frm_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvMedicamentos);
            this.Controls.Add(this.txtComposicao);
            this.Controls.Add(this.txtMedicamentos);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblcomposicao);
            this.Controls.Add(this.lblmedicamento);
            this.Controls.Add(this.lblId);
            this.Name = "Frm_Medicamentos";
            this.Text = "Frm_Medicamentos";
            this.Load += new System.EventHandler(this.Frm_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblmedicamento;
        private System.Windows.Forms.Label lblcomposicao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMedicamentos;
        private System.Windows.Forms.TextBox txtComposicao;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
    }
}