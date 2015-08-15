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
    public class ManejaTelefono : iMetodosBasicos
    {
        //Atributos
        bdMetodos manejador;        

        //Constructor
        public ManejaTelefono()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        public void Alta(iEntidad entidad)
        {
            Telefono cat = (Telefono)entidad;
            try
            {
                cat.Id = manejador.Ejecutar("Insert into Telefonos (Numero) values ('" + cat.Numero + "');SELECT @@identity;");
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Baja(iEntidad entidad)
        {
            Telefono cat = (Telefono)entidad;
            try
            {
                manejador.Ejecutar("start transaction;");
                manejador.Ejecutar("DELETE FROM TelefonoProveedor WHERE `IdTelefono`='" + cat.Id + "';");
                manejador.Ejecutar("DELETE FROM TelefonoCliente WHERE `IdTelefono`='" + cat.Id + "';");
                manejador.Ejecutar("DELETE FROM Telefonos WHERE `IdTelefono`='" + cat.Id + "';");
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Modificacion(iEntidad entidad)
        {
            Telefono cat = (Telefono)entidad;
            try
            {
                manejador.Ejecutar("start transaction;");
                manejador.Ejecutar("UPDATE `Telefonos` SET `Numero`='" + cat.Numero + "' WHERE `IdTelefono`='" + cat.Id + "';SELECT @@identity;");
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Telefonos;");
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                Telefono auxEva = new Telefono();
                auxEva.Id = Convert.ToInt32(i["IdTelefono"]);
                auxEva.Numero = Convert.ToInt32(i["Numero"]);                
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow aux = manejador.ConsultarId("Select * from Telefonos WHERE `IdTelefono`='" + id + "';");
            Telefono res = new Telefono();
            res.Id = Convert.ToInt32(aux["IdTelefono"]);
            res.Numero = Convert.ToInt32(aux["Numero"]);
            return res;
        }
    }
}
