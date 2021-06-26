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
    public partial class frmMenu : Form
    {
        long idUsuario = 0;
        StreamingUnicahEntities entity = new StreamingUnicahEntities();

        public frmMenu(long _idUsuario)
        {
            InitializeComponent();
            idUsuario = _idUsuario;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            var tInfoUsuario = from u in entity.Usuarios
                               join per in entity.Perfiles on u.FKPerfil equals per.IdPerfil
                               where u.IdUsuario == idUsuario
                               select new
                               {
                                   u.Usuario,
                                   u.FKPerfil,
                                   per.DescripcionPerfil
                               };


            DataTable dtInfoUsuario = tInfoUsuario.CopyAnonymusToDataTable();
            short fkPerfil = Convert.ToInt16(dtInfoUsuario.Rows[0].ItemArray[1]);

            var tPerfilMod = from mods in entity.PerfilModulo
                             where mods.FKPerfilId == fkPerfil
                             select mods;
            //short[] arrMod = new short[] { };
            List<short> lMod = new List<short>();

            DataTable dtpm = tPerfilMod.CopyAnonymusToDataTable();

            for (int x = 0; x < dtpm.Rows.Count; x++) {
                lMod.Add(Convert.ToInt16(dtpm.Rows[x].ItemArray[1]));
                //arrMod[x] = Convert.ToInt16(dtpm.Rows[x].ItemArray[1]);

            }


            var tmodulos = from pm in entity.Modulos
                           join md in entity.ModuloPrincipal on pm.FKModuloPrincipal equals md.IdModuloPrincipal
                           where lMod.Contains(pm.IdModulos) 
                           & md.EstadoModuloPrin == true 
                           & pm.EstadoModulo==true
                           orderby pm.FKModuloPrincipal
                           select new
                           {
                               pm.DescripcionModulo,
                               md.DescripcionModuloPrin,
                               pm.FKModuloPrincipal,
                               pm.IdModulos
                           };

            DataTable dtMods = tmodulos.CopyAnonymusToDataTable();
            DataRow dtR = dtMods.NewRow();
            dtR[2] = "0";
            dtR[3] = "0";
            dtMods.Rows.Add(dtR);
            short modPrinAnterior=0;
            MenuStrip mnStrip = new MenuStrip();
            ToolStripMenuItem mnPrin= new ToolStripMenuItem();
            
            foreach (DataRow dr in dtMods.Rows) {
                if (modPrinAnterior == Convert.ToInt16(dr[2]))
                {
                    ToolStripMenuItem subMenu = new ToolStripMenuItem(dr[0].ToString(),null,ChildClick);
                    subMenu.Name = dr[0].ToString();
                    mnPrin.DropDownItems.Add(subMenu);
                }
                else {
                    if(!mnPrin.Name.Equals(""))
                        mnStrip.Items.Add(mnPrin);
                    mnPrin = new ToolStripMenuItem(dr[1].ToString());

                    mnPrin.Name = dr[1].ToString();
                    ToolStripMenuItem subMenu = new ToolStripMenuItem(dr[0].ToString(), null, ChildClick);
                    subMenu.Name = dr[0].ToString();
                    mnPrin.DropDownItems.Add(subMenu);
                
                }
                modPrinAnterior = Convert.ToInt16(dr[2]);

            }
            this.Controls.Add(mnStrip);
            //var tbusqueda = entity.TiposPeliculas.Where(x => x.DescripcionTipoPelicula.Contains("dr"));
            //LIKE dr%
            //LIKE %dr

        }

        public void ChildClick(object sender, EventArgs e) {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            var tipo = Type.GetType("pryStreaingUnicah."+menu.Name);

            var frm = Activator.CreateInstance(tipo);

            Form formulario = (Form)frm;

            formulario.Show();
        
        }
    }
}
