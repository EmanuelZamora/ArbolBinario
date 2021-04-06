using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesB
{
    class ClsTareasDesa
    {
        private String NombreTarea;
        private int duracion;
        private int avance;
        private String ProgAsig;

        public ClsTareasDesa(string nombreTarea, int duracion, int avance, string progAsig)
        {
            NombreTarea = nombreTarea;
            this.duracion = duracion;
            this.avance = avance;
            ProgAsig = progAsig;
        }

        public string getNombreTarea(){ return NombreTarea; }
        public int getDuracion() { return duracion; }
        public int getAvance() { return avance; }
        public string getProgramador() { return ProgAsig; }
    }
}
