using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCap7
{
    public partial class gastosDelMes : Form
    {
        Queue datos;
        double gastos;
        double total = 0;
        public gastosDelMes()
        {
            InitializeComponent();
            datos = new Queue();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            double.TryParse(textBoxGastos.Text, out gastos);

            datos.Enqueue(gastos);
            textBoxGastos.Text = "";
        }

       

        private void gastosDelMes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxGastos.Text += datos.Dequeue().ToString() + "\n";
            
        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            
            total += gastos;
            richTextBoxTotales.Text = total.ToString();
        }
    }
}
