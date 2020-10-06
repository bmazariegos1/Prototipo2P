using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloExamen
{
    public class Cls_Sentencias
    {
        Cls_Conexion cn = new Cls_Conexion();
        OdbcCommand comm;

        public OdbcDataReader Insertar(String strTabla, string strCodigo, string strNombre, string strApellido, string strDireccion, string strTelefono, string strCorreo, string strEstado)
        {
            try
            {

                string str_consulta = "insert into " + strTabla + " values('" + strCodigo + "','" + strNombre + "', '" + strApellido + "','" + strDireccion + "','" + strTelefono + "','" + strCorreo + "','" + strEstado + "');";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Datos registrados.");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error al registrar.");
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //public OdbcDataReader modificar(int intConsulta, string strCodigo, string strNombre, string strApellido, string strDireccion, string strTelefono, string strCorreo, string strEstado)
        //{
        //    string strTabla;
            
        //        string strConsulta = "";
        //        if (intConsulta == 0)
        //        {
        //            strTabla = "tbl_empleado";
        //            strConsulta = "UPDATE alumnos set nombre_empleado='" + strNombre + "',apellido_empleado='" + strApellido + ",direccion_empleado='" + strDireccion + "',nit_empleado=" + strNit + ",fechanacimiento_empleado='" + strFechanacimiento + "',fechaingreso_empleado='" + strFechaingreso + "',telefono_empleado=" + strTelefono + ",correo_empleado='" + strCorreo + "',genero_empleado=" + strGenero + ",fk_idestadocivil_empleado=" + strEstadocivil + ",estado_empleado=" + strEstado + " where pk_id_empleado= " + strCodigo + ";";
        //        }
        //        else if (intConsulta == 1)
        //        {
        //            strTabla = "tbl_paciente";
        //            strConsulta = "UPDATE maestros set nombre_paciente='" + strNombre + "',apellido_paciente='" + strApellido + "',dpi_paciente=" + strDpi + ",direccion_paciente='" + strDireccion + "',nit_paciente=" + strNit + ",fechanacimiento_paciente='" + strFechanacimiento + "',fechaingreso_paciente='" + strFechaingreso + "',telefono_paciente=" + strTelefono + ",correo_paciente='" + strCorreo + "',genero_paciente=" + strGenero + ",fk_idestadocivil_paciente=" + strEstadocivil + ",estado_paciente=" + strEstado + " where pk_id_paciente= " + strCodigo + ";";
        //        }
        //        else
        //    try
        //    {
        //        comm = new OdbcCommand(strConsulta, cn.conexion());
        //        OdbcDataReader mostrar = comm.ExecuteReader();
        //        return mostrar;
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show("Ocurrio un error en la modificación, contacte a IT");
        //        Console.WriteLine(err.Message);
        //        return null;
        //    }
        //}
        public OdbcDataReader eliminar(int intConsulta, string strCodigo)
        {
            
                string strConsulta = "";
                if (intConsulta == 0)
                {
                    strConsulta = "UPDATE alumnos set estado_empleado= 0 where pk_id_empleado= " + strCodigo + ";";
                }
                else if (intConsulta == 1)
                {
                    strConsulta = "UPDATE maestros set estado_paciente= 0 where pk_id_paciente= " + strCodigo + ";";
                }
            try
            {
                comm = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                MessageBox.Show("Eliminado Correctamente.");
                return mostrar;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la eliminación, contacte a IT");
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consulta(string strTabla)
        {
            try
            {
                string strConsulta = "SELECT * FROM " + strTabla + ";";
                OdbcCommand command = new OdbcCommand(strConsulta, cn.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocurrio un error en la vista de contenido, contacte a IT");
                Console.WriteLine(err.Message);
                return null;
            }

        }
    }
}
