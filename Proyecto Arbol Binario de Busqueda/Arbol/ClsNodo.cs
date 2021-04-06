using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class ClsNodo
    {
        private Object dato;
        private ClsNodo Nizq;
        private ClsNodo Nder;
        private double Valor;

        public ClsNodo(Object dato, String x)
        {
            this.dato = dato;
            Nizq = null;
            Nder = null;
            Valor = val(x);
        }

        private int val(String cadena)
        {
            char c = ' ';
            int suma = 0;

            for (int i = 0; i < cadena.Length; i++)
            {

                try
                {
                    c = cadena[i];
                    Console.WriteLine(c);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erroneo" + e);
                }
                suma += Convert.ToInt32(c);
            }

            return suma;
        }

        public ClsNodo(Object dato)
        {
            this.dato = dato;
            Nder = null;
        }


        public ClsNodo subArbolIzq() { return Nizq; }
        public ClsNodo subArbolDer() { return Nder; }

        public double getValNodo() { return Valor; }
        public Object getDato() { return dato; }

        public void setRamaIzq(ClsNodo RamaIzq) { Nizq = RamaIzq; }
        public void setRamaDer(ClsNodo RamaDer) { Nder = RamaDer; }

        public string visitar()
        {
            return dato.ToString();
        }

    }

    
}
