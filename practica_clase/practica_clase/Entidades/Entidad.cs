using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_clase.Entidades
{
    class Entidad
    {
        private int dato;

        public Entidad(int dato)
        {
            this.Dato = dato;
        }

        public int Dato { get => dato; set => dato = value; }
    }
}
