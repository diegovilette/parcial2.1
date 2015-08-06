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
    public class ManejaFactura : iMetodosBasicos
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaFactura()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        public void Alta(iEntidad entidad)
        {
            Factura fac = (Factura)entidad;
            try
            {
                fac.Id = manejador.Ejecutar("Insert into Facturas (IdVenta, IdCliente, IVA) values ('" + fac.Venta.Id + "','" + fac.Cliente.Id + "','" + fac.Iva + "');SELECT @@identity;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Baja(iEntidad entidad)
        {
            Factura fac = (Factura)entidad;
            try
            {
                manejador.Ejecutar("DELETE FROM Facturas WHERE `IdFactura`='" + fac.Id + "';");
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Modificacion(iEntidad entidad)
        {
            Factura fac = (Factura)entidad;
            try
            {
                manejador.Ejecutar("UPDATE .`Facturas` SET `IdVenta`='" + fac.Venta.Id + "', `IdCliente`='" + fac.Cliente.Id + "', `IVA`='" + fac.Iva + "' WHERE `IdFactura`='" + fac.Id + "';");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Facturas;");
            ManejaCliente manejaCliente = new ManejaCliente();
            ManejaVenta manejaVenta = new ManejaVenta();
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                Factura auxEva = new Factura();
                auxEva.Id = Convert.ToInt32(i["IdContacto"]);
                auxEva.Venta = (Venta)manejaVenta.buscaPorId(Convert.ToInt32(i["IdVenta"].ToString()));
                auxEva.Cliente = (Cliente)manejaCliente.buscaPorId(Convert.ToInt32(i["IdCliente"].ToString()));
                auxEva.Iva = (float)i["IVA"];
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow i = manejador.ConsultarId("Select * from Facturas WHERE `IdFactura`='" + id + "';");
            ManejaCliente manejaCliente = new ManejaCliente();
            ManejaVenta manejaVenta = new ManejaVenta();
            Factura auxEva = new Factura();
            auxEva.Id = Convert.ToInt32(i["IdContacto"]);
            auxEva.Venta = (Venta)manejaVenta.buscaPorId(Convert.ToInt32(i["IdVenta"].ToString()));
            auxEva.Cliente = (Cliente)manejaCliente.buscaPorId(Convert.ToInt32(i["IdCliente"].ToString()));
            auxEva.Iva = (float)i["IVA"];
            return auxEva;
        }
    }
}
