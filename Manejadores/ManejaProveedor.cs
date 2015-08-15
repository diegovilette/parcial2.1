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
    public class ManejaProveedor : iMetodosBasicos
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaProveedor()
        {
            manejador = new bdMetodos();
        }

        //Metodos

        /// <summary>
        /// Includia la relacion a telefonos.
        /// </summary>
        /// <param name="entidad"></param>
        public void Alta(iEntidad entidad)
        {
            Proveedor pro = (Proveedor)entidad;
            ManejaTelefonoProveedor manejaTel = new ManejaTelefonoProveedor();
            try
            {
                manejador.Ejecutar("start transaction;");
                pro.Id = manejador.Ejecutar("Insert into Proveedores (Nombre, Estado, Cuit) values ('" + pro.Nombre + "'," + 1 + ", '" + pro.Cuit + "');SELECT @@identity;");
                foreach (Telefono i in pro.Telefonos)
                {
                    if (i != null)
                        manejaTel.Alta(i, pro);
                }
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Includia la relacion a telefonos.
        /// </summary>
        /// <param name="entidad"></param>
        public void Baja(iEntidad entidad)
        {
            Proveedor pro = (Proveedor)entidad;
            ManejaTelefonoProveedor manejaTel = new ManejaTelefonoProveedor();
            try
            {
                manejador.Ejecutar("DELETE Proveedores SET Estado=0 WHERE `IdProveedor`='" + pro.Id + "';");
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// La modificacion de los telefono se debe hacer manualmente fuera de este metodo.
        /// </summary>
        /// <param name="entidad"></param>
        public void Modificacion(iEntidad entidad)
        {
            ManejaTelefonoProveedor manejaTel = new ManejaTelefonoProveedor();
            Proveedor pro = (Proveedor)entidad;
            try
            {
                manejador.Ejecutar("start transaction;");
                manejador.Ejecutar("UPDATE `Proveedores` SET `Nombre`='" + pro.Nombre + "', `Estado`=" + pro.Estado + ", `Cuit`='" + pro.Cuit + "' WHERE `IdProveedor`='" + pro.Id + "';");
                manejador.Ejecutar("DELETE FROM `telefonoproveedor` WHERE `IdProveedor`='" + pro.Id + "';");
                if (pro.Telefonos.Count > 1)
                {
                    foreach(Telefono tel in pro.Telefonos)
                    {
                        manejaTel.Alta(tel, pro);
                    }
                }
                else
                    if (pro.Telefonos.Count > 0)
                        manejaTel.Alta(pro.Telefonos[0], pro);
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Proveedores;");
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                Proveedor auxEva = new Proveedor();
                auxEva.Id = Convert.ToInt32(i["IdProveedor"]);
                auxEva.Nombre = i["Nombre"].ToString();
                auxEva.Cuit = i["Cuit"].ToString();
                auxEva.Estado = Convert.ToBoolean(i["Estado"].ToString());
                llenaProveedor(auxEva);
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow i = manejador.ConsultarId("Select * from Proveedores WHERE `IdProveedor`='" + id + "';");
            Proveedor auxEva = new Proveedor();
            auxEva.Id = Convert.ToInt32(i["IdProveedor"]);
            auxEva.Nombre = i["Nombre"].ToString();
            auxEva.Cuit = i["Cuit"].ToString();
            auxEva.Estado = Convert.ToBoolean(i["Estado"]);
            llenaProveedor(auxEva);
            return auxEva;
        }



        public void llenaProveedor(iEntidad entidad)
        {
            String sql = "select Telefonos.IdTelefono, Numero"
                        + " from Telefonos,TelefonoProveedor"
                        + " where Telefonos.IdTelefono = TelefonoProveedor.IdTelefono"
                        + " and IdProveedor = " + ((Proveedor)entidad).Id + ";";
            DataTable aux = manejador.Consultar(sql);
            List<Telefono> telefonos = ((Proveedor)entidad).Telefonos;
            if(telefonos==null)
            {
                telefonos = new List<Telefono>();
            }
            foreach (DataRow i in aux.Rows)
            {
                Telefono auxEva = new Telefono();
                auxEva.Id = Convert.ToInt32(i["IdTelefono"]);
                auxEva.Numero = Convert.ToInt32(i["Numero"]);
                
                telefonos.Add(auxEva);
            }
        }
    }
}
