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
    public class ManejaDetalleVenta : iMetodosBasicos
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaDetalleVenta()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        public void Alta(iEntidad entidad)
        {
            DetalleVenta dve = (DetalleVenta)entidad;
            try
            {
                dve.Id = manejador.Ejecutar("Insert into DetalleVentas (IdVenta, IdProducto, PrecioCosto,CoefUtil,Cantidad) values ('" + dve.Venta.Id + "','" + dve.Producto.Id + "','" + dve.PrecioCosto + "','" + dve.CoefUrtil + "','" + dve.Cantidad + "');SELECT @@identity;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Baja(iEntidad entidad)
        {
            DetalleVenta dve = (DetalleVenta)entidad;
            try
            {
                manejador.Ejecutar("DELETE FROM DetalleVentas WHERE `IdDetalleVenta`='" + dve.Id + "';");
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void Modificacion(iEntidad entidad)
        {
            DetalleVenta dve = (DetalleVenta)entidad;
            try
            {                                                                                        
                manejador.Ejecutar("UPDATE `DetalleVentas` SET `IdVenta`='" + dve.Venta.Id + "', `IdProducto`='" + dve.Producto.Id + "', `PrecioCosto`='" + dve.PrecioCosto + "', `CoefUtil`='" + dve.CoefUrtil + "', `Cantidad`='" + dve.Cantidad + "' WHERE `IdDetalleVenta`='" + dve.Id + "';");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from DetalleVentas;");
            ManejaVenta manejaVenta = new ManejaVenta();
            ManejaProducto manejaProducto = new ManejaProducto();
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                DetalleVenta auxEva = new DetalleVenta();
                auxEva.Id = Convert.ToInt32(i["IdDetalleVenta"]);
                auxEva.Venta = (Venta)manejaVenta.buscaPorId(Convert.ToInt32(i["IdVenta"].ToString()));
                auxEva.Producto = (Producto)manejaProducto.buscaPorId(Convert.ToInt32(i["IdProducto"].ToString()));
                auxEva.PrecioCosto = (float)i["PrecioCosto"];
                auxEva.CoefUrtil = (float)i["CoefUtil"];
                auxEva.Cantidad = Convert.ToInt32(i["Cantidad"]);
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow i = manejador.ConsultarId("Select * from DetalleVentas WHERE `IdDetalleVenta`='" + id + "';");
            ManejaVenta manejaVenta = new ManejaVenta();
            ManejaProducto manejaProducto = new ManejaProducto();
            DetalleVenta auxEva = new DetalleVenta();
            auxEva.Id = Convert.ToInt32(i["IdDetalleVenta"]);
            auxEva.Venta = (Venta)manejaVenta.buscaPorId(Convert.ToInt32(i["IdVenta"].ToString()));
            auxEva.Producto = (Producto)manejaProducto.buscaPorId(Convert.ToInt32(i["IdProducto"].ToString()));
            auxEva.PrecioCosto = (float)i["PrecioCosto"];
            auxEva.CoefUrtil = (float)i["CoefUtil"];
            auxEva.Cantidad = Convert.ToInt32(i["Cantidad"]);
            return auxEva;
        }
    }
}
