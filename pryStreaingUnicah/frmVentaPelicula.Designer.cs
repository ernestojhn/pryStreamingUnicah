namespace pryStreaingUnicah
{
    partial class frmVentaPelicula
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.gEstrenos = new System.Windows.Forms.DataGridView();
            this.gDetalle = new System.Windows.Forms.DataGridView();
            this.IdPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gEstrenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(547, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 0;
            // 
            // gEstrenos
            // 
            this.gEstrenos.AllowUserToAddRows = false;
            this.gEstrenos.AllowUserToDeleteRows = false;
            this.gEstrenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gEstrenos.Location = new System.Drawing.Point(12, 130);
            this.gEstrenos.Name = "gEstrenos";
            this.gEstrenos.ReadOnly = true;
            this.gEstrenos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gEstrenos.Size = new System.Drawing.Size(339, 150);
            this.gEstrenos.TabIndex = 1;
            // 
            // gDetalle
            // 
            this.gDetalle.AllowUserToAddRows = false;
            this.gDetalle.AllowUserToDeleteRows = false;
            this.gDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPelicula,
            this.NombrePelicula});
            this.gDetalle.Location = new System.Drawing.Point(438, 130);
            this.gDetalle.Name = "gDetalle";
            this.gDetalle.ReadOnly = true;
            this.gDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gDetalle.Size = new System.Drawing.Size(346, 150);
            this.gDetalle.TabIndex = 2;
            // 
            // IdPelicula
            // 
            this.IdPelicula.HeaderText = "Cod. Pelicula";
            this.IdPelicula.Name = "IdPelicula";
            this.IdPelicula.ReadOnly = true;
            this.IdPelicula.Visible = false;
            // 
            // NombrePelicula
            // 
            this.NombrePelicula.HeaderText = "Nombre pelicula";
            this.NombrePelicula.Name = "NombrePelicula";
            this.NombrePelicula.ReadOnly = true;
            this.NombrePelicula.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peliculas estreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peliculas a llevar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(357, 216);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "<";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(292, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSubTot
            // 
            this.txtSubTot.Enabled = false;
            this.txtSubTot.Location = new System.Drawing.Point(684, 298);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(100, 20);
            this.txtSubTot.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sub-Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISV";
            // 
            // txtISV
            // 
            this.txtISV.Location = new System.Drawing.Point(684, 336);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(100, 20);
            this.txtISV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(684, 375);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // frmVentaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 426);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubTot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gDetalle);
            this.Controls.Add(this.gEstrenos);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmVentaPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentaPelicula";
            this.Load += new System.EventHandler(this.frmVentaPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gEstrenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView gEstrenos;
        private System.Windows.Forms.DataGridView gDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePelicula;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
    }
}