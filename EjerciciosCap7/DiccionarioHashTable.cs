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
    public partial class DiccionarioHashTable : Form
    {
        Hashtable palabra;
        string palabras = "";
        public DiccionarioHashTable()
        {
            InitializeComponent();
            palabra = new Hashtable();
        }

        private void DiccionarioHashTable_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            
            palabra.Add(textBoxPalabra.Text, richTextBoxSignificado.Text);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry var in palabra)
            {
                listBoxSignificado.Items.Add(var.Key.ToString()+": "+ var.Value.ToString());
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxPalabra.Text = "";
            richTextBoxSignificado.Text = "";
        }
    }
}
