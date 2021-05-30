namespace pryStreaingUnicah
{
    partial class CalidadCamisas
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
            this.txtAnchoCuerpo = new System.Windows.Forms.TextBox();
            this.txtManga = new System.Windows.Forms.TextBox();
            this.txtCierreManga = new System.Windows.Forms.TextBox();
            this.txtLargoCuerpo = new System.Windows.Forms.TextBox();
            this.txtAbertura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgEvaluacion = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnchoCuerpo
            // 
            this.txtAnchoCuerpo.Location = new System.Drawing.Point(13, 104);
            this.txtAnchoCuerpo.Name = "txtAnchoCuerpo";
            this.txtAnchoCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtAnchoCuerpo.TabIndex = 0;
            // 
            // txtManga
            // 
            this.txtManga.Location = new System.Drawing.Point(160, 104);
            this.txtManga.Name = "txtManga";
            this.txtManga.Size = new System.Drawing.Size(100, 20);
            this.txtManga.TabIndex = 1;
            // 
            // txtCierreManga
            // 
            this.txtCierreManga.Location = new System.Drawing.Point(294, 103);
            this.txtCierreManga.Name = "txtCierreManga";
            this.txtCierreManga.Size = new System.Drawing.Size(100, 20);
            this.txtCierreManga.TabIndex = 2;
            // 
            // txtLargoCuerpo
            // 
            this.txtLargoCuerpo.Location = new System.Drawing.Point(424, 103);
            this.txtLargoCuerpo.Name = "txtLargoCuerpo";
            this.txtLargoCuerpo.Size = new System.Drawing.Size(100, 20);
            this.txtLargoCuerpo.TabIndex = 3;
            // 
            // txtAbertura
            // 
            this.txtAbertura.Location = new System.Drawing.Point(569, 103);
            this.txtAbertura.Name = "txtAbertura";
            this.txtAbertura.Size = new System.Drawing.Size(100, 20);
            this.txtAbertura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ancho cuerpo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cierre de manga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Largo cuerpo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Abertura del cuello";
            // 
            // dgEvaluacion
            // 
            this.dgEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvaluacion.Location = new System.Drawing.Point(13, 171);
            this.dgEvaluacion.Name = "dgEvaluacion";
            this.dgEvaluacion.Size = new System.Drawing.Size(656, 150);
            this.dgEvaluacion.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(676, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CalidadCamisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 346);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgEvaluacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbertura);
            this.Controls.Add(this.txtLargoCuerpo);
            this.Controls.Add(this.txtCierreManga);
            this.Controls.Add(this.txtManga);
            this.Controls.Add(this.txtAnchoCuerpo);
            this.Name = "CalidadCamisas";
            this.Text = "CalidadCamisas";
            this.Load += new System.EventHandler(this.CalidadCamisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEvaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnchoCuerpo;
        private System.Windows.Forms.TextBox txtManga;
        private System.Windows.Forms.TextBox txtCierreManga;
        private System.Windows.Forms.TextBox txtLargoCuerpo;
        private System.Windows.Forms.TextBox txtAbertura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgEvaluacion;
        private System.Windows.Forms.Button btnAgregar;
    }
}