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
    public partial class frmVentaPelicula : Form
    {
        StreamingUnicahEntities entity = new StreamingUnicahEntities();
        

        DataTable dtEstrenos = new DataTable();
            

        public frmVentaPelicula()
        {
            InitializeComponent();
        }

        private void frmVentaPelicula_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();

            var tEstrenos = from p in entity.Peliculas
                            where p.Estreno == true
                            select new {
                                p.IdPelicula,
                                p.NombrePelicula,
                                p.FechaLanzamiento

                            };

            //entity.Peliculas.First(x => x.Estreno == true);
            dtEstrenos= tEstrenos.CopyAnonymusToDataTable();
            gEstrenos.DataSource = dtEstrenos;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gEstrenos.SelectedRows.Count > 0)
            {
                int indice = gEstrenos.CurrentCell.RowIndex;
                long idPelicula = Convert.ToInt64(gEstrenos.Rows[indice].Cells[0].Value.ToString());
                string nombrePelicula = gEstrenos.Rows[indice].Cells[1].Value.ToString();
                
                gDetalle.Rows.Add(idPelicula.ToString(), nombrePelicula);

                dtEstrenos =(DataTable) gEstrenos.DataSource;
                dtEstrenos.Rows.RemoveAt(indice);
                gEstrenos.DataSource = dtEstrenos;

                decimal subtot = 0;
                decimal isv = 0;
                //decimal total = 0;

                foreach (DataGridViewRow dr in gDetalle.Rows) {

                    long fkidPelicula = Convert.ToInt64(dr.Cells[0].Value);
                    var pel=entity.Peliculas.FirstOrDefault(x => x.IdPelicula == fkidPelicula);
                    subtot += pel.PrecioVenta;
                    isv += pel.Exento.Equals("E") ? 0 : pel.PrecioVenta *(Convert.ToDecimal( pel.Exento.Substring(0,2))/100);

                }
                txtSubTot.Text = subtot.ToString("N2");
                txtISV.Text = isv.ToString("N2");
                txtTotal.Text = (subtot + isv).ToString("N2");

            }
            else {
                MessageBox.Show("Seleccione un estreno");

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (gDetalle.SelectedRows.Count > 0)
            {
                
                int indice = gDetalle.CurrentCell.RowIndex;
                long idPelicula = Convert.ToInt64(gDetalle.Rows[indice].Cells[0].Value.ToString());
                string nombrePelicula = gDetalle.Rows[indice].Cells[1].Value.ToString();

                dtEstrenos.Rows.Add(idPelicula.ToString(), nombrePelicula, "");
                
                gEstrenos.DataSource = dtEstrenos;
                gDetalle.Rows.RemoveAt(indice);

                decimal subtot = 0;
                decimal isv = 0;
                //decimal total = 0;

                foreach (DataGridViewRow dr in gDetalle.Rows)
                {

                    var pel = entity.Peliculas.FirstOrDefault(x => x.IdPelicula == Convert.ToInt64(dr.Cells[0].Value));
                    subtot += pel.PrecioVenta;
                    isv += pel.Exento.Equals("E") ? 0 : pel.PrecioVenta * Convert.ToDecimal(pel.Exento);

                }
                txtSubTot.Text = subtot.ToString("N2");
                txtISV.Text = isv.ToString("N2");
                txtTotal.Text = (subtot + isv).ToString("N2");

            }
            else
            {
                MessageBox.Show("Seleccione una pelicula a remover");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gDetalle.SelectedRows.Count > 0)
            {
                VentaPelicula tVenta = new VentaPelicula();
                tVenta.EstatusVenta = "Completa";
                tVenta.EstadoVenta = true;
                tVenta.IdUsuario = 2;
                tVenta.FechaVenta = DateTime.Now;
                tVenta.ISV = Convert.ToDecimal(txtISV.Text);
                tVenta.TotalVenta = Convert.ToDecimal(txtTotal.Text);
                    
                entity.VentaPelicula.Add(tVenta);
                entity.SaveChanges();

                foreach (DataGridViewRow dr in gDetalle.Rows)
                {
                    VentaDetallePelicula tDet = new VentaDetallePelicula();
                    tDet.FKIdPelicula = Convert.ToInt64(dr.Cells[0].Value);
                    tDet.FKIdVenta = tVenta.IdVenta;
                    entity.VentaDetallePelicula.Add(tDet);
                    entity.SaveChanges();
                }

                MessageBox.Show("Venta exitosa!");
                gDetalle.Rows.Clear();

                //foreach (DataGridViewRow dr in gDetalle.Rows)
                //{
                //    gDetalle.Rows.Remove(dr);
                //}
                //for (int x = 0; x < gDetalle.Rows.Count; x++) {
                //    gDetalle.Rows.RemoveAt(x);

                //}

                var tEstrenos = from p in entity.Peliculas
                                where p.Estreno == true
                                select new
                                {
                                    p.IdPelicula,
                                    p.NombrePelicula,
                                    p.FechaLanzamiento

                                };

                //entity.Peliculas.First(x => x.Estreno == true);
                dtEstrenos = tEstrenos.CopyAnonymusToDataTable();
                gEstrenos.DataSource = dtEstrenos;

                txtISV.Text = txtSubTot.Text = txtTotal.Text = "0.00";

            }
            else {
                MessageBox.Show("Seleccione al menos una pelicula");

            }
        }
    }
}
