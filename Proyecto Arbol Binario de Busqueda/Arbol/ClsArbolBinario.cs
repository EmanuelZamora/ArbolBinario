using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class ClsArbolBinario
    {
        protected ClsNodo Raiz;

        public ClsArbolBinario()
        {
            Raiz = null;
        }

        public bool ArbolVacio() 
        {
            if (Raiz == null) return true;
            else return false;
        }

        public ClsNodo getRaiz() { return Raiz; }

        public void AddDato(Object NodoDato, string cadena) 
        {
            ClsNodo Arb_Aux = null;
            ClsNodo Arb_Padre = null;
            ClsNodo NuevoNodo = new ClsNodo(NodoDato, cadena);

            if (ArbolVacio())
                Raiz = new ClsNodo(NodoDato, cadena) ;
            else 
            {
                Arb_Aux = Raiz;
                while (Arb_Aux != null)
                {
                    if(Arb_Aux.getValNodo() > NuevoNodo.getValNodo()) 
                    {
                        Arb_Padre = Arb_Aux;
                        Arb_Aux = Arb_Aux.subArbolIzq();
                    }else if (Arb_Aux.getValNodo() < NuevoNodo.getValNodo())
                    {
                        Arb_Padre = Arb_Aux;
                        Arb_Aux = Arb_Aux.subArbolDer();
                    }

                }

                if (Arb_Padre.getValNodo() > NuevoNodo.getValNodo())
                {
                    Arb_Padre.setRamaIzq(NuevoNodo);
                }
                if (Arb_Padre.getValNodo() < NuevoNodo.getValNodo())
                {
                     Arb_Padre.setRamaDer(NuevoNodo);
                }
            }
        }


        public object BuscarDato(string cadena) 
        {
            ClsNodo Arb_Aux = null;
            ClsNodo Arb_Padre = null;
            int ValCadena = ValorCadena(cadena);

            if (ArbolVacio())
                return null;
            else
            {
                Arb_Aux = Raiz;
                while (Arb_Aux.getValNodo() != ValCadena)
                {
                    if (Arb_Aux.getValNodo() > ValCadena)
                    {
                        Arb_Padre = Arb_Aux;
                        Arb_Aux = Arb_Aux.subArbolIzq();
                    }
                    else if (Arb_Aux.getValNodo() < ValCadena)
                    {
                        Arb_Padre = Arb_Aux;
                        Arb_Aux = Arb_Aux.subArbolDer();
                    }

                }
                return Arb_Aux.getDato();

            }
        }

        private int ValorCadena(string cadena)
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
                    Console.WriteLine("No se pudo" + e);
                }
                suma += Convert.ToInt32(c);
            }

            return suma;
        }
    }
}
