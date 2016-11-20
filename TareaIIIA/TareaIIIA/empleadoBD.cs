using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TareaIIIA
{
    class empleadoBD
    {
        public static int Agregar(empleado pNombre)
        {
            int retorno = 0;
            using (SqlConnection Conn = ConectorBD.ObtnerCOnexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into empleado (Nombre, Apellido, Sexo, status) values ('{0}', '{1}','{2}','{3}')",
                    pNombre.Nombre, pNombre.Apellido, pNombre.sexo, pNombre.status), Conn);

                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }
            return retorno;
        }
        public static List<empleado> BuscarEmpleado(String Nombre, String Apellido)
        {

            List<empleado> Lista = new List<empleado>();
            using (SqlConnection conexion = ConectorBD.ObtnerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id, Nombre,  Apellido, Sexo, status from Alumnos where Nombre like '%{0}%' or Apellido like '%{1}%'",Nombre, Apellido), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    empleado empleado = new empleado();
                    empleado.Id = reader.GetInt64(0);
                    empleado.Nombre = reader.GetString(1);
                    empleado.Apellido = reader.GetString(2);
                    empleado.sexo = reader.GetString(3);
                    empleado.status = reader.GetString(4);

                    Lista.Add(empleado);

                }
                conexion.Close();
                return Lista;
            }
        }
    }
}
