using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Entidades;
using System.Data;

namespace Manejadores
{
    public class ManejaTelefonoCliente
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaTelefonoCliente()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        /// <summary>
        /// Primer parametro es un telefono y el segunto es un cliente.
        /// </summary>
        /// <param name="Telefono"></param>
        /// <param name="Cliente"></param>
        public void Alta(iEntidad telefono, iEntidad cliente)
        {
            Telefono tel = (Telefono)telefono;
            Cliente cli = (Cliente)cliente; 
            try
            {
               manejador.Ejecutar("INSERT INTO TelefonoCliente (IdTelefono, IdCliente) VALUES ('" + tel.Id + "','" + cli.Id + "');SELECT @@identity;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// El primer parametro es un telefono y el segundo es un cliente.
        /// </summary>
        /// <param name="contacto"></param>
        /// <param name="evento"></param>
        public void Baja(iEntidad telefono, iEntidad cliente)
        {
            Telefono tel = (Telefono)telefono;
            Cliente cli = (Cliente)cliente;
            try
            {
                manejador.Ejecutar("DELETE FROM TelefonoCliente WHERE `IdTelefono`='" + tel.Id + "and `IdCliente`='" + cli.Id + "';");    
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
