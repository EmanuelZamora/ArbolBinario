using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolesB
{
    public partial class Form1 : Form
    {
        ClsArbolBinario ArbolB = new ClsArbolBinario();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            String nombre =  txtNombre.Text;
            String prog = txtProgramador.Text;
            int porc = Convert.ToInt32(txtPorcentaje.Text);
            int duracion = Convert.ToInt32(txtDuracion.Text);
            
            ArbolB.AddDato(new ClsTareasDesa(nombre, duracion, porc, prog), nombre);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {


            if (!ArbolB.ArbolVacio()) ListarTareasInorden(ArbolB.getRaiz());

        }

        private void ListarTareasInorden(ClsNodo Raiz)
        {
            ClsTareasDesa Tarea;
            if (Raiz != null)
            {
                ListarTareasInorden(Raiz.subArbolIzq());
                Tarea = (ClsTareasDesa) Raiz.getDato();
                lstDatos.Items.Add(Tarea.getNombreTarea());
                ListarTareasInorden(Raiz.subArbolDer());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String nombre_tarea =  txtNombre.Text;
            ClsTareasDesa Tarea;

            Tarea = (ClsTareasDesa)ArbolB.BuscarDato(nombre_tarea);

            if (Tarea != null)
            {

                txtDuracion.Text = Convert.ToString(Tarea.getDuracion());
                txtPorcentaje.Text = Convert.ToString(Tarea.getAvance());
                txtProgramador.Text = Tarea.getProgramador();
            }
            else
            {
                txtDuracion.Text = "";
                txtPorcentaje.Text = "";
                txtProgramador.Text = "";
            }

        }
    }
}
