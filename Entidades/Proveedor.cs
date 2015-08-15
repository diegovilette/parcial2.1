using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Proveedor : iEntidad
    {
        public int Id
        { get; set; }

        public Proveedor()
        {
            telefonos = new List<Telefono>();
        }

        String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        List<Telefono> telefonos;

        public List<Telefono> Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        String cuit;

        public String Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
    }
}
