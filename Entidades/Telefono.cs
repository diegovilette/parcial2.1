using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Telefono : iEntidad
    {
        public int Id
        { get; set; }

        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
