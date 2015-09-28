using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EjerciciosCap7
{
    public partial class PromedioMinMax : Form
    {
        
        double cant;
        double cal;
        int aux = 0;
        
        ArrayList notas;
        double prom = 0;
     
        double total = 0;
        public PromedioMinMax()
        {
            InitializeComponent();

            notas = new ArrayList();

        }

        public void Min()
        {
            notas.Sort();
            textBoxMinima.Text = notas[0].ToString();
        }

        public void Max()
        {
            notas.Reverse();
            textBoxMaxima.Text = notas[0].ToString();
        }

        private void PromedioMinMax_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            
            cal = Convert.ToDouble(textBoxCalificaciones.Text);
           
            notas.Add(cal);
             aux++;
            prom = 0;
            foreach (double var in notas )
            {
                prom += var;
            }
            total = prom / aux;
           

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            
            Min();
            Max();
          

            textBoxPromedio.Text = total.ToString();



        }
    }
}

