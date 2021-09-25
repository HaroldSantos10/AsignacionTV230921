using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignacionTV230921
{
    class Televisor
    {
        //definir miembros
        //propiedades
        private int _tvId;//numero de serie del televisor
        private string _tvModelo;
        private string _tvMarca;

        //propiedades auto implementadas
        public int _tvTamaño { get; set; }
        public string _tvResolucion { get; set; }
        public int _tvAño { get; set; }
        public string _tvColor { get; set; }


        //Metodo constructor
        //Es un constructor vacío cuando no se introducen argumentos en el parentesis
        public Televisor(int tvId, string tvModelo, string tvMarca, int tvTamaño, string tvResolucion, int tvAño, string tvColor)
        {
            _tvId = tvId;
            _tvModelo = tvModelo;
            _tvMarca = tvMarca;
            _tvTamaño = tvTamaño;
            _tvResolucion = tvResolucion;
            _tvAño = tvAño;
            _tvColor = tvColor;
        }





        //Metodos de propiedades
        //get-- obtiene el valor almacenado en la propiedad
        //set-- asignar
        public void setTvId(int tvId)
        {
            _tvId = tvId;
        }
        public int getTvId()
        {
            return _tvId;
        }

        public void setTvModelo(string tvModelo)
        {
            _tvModelo = tvModelo;
        }
        public string getTvModelo()
        {
            return _tvModelo;
        }

        public void setTvMarca(string tvMarca)
        {
            _tvMarca = tvMarca;
        }
        public string getTvMarca()
        {
            return _tvMarca;
        }



    }
}
