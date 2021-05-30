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
    public partial class MantenimientoEstudios : Form
    {
        StreamingUnicahEntities entity = new StreamingUnicahEntities();
        public MantenimientoEstudios()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientoEstudios_Load(object sender, EventArgs e)
        {
            var tPaises = from p in entity.Paises
                          select new
                          {
                              p.IdPais,
                              p.NombrePais
                          };
            DataTable dtPaises = tPaises.CopyAnonymusToDataTable();
            cmbPaises.DataSource = dtPaises;
            cmbPaises.DisplayMember = dtPaises.Columns[1].ColumnName;
            cmbPaises.ValueMember = dtPaises.Columns[0].ColumnName;


        }
    }
}
