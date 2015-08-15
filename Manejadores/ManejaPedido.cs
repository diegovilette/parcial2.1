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
    public class ManejaPedido :iMetodosBasicos
    {
        bdMetodos conec;

        public ManejaPedido()
        {
            conec = new bdMetodos();
        }

        public List<iEntidad> pasteTo(DataTable dt, DataTable dt2)
        {
            List<iEntidad> res = new List<iEntidad>();

            foreach (DataRow dr in dt.Rows)
            {
                Pedido aux = new Pedido();
                ManejaProducto manejaProducto = new ManejaProducto();
                List<Producto> producto = new List<Producto>();
                aux.Id = (int)dr["IdPedido"];
                foreach (DataRow dr2 in dt2.Rows)
                {
                    if ((int)dr["IdPedido"] == (int)dr2["IdPedido"])
                    {
                        aux.Fecha = (DateTime)dr2["Fecha"];
                        aux.Cantidad = (int)dr2["Cantidad"];
                        Producto popo = (Producto)manejaProducto.buscaPorId((int)dr2["IdProducto"]);
                        popo.Stock = (int)dr2["Cantidad"];
                        producto.Add(popo);
                    }
                }
                if(producto.Count > 0)
                    aux.Proveedor = producto[0].Proveedor;
                aux.Productos = producto;                
                res.Add(aux);
            }
            return res;
        }

        public void Alta(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            Pedido te = (Pedido)entidad;
            string query = "INSERT INTO Pedidos(IdProveedor) VALUES(" + te.Proveedor.Id + ");SELECT @@identity;";
            te.Id = conec.Ejecutar(query);
            foreach (Producto p in te.Productos)
            {
                query = "INSERT INTO ProductoPedido(IdProducto,IdPedido,Cantidad,Fecha) VALUES(" + p.Id + "," + te.Id + "," + p.Stock + ",'" + te.Fecha + "');SELECT @@identity;";
                p.Id = conec.Ejecutar(query);
            }
            conec.Ejecutar("commit;");
        }

        public void Baja(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            Pedido te = (Pedido)entidad;
            string query = "DELETE FROM Pedidos WHERE IdPedido=" + te.Id + ");";
            int i = conec.Ejecutar(query);
            query = "DELETE FROM ProductoPedido WHERE IdPedido=" + te.Id + ");";
            i = conec.Ejecutar(query);
            conec.Ejecutar("commit;");
        }

        public void Modificacion(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            Pedido te = (Pedido)entidad;
            string query = "UPDATE Pedidos SET IdProveedor=" + te.Proveedor.Id + " WHERE IdPedido=" + te.Id;
            int i = conec.Ejecutar(query);
            foreach (Producto p in te.Productos)
            {
                query = "UPDATE ProductoPedido SET IdProducto=" + p.Id + ",Cantidad=" + te.Cantidad + ",Fecha='" + te.Fecha + " WHERE IdPedido=" + te.Id + ";";
                i = conec.Ejecutar(query);
            }
            conec.Ejecutar("commit;");
        }

        public List<iEntidad> Todo()
        {
            string consulta = "SELECT * FROM Pedidos;";
            string consulta2 = "SELECT * FROM ProductoPedido;";
            return pasteTo(conec.Consultar(consulta), conec.Consultar(consulta2));
        }

        public iEntidad buscaPorId(int id)
        {
            string consulta = "SELECT * FROM Pedidos WHERE IdPedido=" + id.ToString() + ";";
            string consulta2 = "SELECT * FROM ProductoPedido WHERE IdPedido=" + id.ToString() + ";";
            return pasteTo(conec.Consultar(consulta), conec.Consultar(consulta2))[0];
        }
    }
}
