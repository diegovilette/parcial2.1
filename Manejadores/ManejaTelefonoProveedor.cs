
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
    public class ManejaTelefonoProveedor
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaTelefonoProveedor()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        /// <summary>
        /// Primer parametro es un telefono y el segunto es un proveedor.
        /// </summary>
        /// <param name="Telefono"></param>
        /// <param name="Cliente"></param>
        public void Alta(iEntidad telefono, iEntidad proveedor)
        {
            Telefono tel = (Telefono)telefono;
            Proveedor pro = (Proveedor)proveedor; 
            try
            {
                manejador.Ejecutar("INSERT INTO TelefonoProveedor (IdTelefono, IdProveedor) VALUES ('" + tel.Id + "','" + pro.Id + "');");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// El primer parametro es un telefono y el segundo es un proveedor.
        /// </summary>
        /// <param name="contacto"></param>
        /// <param name="evento"></param>
        public void Baja(iEntidad telefono, iEntidad proveedor)
        {
            Telefono tel = (Telefono)telefono;
            Proveedor pro = (Proveedor)proveedor; 
            try
            {
                manejador.Ejecutar("DELETE FROM TelefonoProveedor WHERE `IdTelefono`=" + tel.Id + " and `IdProveedor`=" + pro.Id + ";"); 
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
