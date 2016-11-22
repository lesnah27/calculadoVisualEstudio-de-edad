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
        }
    }

