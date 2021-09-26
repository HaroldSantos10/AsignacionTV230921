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
      
            //llamada al método para llenar el Dgb
            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //bool pr = allTbxFull();
            //if (pr != true)
            //{
            //    MessageBox.Show("Verifique que todos los campos han sido llenados correctamente");
            //}
            //else
            //{
            fillDatagridView();

            clearTbx();
            //}


        }
        // metodo para llenar el dgb
        private void fillDatagridView()
        {
            Televisor televisor = new Televisor(Convert.ToInt32(tbxId.Text), tbxModelo.Text, tbxMarca.Text, Convert.ToInt32(tbxTama.Text),
                           tbxResolu.Text, Convert.ToInt32(tbxYear.Text), tbxColor.Text);

            //llenar DataGridView
            //agregar columnas
            dgbTvData.Columns.Add("tbxId.Text", "ID TV");
            dgbTvData.Columns.Add("tbxModelo.Text", "MODELO");
            dgbTvData.Columns.Add("tbxMarca.Text", "MARCA");
            dgbTvData.Columns.Add("tbxTama.Text", "TAMAÑO(pulgadas)");
            dgbTvData.Columns.Add("tbxResolu.Text", "RESOLUCIÓN");
            dgbTvData.Columns.Add("tbxYear.Text", "AÑO");
            dgbTvData.Columns.Add("tbxColor.Text", "COLOR");

            //agregar filas al DataGridView

            dgbTvData.Rows.Add(
                tbxId.Text,
                tbxModelo.Text,
                tbxMarca.Text,
                tbxTama.Text,
                tbxResolu.Text,
                tbxYear.Text,
                tbxColor.Text
                );

        }

        private void clearTbx()//limpia los textBox
        {
            tbxId.Clear();
            tbxModelo.Clear();
            tbxMarca.Clear();
            tbxTama.Clear();
            tbxResolu.Clear();
            tbxYear.Clear();
            tbxColor.Clear();
        }

        

        //intentaba validar que todos los texBox estuvieran llenos
        //aún no lo he logrado pero voy a seguir intentando
        private  bool allTbxFull()
        {
            bool probar = true;

            for (int i= 0; i<7; i++)
            {
                switch (i)
                {
                    case 0:
                        probar = evaluarllenado(tbxId.Text);
                        return probar;
                    case 1:
                        probar = evaluarllenado(tbxModelo.Text);
                        return probar;
                    case 2:
                        probar = evaluarllenado(tbxMarca.Text);
                        return probar;
                    case 3:
                        probar = evaluarllenado(tbxTama.Text);
                        return probar;
                    case 4:
                        probar = evaluarllenado(tbxResolu.Text);
                        return probar;
                    case 5:
                        probar = evaluarllenado(tbxYear.Text);
                        return probar;
                    case 6:
                        probar = evaluarllenado(tbxColor.Text);
                        return probar;
                    default:
                        return false;
                }


            }

            return probar;
        }
        private  bool evaluarllenado(string texto )
        {
            bool llen = false;
            if (texto != null)
            {
                return llen = true;
            }
            else
            {
                return llen = false;
            }

        }

       
    }

}

