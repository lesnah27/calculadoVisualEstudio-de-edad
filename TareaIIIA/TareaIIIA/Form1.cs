using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaIIIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            empleado empleado = new empleado();

            empleado.Nombre = textBox1.Text;
            empleado.Apellido = textBox2.Text;
            empleado.sexo = textBox3.Text;
            empleado.status = textBox4.Text;

            int resultado = empleadoBD.Agregar(empleado);

            if(resultado>0)
                {
                MessageBox.Show("los datos se registraron correcto", "Datos Guardador", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("no se pudo guardar los datos", "error a guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar pBuscar = new Buscar();
            pBuscar.ShowDialog();
        }
    }
}
