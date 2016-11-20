using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TareaIII
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        public Conexion()
            
            {
            
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=TareaIII;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion Existosa");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de conexion:" + ex.ToString());
            }
            
            }
        public string insertar(int id,string nombre,string apellido,string sexo,string status)
        {
            string salida = "se inserto";
            try
            {
                cmd = new SqlCommand("Insert into empleado(id,nombre,apellido,sexo,status)values("+id+",'"+nombre+ "','" + apellido + "','" + sexo + "','" + status + "')",cn);
                cmd.ExecuteNonQuery();
            }
        catch(Exception ex)
            {
                salida = "no se conecto:" + ex.ToString();
            }
            return salida;
        }
        public int personaRegistrada(int id)
        {
            int contador=0;
            try
            {
                cmd = new SqlCommand("Select * from empleado where id="+id+"",cn);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo consultar"+ex.ToString());
            }
            return contador;
        }
        public void cargarEmpleado(DataGrid dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select* from empleado", cn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGrid" + ex.ToString());
            }
        }
    }
}
