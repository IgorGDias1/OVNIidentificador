namespace OVNIidentificador
{
    partial class Inicializador
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMaxAbdu = new System.Windows.Forms.Label();
            this.lblMaxTripu = new System.Windows.Forms.Label();
            this.lblPlanetaOrig = new System.Windows.Forms.Label();
            this.nudAbduzidos = new System.Windows.Forms.NumericUpDown();
            this.nudTripulantes = new System.Windows.Forms.NumericUpDown();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnInciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(80, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(365, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerenciador de OVNI 2000";
            // 
            // lblMaxAbdu
            // 
            this.lblMaxAbdu.AutoSize = true;
            this.lblMaxAbdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAbdu.Location = new System.Drawing.Point(187, 74);
            this.lblMaxAbdu.Name = "lblMaxAbdu";
            this.lblMaxAbdu.Size = new System.Drawing.Size(121, 20);
            this.lblMaxAbdu.TabIndex = 1;
            this.lblMaxAbdu.Text = "Max.Abduzidos:";
            // 
            // lblMaxTripu
            // 
            this.lblMaxTripu.AutoSize = true;
            this.lblMaxTripu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTripu.Location = new System.Drawing.Point(184, 112);
            this.lblMaxTripu.Name = "lblMaxTripu";
            this.lblMaxTripu.Size = new System.Drawing.Size(124, 20);
            this.lblMaxTripu.TabIndex = 2;
            this.lblMaxTripu.Text = "Max.Tripulantes:";
            // 
            // lblPlanetaOrig
            // 
            this.lblPlanetaOrig.AutoSize = true;
            this.lblPlanetaOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetaOrig.Location = new System.Drawing.Point(164, 146);
            this.lblPlanetaOrig.Name = "lblPlanetaOrig";
            this.lblPlanetaOrig.Size = new System.Drawing.Size(144, 20);
            this.lblPlanetaOrig.TabIndex = 3;
            this.lblPlanetaOrig.Text = "Planeta de Origem:";
            // 
            // nudAbduzidos
            // 
            this.nudAbduzidos.Location = new System.Drawing.Point(314, 74);
            this.nudAbduzidos.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAbduzidos.Name = "nudAbduzidos";
            this.nudAbduzidos.Size = new System.Drawing.Size(120, 20);
            this.nudAbduzidos.TabIndex = 4;
            this.nudAbduzidos.ValueChanged += new System.EventHandler(this.nudAbduzidos_ValueChanged);
            // 
            // nudTripulantes
            // 
            this.nudTripulantes.Location = new System.Drawing.Point(313, 115);
            this.nudTripulantes.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTripulantes.Name = "nudTripulantes";
            this.nudTripulantes.Size = new System.Drawing.Size(120, 20);
            this.nudTripulantes.TabIndex = 5;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(313, 146);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaneta.TabIndex = 6;
            // 
            // btnInciar
            // 
            this.btnInciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInciar.Location = new System.Drawing.Point(168, 173);
            this.btnInciar.Name = "btnInciar";
            this.btnInciar.Size = new System.Drawing.Size(306, 62);
            this.btnInciar.TabIndex = 7;
            this.btnInciar.Text = "Iniciar";
            this.btnInciar.UseVisualStyleBackColor = true;
            this.btnInciar.Click += new System.EventHandler(this.btnInciar_Click);
            // 
            // Inicializador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 247);
            this.Controls.Add(this.btnInciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.nudTripulantes);
            this.Controls.Add(this.nudAbduzidos);
            this.Controls.Add(this.lblPlanetaOrig);
            this.Controls.Add(this.lblMaxTripu);
            this.Controls.Add(this.lblMaxAbdu);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inicializador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializador";
            this.Load += new System.EventHandler(this.Inicializador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAbduzidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMaxAbdu;
        private System.Windows.Forms.Label lblMaxTripu;
        private System.Windows.Forms.Label lblPlanetaOrig;
        private System.Windows.Forms.NumericUpDown nudAbduzidos;
        private System.Windows.Forms.NumericUpDown nudTripulantes;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnInciar;
    }
}