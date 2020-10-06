using CapaControladorExamen;
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
    public partial class FrmMantenientoAlumno : Form
    {
        public FrmMantenientoAlumno()
        {
            InitializeComponent();
        }
        Cls_Controlador controlador = new Cls_Controlador();
        string strestado;
        public void radioboton()
        {
            if (rbhabilitado.Checked == true)
            {
                strestado = "1";
            }else
            {
                strestado = "0";
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controlador.Insertar_Alumno(txtcarne.Text, txtApellido.Text, txtApellido.Text, txtDirección.Text, txtTelefono.Text, txtCorreo.Text, strestado);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsulta consulta = new FrmConsulta();
            consulta.ShowDialog();
        }
    }
}
