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
    public partial class frmTopVentas : Form
    {
        StreamingUnicahEntities entiy = new StreamingUnicahEntities();

        public frmTopVentas()
        {
            InitializeComponent();
        }

        private void frmTopVentas_Load(object sender, EventArgs e)
        {
            var vTotSum = from v in entiy.TOP10VentaPeliculas
                          select v;
            dgTotalSuma.DataSource = vTotSum.CopyAnonymusToDataTable();

            var vTotCant = from vc in entiy.TO10CantidadVendida
                           select vc;

            dgTotalCantidad.DataSource = vTotCant.CopyAnonymusToDataTable();
            
        }
    }
}
