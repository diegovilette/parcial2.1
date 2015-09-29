using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Categoria : iEntidad
    {
        public int Id
        { get; set; }

        int descripcion;
	Object aguantaaaasssme;
        public int Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }
}
