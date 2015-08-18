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
    public class ManejaCliente : iMetodosBasicos
    {
         //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaCliente()
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
            Cliente cli = (Cliente)entidad;
            ManejaTelefonoCliente manejaTelCli = new ManejaTelefonoCliente();
            try
            {
                manejador.Ejecutar("start transaction;");
                cli.Id = manejador.Ejecutar("Insert into Clientes (Nombre, Apellido, Domicilio,FechaAlta,Estado, Email, Cuit,TIPO) values ('" + cli.Nombre + "','" + cli.Apellido + "','" + cli.Domicilio + "','" + cli.FechaAlta.Year + "-" + cli.FechaAlta.Month + "-" + cli.FechaAlta.Day + "'," + cli.Estado + ",'"+  cli.Email + "', '"+ cli.Cuit+"',"+cli.Tipo+");SELECT @@identity;");
                foreach(Telefono i in cli.Telefonos)
                {
                    if(i!=null)
                        manejaTelCli.Alta(i, cli);
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
            Cliente cli = (Cliente)entidad;
            ManejaTelefonoCliente manejaTel = new ManejaTelefonoCliente();
            try
            {
                manejador.Ejecutar("UPDATE Clientes set Estado = 0 WHERE `IdCliente`='" + cli.Id + "';");
                manejador.Ejecutar("DELETE FROM `telefonocliente` WHERE `IdCliente`='" + cli.Id + "';");
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
            ManejaTelefonoCliente manejaTelCli = new ManejaTelefonoCliente();
            Cliente cli = (Cliente)entidad;
            try
            {
                manejador.Ejecutar("start transaction;");
                manejador.Ejecutar("UPDATE `Clientes` SET `Nombre`='" + cli.Nombre + "', `Apellido`='" + cli.Apellido + "', `Domicilio`='" + cli.Domicilio + "', `FechaAlta`='" + cli.FechaAlta.Year + "-" + cli.FechaAlta.Month + "-" + cli.FechaAlta.Day + "', `Estado`=" + cli.Estado + ", `Email`='" + cli.Email + "' , `Cuit`='" + cli.Cuit + "' , `TIPO`='" + cli.Tipo + "' WHERE `IdCliente`='" + cli.Id + "';");
                manejador.Ejecutar("DELETE FROM TelefonoCliente WHERE `IdCliente`='" + cli.Id + "';");
                if (cli.Telefonos.Count > 0)                {
                      
                    manejaTelCli.Alta(cli.Telefonos[0], cli);
                }
                manejador.Ejecutar("commit;");    
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Clientes;");
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                Cliente auxEva = new Cliente();
                auxEva.Id = Convert.ToInt32(i["IdCliente"]);
                auxEva.Nombre = i["Nombre"].ToString();
                auxEva.Apellido = i["Apellido"].ToString();
                auxEva.Domicilio = i["Domicilio"].ToString();
                auxEva.FechaAlta = Convert.ToDateTime(i["FechaAlta"]);
                auxEva.Estado = Convert.ToBoolean(i["Estado"]);
                auxEva.Cuit = i["Cuit"].ToString();
                auxEva.Email = i["Email"].ToString();
                auxEva.Tipo = Convert.ToInt32(i["TIPO"]);
                llenaCliente(auxEva);
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow aux = manejador.ConsultarId("Select * from Clientes WHERE `IdCliente`='" + id + "';");
            Cliente res = new Cliente();
            res.Id = Convert.ToInt32(aux["IdCliente"]);
            res.Nombre = aux["Nombre"].ToString();
            res.Apellido = aux["Apellido"].ToString();
            res.Domicilio = aux["Domicilio"].ToString();
            res.FechaAlta = Convert.ToDateTime(aux["FechaAlta"]);
            res.Estado = Convert.ToBoolean(aux["Estado"]);
            res.Cuit = aux["Cuit"].ToString();
            res.Email = aux["Email"].ToString();
            res.Tipo = Convert.ToInt32(aux["TIPO"]);
            llenaCliente(res);
            return res;
        }

        public Cliente buscaPorCuit(string cuit)
        {
            DataRow aux = manejador.ConsultarId("Select * from Clientes WHERE `Cuit`='" + cuit + "';");
            if (aux != null)
            {
                Cliente res = new Cliente();
                res.Id = Convert.ToInt32(aux["IdCliente"]);
                res.Nombre = aux["Nombre"].ToString();
                res.Apellido = aux["Apellido"].ToString();
                res.Domicilio = aux["Domicilio"].ToString();
                res.FechaAlta = Convert.ToDateTime(aux["FechaAlta"]);
                res.Estado = Convert.ToBoolean(aux["Estado"]);
                res.Cuit = aux["Cuit"].ToString();
                res.Email = aux["Email"].ToString();
                res.Tipo = Convert.ToInt32(aux["TIPO"]);
                llenaCliente(res);
                return res;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Recibe un cliente  lo llena con los telefono que le corresponden.
        /// </summary>
        /// <param name="entidad"></param>
        public void llenaCliente(iEntidad entidad)
        {
            String sql = "select Telefonos.IdTelefono, Numero"
                        + " from Telefonos,TelefonoCliente"
                        + " where Telefonos.IdTelefono = TelefonoCliente.IdTelefono"
                        + " and IdCliente = " + ((Cliente)entidad).Id + ";";
            DataTable aux = manejador.Consultar(sql);
            List<Telefono> telefonos = ((Cliente)entidad).Telefonos;
            if (telefonos == null)
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
