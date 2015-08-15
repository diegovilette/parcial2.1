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
    public class ManejaRemito : iMetodosBasicos
    {
        IbdMetodos conec;

        public ManejaRemito()
        {
            conec = new bdMetodos();
        }

        public List<iEntidad> pasteTo(DataTable dt, DataTable dt2)
        {
            List<iEntidad> res = new List<iEntidad>();

            foreach (DataRow dr in dt.Rows)
            {
                Remito aux = new Remito();
                ManejaProducto manejaProducto = new ManejaProducto();
                List<Producto> producto = new List<Producto>();
                aux.Id = (int)dr["IdRemito"];
                foreach (DataRow dr2 in dt2.Rows)
                {
                    aux.Fecha = (DateTime)dr2["Fecha"];
                    aux.Cantidad = (int)dr2["Cantidad"];
                    aux.PrecioCosto = (float)dr2["PrecioCosto"];
                    producto.Add((Producto)manejaProducto.buscaPorId((int)dr2["IdProducto"]));
                }
                aux.Productos = producto;
                res.Add(aux);
            }
            return res;
        }

        public void Alta(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            ManejaProducto mP = new ManejaProducto();
            Remito te = (Remito)entidad;
            string qStock;
            int auxPro; 
            string query = "INSERT INTO Remitos(IdProveedor,IdPedido) VALUES(" + te.IdProveedor + "," + te.IdPedido + ");SELECT @@identity;";
            te.Id = conec.Ejecutar(query);
            foreach (Producto p in te.Productos)
            {
                auxPro = ((Producto)mP.buscaPorId(p.Id)).Stock + p.Stock;
                query = "INSERT INTO ProductoRemito(IdProducto,IdRemito,Cantidad,Fecha,PrecioCosto) VALUES(" + p.Id + "," + te.Id + "," + p.Stock + ",'" + te.Fecha + "'," + te.PrecioCosto + ");SELECT @@identity;";
                qStock = "UPDATE `Productos` SET `Stock`='"+ auxPro +"' WHERE `IdProducto`='" + p.Id + "';";
                p.Id = conec.Ejecutar(query);
                conec.Ejecutar(qStock);
            }
            conec.Ejecutar("commit;");
        }

        public void Baja(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            Remito te = (Remito)entidad;
            string query = "DELETE FROM Remitos WHERE IdRemito=" + te.Id + ");";
            int i = conec.Ejecutar(query);
            query = "DELETE FROM ProductoRemito WHERE IdRemito=" + te.Id + ");";
            i = conec.Ejecutar(query);
            conec.Ejecutar("commit;");
        }

        public void Modificacion(iEntidad entidad)
        {
            conec.Ejecutar("start transaction;");
            Remito te = (Remito)entidad;
            string query = "UPDATE Remitos SET IdProveedor=" + te.IdProveedor + ",IdPedido=" + te.IdPedido + " WHERE IdRemito=" + te.Id;
            int i = conec.Ejecutar(query);
            foreach (Producto p in te.Productos)
            {
                query = "UPDATE ProductoRemito SET IdProducto=" + p.Id + ",Cantidad=" + te.Cantidad + ",Fecha='" + te.Fecha + "',PrecioCosto=" + te.PrecioCosto + " WHERE IdRemito=" + te.Id + ";";
                i = conec.Ejecutar(query);
            }
            conec.Ejecutar("commit;");
        }

        public List<iEntidad> Todo()
        {
            string consulta = "SELECT * FROM Remitos;";
            string consulta2 = "SELECT * FROM ProductoRemito;";
            return pasteTo(conec.Consultar(consulta), conec.Consultar(consulta2));
        }

        public iEntidad buscaPorId(int id)
        {
            string consulta = "SELECT * FROM Remitos WHERE IdRemito=" + id.ToString() + ";";
            string consulta2 = "SELECT * FROM ProductoRemito WHERE IdRemito=" + id.ToString() + ";";
            return pasteTo(conec.Consultar(consulta), conec.Consultar(consulta2))[0];
        }
    }
}
