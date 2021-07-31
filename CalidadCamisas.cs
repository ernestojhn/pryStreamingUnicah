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
    public partial class CalidadCamisas : Form
    {
        delegate bool delEvaluacion(double valor);
        DataTable dtEvaluacion = new DataTable();

        public CalidadCamisas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            float calidad = 0;

            delEvaluacion dEv;

            //Ancho del cuerpo debe de estar entre 21 y 23 cm
            dEv = (x) => (x >= 21 && x <= 23);

            calidad += dEv(Convert.ToDouble(txtAnchoCuerpo.Text)) ? 1 : 0;
            //Manga tiene que estar entre 17.75 y 19.25
            dEv = (x) => (x >= 17.75 && x <= 19.25);

            calidad += dEv(Convert.ToDouble(txtManga.Text)) ? 1 : 0;

            //Cierre manga entre 3.25 y 3.75

            dEv = (x) => (x >= 3.25 && x <= 3.75);

            calidad += dEv(Convert.ToDouble(txtCierreManga.Text)) ? 1 : 0;

            //Largo entre 29 y 31
            dEv = (x) => (x >= 29 && x <= 31);

            calidad += dEv(Convert.ToDouble(txtLargoCuerpo.Text)) ? 1 : 0;

            //Abertura entre 7 y 8
            dEv = (x) => (x >= 7 && x <= 8);

            calidad += dEv(Convert.ToDouble(txtAbertura.Text)) ? 1 : 0;

            dtEvaluacion.Rows.Add(new object[] { txtAnchoCuerpo.Text, txtManga.Text, txtCierreManga.Text
                ,txtLargoCuerpo.Text, txtAbertura.Text, (calidad/5)*100});

            dgEvaluacion.DataSource = dtEvaluacion;

        }

        private void CalidadCamisas_Load(object sender, EventArgs e)
        {
            

            dtEvaluacion.Columns.Add("Ancho de cuerpo");
            dtEvaluacion.Columns.Add("Manga");
            dtEvaluacion.Columns.Add("Cierre manga");
            dtEvaluacion.Columns.Add("Largo cuerpo");
            dtEvaluacion.Columns.Add("Abertura cuello");
            dtEvaluacion.Columns.Add("Calidad");

        }
    }
}
