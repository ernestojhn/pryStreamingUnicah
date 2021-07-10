namespace pryStreaingUnicah
{
    partial class frmTopVentas
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
            this.dgTotalSuma = new System.Windows.Forms.DataGridView();
            this.dgTotalCantidad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTotalSuma
            // 
            this.dgTotalSuma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalSuma.Location = new System.Drawing.Point(23, 134);
            this.dgTotalSuma.Name = "dgTotalSuma";
            this.dgTotalSuma.Size = new System.Drawing.Size(298, 293);
            this.dgTotalSuma.TabIndex = 0;
            // 
            // dgTotalCantidad
            // 
            this.dgTotalCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTotalCantidad.Location = new System.Drawing.Point(479, 134);
            this.dgTotalCantidad.Name = "dgTotalCantidad";
            this.dgTotalCantidad.Size = new System.Drawing.Size(298, 293);
            this.dgTotalCantidad.TabIndex = 1;
            // 
            // frmTopVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 474);
            this.Controls.Add(this.dgTotalCantidad);
            this.Controls.Add(this.dgTotalSuma);
            this.Name = "frmTopVentas";
            this.Text = "Top Ventas";
            this.Load += new System.EventHandler(this.frmTopVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTotalCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTotalSuma;
        private System.Windows.Forms.DataGridView dgTotalCantidad;
    }
}