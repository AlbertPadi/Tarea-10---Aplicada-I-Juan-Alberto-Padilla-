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
    public partial class AgendaTelefonica : Form
    {
        ArrayList datos;
        string nombre, telefono;
        public AgendaTelefonica()
        {
            InitializeComponent();
            datos = new ArrayList();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            foreach (string item in datos)
            {
                richTextBoxDatos.Text += item.ToString()+": ";
            }
        }

        private void AgendaTelefonica_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
            telefono = textBoxNoTelefono.Text;

            datos.Add(nombre);
            datos.Add(telefono);

            textBoxNombre.Text = "";
            textBoxNoTelefono.Text = "";
        }
    }
}
