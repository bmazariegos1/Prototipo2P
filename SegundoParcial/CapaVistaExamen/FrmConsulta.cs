using CapaControladorExamen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaExamen
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
            mostrar_consulta();
        }
        Cls_Controlador controlador = new Cls_Controlador();
        public void mostrar_consulta()
        {
            OdbcDataReader mostrar = controlador.consulta_alumno();
            try
            {
                while (mostrar.Read())
                {
                    dgv_consulta.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void FrmConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
