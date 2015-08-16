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
    public class ManejaVenta : iMetodosBasicos
    {
        IbdMetodos conec;

        public ManejaVenta()
        {
            conec = new bdMetodos();
        }
        public List<iEntidad> pasteTo(DataTable dt)
        {
            List<iEntidad> res = new List<iEntidad>();

            foreach (DataRow dr in dt.Rows)
            {
                Venta aux = new Venta();
                aux.Fecha = (DateTime)dr["Fecha"];
                aux.Id = (int)dr["IdVenta"];
                aux.Estado = Convert.ToBoolean(dr["Estado"]);
                res.Add(aux);
            }

            return res;
        }

        public string cambia(float coef)
        {
            string res = coef.ToString();
            string resposta = string.Empty;
            foreach (char x in res)
            {
                if (x == ',')
                {
                    resposta += ".";
                }
                else
                {
                    resposta += x;
                }
            }
            return resposta;
        }

        public void Alta(iEntidad entidad)
        {
            
            Venta te = (Venta)entidad;
            string query = "INSERT INTO Ventas(Fecha,Total,sucursal) VALUES('" + te.Fecha + "','" +  cambia(te.Total) + "','"+Guid.NewGuid().ToString()+"');SELECT @@identity;";
            te.Id = conec.Ejecutar(query);
        }

        public void Baja(iEntidad entidad)
        {
            Venta te = (Venta)entidad;
            string query = "UPDATE Ventas set Estado = 0 WHERE IdVenta=" + te.Id;
            int i = conec.Ejecutar(query);
        }

        public void Modificacion(iEntidad entidad)
        {
            Venta te = (Venta)entidad;
            string query = "UPDATE Ventas SET Fecha='" + te.Fecha.Date.ToString() + "',Total=" + te.Total + ", Estado = "+te.Estado+" WHERE IdVenta=" + te.Id;
            int i = conec.Ejecutar(query);
        }

        public List<iEntidad> Todo()
        {
            string consulta = "SELECT * FROM Ventas;";
            return pasteTo(conec.Consultar(consulta));
        }

        public iEntidad buscaPorId(int id)
        {
            string consulta = "SELECT * FROM Ventas WHERE IdVenta=" + id.ToString() + ";";
            return pasteTo(conec.Consultar(consulta))[0];
        }

        public bool Alta(iEntidad venta, List<Producto> listProductos,iEntidad factura,bool tipoA)
        {
            bool res = true;
            ManejaProducto manejaProducto = new ManejaProducto();
            
            conec.Ejecutar("start transaction; lock tables productos read;");

            List<Producto> aux = new List<Producto>();

            foreach(Producto pAux in listProductos)
            {
                aux.Add((Producto)manejaProducto.buscaPorId(pAux.Id));
            }

            for (int i = 0; i < listProductos.Count; i++) 
            {
                if(listProductos[i].Stock > aux[i].Stock)
                {
                    conec.Ejecutar("commit; unlock tables;");
                    return false;
                }  
            }

            ManejaVenta manejaVenta = new ManejaVenta();
            ManejaDetalleVenta manejaDetalle = new ManejaDetalleVenta();
            manejaVenta.Alta(venta);
            DetalleVenta dv;
            foreach (Producto p in listProductos)
            {
                dv = new DetalleVenta();
                dv.Venta = (Venta)venta;
                dv.Producto = p;
                dv.PrecioCosto = p.PrecioCosto;
                dv.CoefUrtil = p.CoefUtil;
                dv.Cantidad = p.Stock;
                manejaDetalle.Alta(dv);
            }

            for (int i = 0; i < listProductos.Count; i++)
            {      
                manejaProducto.ModificacionStock(listProductos[i]);
            }

            if (tipoA) 
            {
                ManejaFactura manejaFactura = new ManejaFactura();
                manejaFactura.Alta(factura);
            }
            else
            {
                ManejaFacturaB manejaFacturaB = new ManejaFacturaB();
                manejaFacturaB.Alta(factura);
            }

            conec.Ejecutar("commit; unlock tables;");

            return res;
        }

    }
}
