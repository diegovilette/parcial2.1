using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Cliente : iEntidad
    {
        public int Id
        { get; set; }

        public Cliente()
        {
            telefonos = new List<Telefono>();
        }

        List<Telefono> telefonos;

        public List<Telefono> Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        String apellido;

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        String domicilio;

        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        DateTime fechaAlta;

        public DateTime FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
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
