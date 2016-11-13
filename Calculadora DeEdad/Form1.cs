using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_DeEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan Diferencia = DateTime.Today.Subtract(DTP.Value.Date);
            int Edad = (int)(Diferencia.TotalDays / 365.25);
            TxtMeses.Text= DTP.Value.Month.ToString();
           
            TxtDias.Text = Diferencia.TotalDays.ToString();
            TxtHoras.Text = Diferencia.TotalHours.ToString();
            TxtMinutos.Text = Diferencia.TotalMinutes.ToString();
            TxtSegundo.Text = Diferencia.TotalSeconds.ToString();
            TxtEdad.Text = Edad.ToString();
            System.DateTime Fnac = DTP.Value.Date;
            switch (Fnac.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    TxtDiaNac.Text = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    TxtDiaNac.Text = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    TxtDiaNac.Text = "Miercoles";
                    break;
                case DayOfWeek.Thursday:
                    TxtDiaNac.Text = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    TxtDiaNac.Text = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    TxtDiaNac.Text = "Sabado";
                    break;
                case DayOfWeek.Sunday:
                    TxtDiaNac.Text = "Domingo";
                    break;
            }
            }
    }
}
