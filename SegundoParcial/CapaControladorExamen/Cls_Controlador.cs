using CapaModeloExamen;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControladorExamen
{
    public class Cls_Controlador
    {
        Cls_Sentencias sentencias = new Cls_Sentencias();
        public OdbcDataReader Insertar_Alumno(string str_codigo, string str_nombre, string str_apellido, string str_direccion,  string str_telefono, string str_correo, string str_estado)
        {
            return sentencias.Insertar("alumnos", str_codigo, str_nombre, str_apellido,  str_direccion,  str_telefono, str_correo, str_estado);

        }
        public OdbcDataReader consulta_alumno()
        {
            return sentencias.consulta("alumnos");
        }
    }
}
