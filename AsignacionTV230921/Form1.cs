using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionTV230921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MEDIANTE METODOS DE PROPIEDAD
            //instancia de la clase Televisor
            Televisor televisor = new Televisor();
            //creamos un objeto televisor
            televisor.setTvId(1);
            televisor.setTvMarca("LG");
            televisor.setTvModelo("42LA6200");

            //MEDIANTE METODO DE PROPIEDAD AUTOIMPLEMENTADA
            //SET
            televisor._tvAño = 2019;
            televisor._tvTamaño = 50;
            televisor._tvResolucion = "5K";
            televisor._tvColor = "Negro";
            


        }
    }
}
