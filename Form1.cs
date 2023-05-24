using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseObjeto;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        List<Gasto> ListaGastos = new List<Gasto>();
        int presupuesto=0;
        public Form1()
        {
           
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //Espacio para agregar el texto 
            Gasto NuevoGasto = new Gasto();
            //textbox Agregar Categoria
            //Llamar el array para seleccionar la categoria
            NuevoGasto.Categoria = txtCategoria.Text.TrimEnd();

            //textbox Agregar Fecha
            NuevoGasto.Fecha = txtFecha.Text.TrimEnd();

            //textbox Agregar Descripcion
            NuevoGasto.Descripcion = txtDescripcion.Text.TrimEnd();

            //textbox Agregar Monto
            NuevoGasto.Monto = txtMonto.Text.TrimEnd();

            //Este dato siempre se incrementará sin tener que ecceder a dicho dato
            //El indice comienza desde cero
            NuevoGasto.ID = NuevoGasto.ID;

           presupuesto= NuevoGasto.Monto


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int UserId = txtMonto.Text.TrimEnd(); 

           //Boton eliminar
            //A continuación se va a desplegar todos los datos que se encuentran almacenados, para que de esta forma,se generen los datos que se desean cambiar
            //Se va a utilizar una lisview para mostrar los datos
            //Iterador será la variable del mismo tipo que el opbjeto, el cual nos va a servir para igualar los datos 
            foreach(Gasto iterador  in ListaGastos)
            {
                //Se resta un dato porque el conteo de objetos comienza en 0
                if(iterador.ID == UserId-1)
                {
                    //Al  final se remueve el dato que tenga relacion con el dato buscado
                    ListaGastos.RemoveAt(iterador.ID);
                }
              


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Agregar presupuesto 
        }
    }
}