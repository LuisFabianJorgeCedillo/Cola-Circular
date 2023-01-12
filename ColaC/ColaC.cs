using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaC
{
    internal class ColaC : Cola1
    {
        public ColaC()
        {
            primero = 1;
            ultimo = -1;
        }

        public bool Vacia1()
        {
            if (ultimo == -1 & primero == -1) return true;
            else return false;
        }

        public bool Llena1()
        {
            if ((primero == 0 & ultimo == MaxCola - 1) | ultimo + 1 == primero) return true;
            else return false;
        }


        public void Insertar1(string insert)
        {
            if (Llena1())
            {
                MessageBox.Show("Error: La colaC de elementos esta LLENA");
            }
            else
            {
                if (ultimo == MaxCola - 1) ultimo = 0;
                else
                {
                    ultimo++;
                    coladatos[ultimo] = insert;
                }
                if (primero == -1) primero = 0;
            }
        }


        public string Eliminar1()
        {
            string valor = " ";
            if (Vacia1())
            {
                MessageBox.Show("Error: La colaC de elementos esta VACIA");
            }
            else
            {
                valor = coladatos[primero];
                if (primero == ultimo)
                {
                    primero = -1;
                    ultimo = -1;
                }
                else
                {
                    if (primero == MaxCola - 1) primero = 0;
                    else primero++;
                }
            }
            return valor;
        }





    }
}
