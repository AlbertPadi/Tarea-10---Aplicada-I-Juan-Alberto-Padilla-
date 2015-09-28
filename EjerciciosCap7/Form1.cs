using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosCap7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiccionarioHashTable dicc = new DiccionarioHashTable();
            dicc.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PromedioMinMax Pmm = new PromedioMinMax();
            Pmm.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simulacion s = new Simulacion();
            s.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gastosDelMes gm = new gastosDelMes();
            gm.Show();
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgendaTelefonica at = new AgendaTelefonica();
            at.Show();
        }
    }
}
