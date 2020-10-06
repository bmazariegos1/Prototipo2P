using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaExamen
{
    public partial class FrmContenedorMDI : Form
    {
        public FrmContenedorMDI()
        {
            InitializeComponent();
        }

        private void registroDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenientoAlumno alumno = new FrmMantenientoAlumno();
            alumno.Show();
        }

        private void registroDeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoMaestro maestro = new FrmMantenimientoMaestro();
            maestro.Show();
        }
    }
}
