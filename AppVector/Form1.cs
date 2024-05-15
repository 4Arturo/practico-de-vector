using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppVector
{
    public partial class frmvector : Form
    {
        // creando una instancia de mi clase Vector
        clsVector v = new clsVector();

        public frmvector()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbResultado.Text = "[";
            for (int i = 0; i < v.longitud(); i++) {
                lbResultado.Text = lbResultado.Text + v.obtenervalor(i) + " , ";
            }
            lbResultado.Text = lbResultado.Text + "]";
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adiccionar(x);
            mostrarVector();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adiccionar(x);
            mostrarVector();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }

        private void cantDeParesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantPares();
            MessageBox.Show("Cant. de Elementos pares: " + c.ToString());
        }

        private void ordenarMenorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorAmayor();
            mostrarVector();
        }

        private void eliminarElementPosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtvalor.Text);
            v.EliminarElementoPos(p);
            mostrarVector();
        }

        private void cantDeImparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.CantImpares();
            MessageBox.Show("Cant. de Elementos Impares: " + c.ToString());
        }

        private void cantDeCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int s = v.ContarCapicua();
            MessageBox.Show("Cant. de Elementos Capicúa: " + s.ToString());
        }

        private void cantDePrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = v.ContarPrimos();
            MessageBox.Show("Cant. de Numeros Primos: " + a.ToString());
        }










   




    }
}
