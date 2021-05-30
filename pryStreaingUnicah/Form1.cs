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
        long idPelicula = 0;
        bool editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tTipoPeliculas = from p in entityStreaming.TiposPeliculas
                                 select new
                                 {
                                     p.IdTipoPelicula,
                                     p.DescripcionTipoPelicula,
                                     p.EstadoTipoPelicula
                                 };
            dgTipoPeliculas.DataSource = tTipoPeliculas.CopyAnonymusToDataTable();
            dgTipoPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescTipoPelicula.Text.Equals("")) {
                MessageBox.Show("Por favor ingresar descripcion");
                return;
            }

            if (editar)
            {
                var tTipoP = entityStreaming.TiposPeliculas.FirstOrDefault(x => x.IdTipoPelicula == idPelicula);
                tTipoP.DescripcionTipoPelicula = txtDescTipoPelicula.Text;
                tTipoP.EstadoTipoPelicula = chkEstado.Checked;

                entityStreaming.SaveChanges();
            }
            else
            {

                TiposPeliculas tbTipoPelicula = new TiposPeliculas();
                tbTipoPelicula.DescripcionTipoPelicula = txtDescTipoPelicula.Text;
                tbTipoPelicula.EstadoTipoPelicula = chkEstado.Checked;
                entityStreaming.TiposPeliculas.Add(tbTipoPelicula);

                entityStreaming.SaveChanges();//se confirma la insercion
            }
            txtDescTipoPelicula.Text = "";
            chkEstado.Checked = false;
            idPelicula = 0;
            editar = false;

            var tTipoPelicula = from p in entityStreaming.TiposPeliculas
                                select new
                                {
                                    p.IdTipoPelicula,
                                    p.DescripcionTipoPelicula,
                                    p.EstadoTipoPelicula
                                };
            dgTipoPeliculas.DataSource = tTipoPelicula.CopyAnonymusToDataTable();

            MessageBox.Show("Informacion guardada!");

            
        }

        private void dgTipoPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTipoPeliculas.RowCount > 0) {
                try
                {
                    idPelicula = Convert.ToInt64(dgTipoPeliculas.SelectedCells[0].Value);
                    var tTipoPelicula = entityStreaming.TiposPeliculas.FirstOrDefault(x => x.IdTipoPelicula == idPelicula);
                    txtDescTipoPelicula.Text = tTipoPelicula.DescripcionTipoPelicula;
                    chkEstado.Checked = tTipoPelicula.EstadoTipoPelicula;
                    editar = true;

                }
                catch (Exception) {

                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescTipoPelicula.Text = "";
            chkEstado.Checked = false;
            idPelicula = 0;
            editar = false;
        }

        private void txtDescTipoPelicula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
