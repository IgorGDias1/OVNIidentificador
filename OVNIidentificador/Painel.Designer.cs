namespace OVNIidentificador
{
    partial class Painel
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
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnAddTripulante = new System.Windows.Forms.Button();
            this.btnRemoverTripulante = new System.Windows.Forms.Button();
            this.btnAbduzir = new System.Windows.Forms.Button();
            this.btnDesabduzir = new System.Windows.Forms.Button();
            this.btnRetornarOrigem = new System.Windows.Forms.Button();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.lblPlaneta);
            this.grbDados.Controls.Add(this.lblTripulantes);
            this.grbDados.Controls.Add(this.lblAbduzidos);
            this.grbDados.Controls.Add(this.lblSituacao);
            this.grbDados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(12, 22);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(300, 198);
            this.grbDados.TabIndex = 0;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(11, 122);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(98, 21);
            this.lblTripulantes.TabIndex = 2;
            this.lblTripulantes.Text = "Tripulantes:";
            this.lblTripulantes.Click += new System.EventHandler(this.lblTripulantes_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(11, 83);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(94, 21);
            this.lblAbduzidos.TabIndex = 1;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(11, 45);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(79, 21);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(12, 244);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(300, 46);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(12, 309);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(300, 46);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnAddTripulante
            // 
            this.btnAddTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTripulante.Location = new System.Drawing.Point(318, 36);
            this.btnAddTripulante.Name = "btnAddTripulante";
            this.btnAddTripulante.Size = new System.Drawing.Size(300, 46);
            this.btnAddTripulante.TabIndex = 3;
            this.btnAddTripulante.Text = "Adicionar Tripulante";
            this.btnAddTripulante.UseVisualStyleBackColor = true;
            this.btnAddTripulante.Click += new System.EventHandler(this.btnAddTripulante_Click);
            // 
            // btnRemoverTripulante
            // 
            this.btnRemoverTripulante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTripulante.Location = new System.Drawing.Point(318, 88);
            this.btnRemoverTripulante.Name = "btnRemoverTripulante";
            this.btnRemoverTripulante.Size = new System.Drawing.Size(300, 46);
            this.btnRemoverTripulante.TabIndex = 4;
            this.btnRemoverTripulante.Text = "Remover Tripulante";
            this.btnRemoverTripulante.UseVisualStyleBackColor = true;
            // 
            // btnAbduzir
            // 
            this.btnAbduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbduzir.Location = new System.Drawing.Point(318, 140);
            this.btnAbduzir.Name = "btnAbduzir";
            this.btnAbduzir.Size = new System.Drawing.Size(300, 46);
            this.btnAbduzir.TabIndex = 5;
            this.btnAbduzir.Text = "Abduzir";
            this.btnAbduzir.UseVisualStyleBackColor = true;
            // 
            // btnDesabduzir
            // 
            this.btnDesabduzir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesabduzir.Location = new System.Drawing.Point(318, 192);
            this.btnDesabduzir.Name = "btnDesabduzir";
            this.btnDesabduzir.Size = new System.Drawing.Size(300, 46);
            this.btnDesabduzir.TabIndex = 6;
            this.btnDesabduzir.Text = "Desabduzir";
            this.btnDesabduzir.UseVisualStyleBackColor = true;
            // 
            // btnRetornarOrigem
            // 
            this.btnRetornarOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarOrigem.Location = new System.Drawing.Point(318, 244);
            this.btnRetornarOrigem.Name = "btnRetornarOrigem";
            this.btnRetornarOrigem.Size = new System.Drawing.Size(300, 46);
            this.btnRetornarOrigem.TabIndex = 7;
            this.btnRetornarOrigem.Text = "Retornar a Origem";
            this.btnRetornarOrigem.UseVisualStyleBackColor = true;
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(11, 157);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(71, 21);
            this.lblPlaneta.TabIndex = 3;
            this.lblPlaneta.Text = "Planeta:";
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(318, 314);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(176, 41);
            this.cmbPlanetas.TabIndex = 8;
            // 
            // btnMudar
            // 
            this.btnMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudar.Location = new System.Drawing.Point(500, 314);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(118, 41);
            this.btnMudar.TabIndex = 9;
            this.btnMudar.Text = "Mudar";
            this.btnMudar.UseVisualStyleBackColor = true;
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 375);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.btnRetornarOrigem);
            this.Controls.Add(this.btnDesabduzir);
            this.Controls.Add(this.btnAbduzir);
            this.Controls.Add(this.btnRemoverTripulante);
            this.Controls.Add(this.btnAddTripulante);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.grbDados);
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            this.Load += new System.EventHandler(this.Painel_Load);
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnAddTripulante;
        private System.Windows.Forms.Button btnRemoverTripulante;
        private System.Windows.Forms.Button btnAbduzir;
        private System.Windows.Forms.Button btnDesabduzir;
        private System.Windows.Forms.Button btnRetornarOrigem;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnMudar;
    }
}