using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaC
{
    public partial class Form1 : Form
    {
         Cola1 cc = new Cola1 ();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = txtnumero.Text;
            if (cc.Llena())
            {
                MessageBox.Show("La  cola esta llena");
            }
            else
            {
                cc.Insertar(x);
                listBox1.Items.Add(x);
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x;
            if (cc.Vacia())
                MessageBox.Show("Error: la cola de elemento esta vacio");
            else
            {
                x = cc.Eliminar();
                listBox1.Items.Remove(x);
            }
        }

       
    }
}
