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
    public partial class Simulacion : Form
    {
        string personas;
        Queue lista;
        public Simulacion()
        {
            InitializeComponent();
            lista = new Queue();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            personas = textBoxCliente.Text;
            lista.Enqueue(personas);
            textBoxCliente.Text = "";
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
               
                richTextBoxClientes.Text += lista.Dequeue().ToString () + ": ";
                
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {

        }
    }
}
