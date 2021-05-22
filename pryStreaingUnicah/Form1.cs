using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryStreaingUnicah
{
    public partial class Form1 : Form
    {
        StreamingUnicahEntities entityStreaming = new StreamingUnicahEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescTipoPelicula.Text.Equals("")) {
                MessageBox.Show("Por favor ingresar descripcion");
                return;
            }

            TiposPeliculas tbTipoPelicula = new TiposPeliculas();
            tbTipoPelicula.DescripcionTipoPelicula = txtDescTipoPelicula.Text;
            tbTipoPelicula.EstadoTipoPelicula = chkEstado.Checked;
            entityStreaming.TiposPeliculas.Add(tbTipoPelicula);

            entityStreaming.SaveChanges();//se confirma la insercion

            txtDescTipoPelicula.Text = "";
            chkEstado.Checked = false;
            
        }
    }
}
