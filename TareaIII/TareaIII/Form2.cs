using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaIII
{
    public partial class Form2 : Form
    {
        Conexion c = new Conexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) == 0) 
            {

                MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text), txbNombre.Text, txbApellido.Text, txtSexo.Text,textBox1.Text));
            }
            else
            {
                MessageBox.Show("El registro existe");
            }
        }
    }
}


