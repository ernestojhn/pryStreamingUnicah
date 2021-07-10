using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryStreaingUnicah
{
    public partial class frmPeliculas : Form
    {
        StreamingUnicahEntities entity = new StreamingUnicahEntities();
        public frmPeliculas()
        {
            InitializeComponent();
        }

        private void btnBbusqueda_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Imagenes (*.png;*.jpg)|*.png;*.jpg";

            DialogResult dlgRes = dlg.ShowDialog();
            

            if (dlgRes != DialogResult.Cancel) {
                pictureBox1.ImageLocation = dlg.FileName;

                txtDirImg.Text = dlg.FileName;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peliculas tPel = new Peliculas();

            tPel.NombrePelicula = txtNombrePel.Text;
            tPel.NombreCorto = txtNombreCorto.Text;
            tPel.PrecioVenta =Convert.ToDecimal( txtPrecioVenta.Text);
            tPel.FKIdTipoPelicula = Convert.ToByte( cmbTipoPelicula.SelectedValue);
            tPel.FKIdEstudio = Convert.ToInt32(cmbEstudio.SelectedValue);
            tPel.FKIdClasificacion = Convert.ToByte(cmbClasificacion.SelectedValue);
            tPel.FechaLanzamiento = dFecha.Value;
                //Convert.ToDateTime( dFecha.Value.ToShortDateString());
            tPel.Exento = txtExento.Text;
            tPel.EstadoPelicula = chkEstado.Checked;
            tPel.Estreno = chkEstreno.Checked;
            tPel.DireccionImagen = txtDirImg.Text;
            tPel.ImagenPel = LeerArchivo(txtDirImg.Text);

            entity.Peliculas.Add(tPel);
            entity.SaveChanges();

            MessageBox.Show("Datos guardados");


        }

        private void frmPeliculas_Load(object sender, EventArgs e)
        {
            var tipoPel = from tipo in entity.TiposPeliculas
                          select tipo;
            DataTable dtTipoPel = new DataTable();
            dtTipoPel = tipoPel.CopyAnonymusToDataTable();

            cmbTipoPelicula.DataSource = dtTipoPel;
            cmbTipoPelicula.DisplayMember = dtTipoPel.Columns[1].ColumnName;
            cmbTipoPelicula.ValueMember = dtTipoPel.Columns[0].ColumnName;

            var clasf = from c in entity.Clasificaciones
                          select c;
            DataTable dtClas = new DataTable();
            dtClas = clasf.CopyAnonymusToDataTable();

            cmbClasificacion.DataSource = dtClas;
            cmbClasificacion.DisplayMember = dtClas.Columns[1].ColumnName;
            cmbClasificacion.ValueMember = dtClas.Columns[0].ColumnName;

            var estud = from es in entity.Estudios
                        select es;
            DataTable dtEst = new DataTable();
            dtEst = estud.CopyAnonymusToDataTable();

            cmbEstudio.DataSource = dtEst;
            cmbEstudio.DisplayMember = dtEst.Columns[1].ColumnName;
            cmbEstudio.ValueMember = dtEst.Columns[0].ColumnName;

            var tPel = from p in entity.Peliculas
                       select p;

            dgPeliculas.DataSource = tPel.CopyAnonymusToDataTable();


        }

        byte[] LeerArchivo(string dir) {
            byte[] data = null;

            FileInfo fInfo = new FileInfo(dir);

            long numBytes = fInfo.Length;

            FileStream fStream = new FileStream(dir, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            data = br.ReadBytes((int)numBytes);
            return data;
        }
    }
}
