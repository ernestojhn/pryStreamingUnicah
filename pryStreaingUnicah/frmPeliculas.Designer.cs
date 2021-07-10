namespace pryStreaingUnicah
{
    partial class frmPeliculas
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
            this.txtNombrePel = new System.Windows.Forms.TextBox();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoPelicula = new System.Windows.Forms.ComboBox();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.cmbEstudio = new System.Windows.Forms.ComboBox();
            this.txtExento = new System.Windows.Forms.TextBox();
            this.chkEstreno = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBbusqueda = new System.Windows.Forms.Button();
            this.txtDirImg = new System.Windows.Forms.TextBox();
            this.dgPeliculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePel
            // 
            this.txtNombrePel.Location = new System.Drawing.Point(130, 42);
            this.txtNombrePel.Name = "txtNombrePel";
            this.txtNombrePel.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePel.TabIndex = 0;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.Location = new System.Drawing.Point(130, 69);
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCorto.TabIndex = 1;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(130, 216);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 2;
            // 
            // dFecha
            // 
            this.dFecha.Location = new System.Drawing.Point(130, 101);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(200, 20);
            this.dFecha.TabIndex = 3;
            this.dFecha.Value = new System.DateTime(2021, 7, 9, 20, 5, 17, 0);
            // 
            // cmbTipoPelicula
            // 
            this.cmbTipoPelicula.FormattingEnabled = true;
            this.cmbTipoPelicula.Location = new System.Drawing.Point(130, 127);
            this.cmbTipoPelicula.Name = "cmbTipoPelicula";
            this.cmbTipoPelicula.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPelicula.TabIndex = 4;
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(130, 154);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbClasificacion.TabIndex = 5;
            // 
            // cmbEstudio
            // 
            this.cmbEstudio.FormattingEnabled = true;
            this.cmbEstudio.Location = new System.Drawing.Point(130, 189);
            this.cmbEstudio.Name = "cmbEstudio";
            this.cmbEstudio.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudio.TabIndex = 6;
            // 
            // txtExento
            // 
            this.txtExento.Location = new System.Drawing.Point(293, 216);
            this.txtExento.Name = "txtExento";
            this.txtExento.Size = new System.Drawing.Size(100, 20);
            this.txtExento.TabIndex = 7;
            // 
            // chkEstreno
            // 
            this.chkEstreno.AutoSize = true;
            this.chkEstreno.Location = new System.Drawing.Point(325, 129);
            this.chkEstreno.Name = "chkEstreno";
            this.chkEstreno.Size = new System.Drawing.Size(68, 17);
            this.chkEstreno.TabIndex = 8;
            this.chkEstreno.Text = "Estreno?";
            this.chkEstreno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "nombre pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "nombre corto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "fecha lanzamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo pelicula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "clasificacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "estudio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "precio venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Exento";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(325, 158);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(58, 17);
            this.chkEstado.TabIndex = 19;
            this.chkEstado.Text = "estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnBbusqueda
            // 
            this.btnBbusqueda.Location = new System.Drawing.Point(620, 240);
            this.btnBbusqueda.Name = "btnBbusqueda";
            this.btnBbusqueda.Size = new System.Drawing.Size(37, 23);
            this.btnBbusqueda.TabIndex = 23;
            this.btnBbusqueda.Text = "...";
            this.btnBbusqueda.UseVisualStyleBackColor = true;
            this.btnBbusqueda.Click += new System.EventHandler(this.btnBbusqueda_Click);
            // 
            // txtDirImg
            // 
            this.txtDirImg.Location = new System.Drawing.Point(400, 266);
            this.txtDirImg.Name = "txtDirImg";
            this.txtDirImg.ReadOnly = true;
            this.txtDirImg.Size = new System.Drawing.Size(257, 20);
            this.txtDirImg.TabIndex = 24;
            // 
            // dgPeliculas
            // 
            this.dgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeliculas.Location = new System.Drawing.Point(23, 329);
            this.dgPeliculas.Name = "dgPeliculas";
            this.dgPeliculas.Size = new System.Drawing.Size(597, 150);
            this.dgPeliculas.TabIndex = 25;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 527);
            this.Controls.Add(this.dgPeliculas);
            this.Controls.Add(this.txtDirImg);
            this.Controls.Add(this.btnBbusqueda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEstreno);
            this.Controls.Add(this.txtExento);
            this.Controls.Add(this.cmbEstudio);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.cmbTipoPelicula);
            this.Controls.Add(this.dFecha);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.txtNombrePel);
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePel;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.DateTimePicker dFecha;
        private System.Windows.Forms.ComboBox cmbTipoPelicula;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.ComboBox cmbEstudio;
        private System.Windows.Forms.TextBox txtExento;
        private System.Windows.Forms.CheckBox chkEstreno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBbusqueda;
        private System.Windows.Forms.TextBox txtDirImg;
        private System.Windows.Forms.DataGridView dgPeliculas;
    }
}