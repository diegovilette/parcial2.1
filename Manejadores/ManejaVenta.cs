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
            string query = "INSERT INTO Ventas(Fecha,Total) VALUES('" + te.Fecha + "','" +  cambia(te.Total) + "');SELECT @@identity;";
            te.Id = conec.Ejecutar(query);
            conec.Ejecutar("commit;");
        }

        public void Baja(iEntidad entidad)
        {
            Venta te = (Venta)entidad;
            string query = "UPDATE Ventas set Estado = 0 WHERE IdVenta=" + te.Id;
            int i = conec.Ejecutar(query);
            conec.Ejecutar("commit;");
        }

        public void Modificacion(iEntidad entidad)
        {
            Venta te = (Venta)entidad;
            string query = "UPDATE Ventas SET Fecha='" + te.Fecha + "',Total=" + te.Total + ", Estado = "+te.Estado+" WHERE IdVenta=" + te.Id;
            int i = conec.Ejecutar(query);
            conec.Ejecutar("commit;");
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
    }
}
