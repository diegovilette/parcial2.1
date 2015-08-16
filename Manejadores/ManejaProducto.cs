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
    public class ManejaProducto : iMetodosBasicos
    {
        //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaProducto()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        /// <summary>
        /// </summary>
        /// <param name="entidad"></param>
        public void Alta(iEntidad entidad)
        {
            Producto pro = (Producto)entidad;
            try
            {
                string q = "Insert into Productos (Descripcion, PrecioCosto, Stock,StockMinimo,CoefUtil, IdCategoria,Talle,Estado,IdProveedor) values ('" + pro.Descripcion + "','" + cambia(pro.PrecioCosto) + "','" + pro.Stock + "','" + pro.StockMinimo + "'," + cambia(pro.CoefUtil) + ",'" + pro.IdCategoria + "','" + pro.Talle + "'," + pro.Estado + "," + pro.Proveedor.Id + ");SELECT @@identity;";
                pro.Id = manejador.Ejecutar(q);
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        public void Baja(iEntidad entidad)
        {
            Producto pro = (Producto)entidad;
            try
            {
                manejador.Ejecutar("UPDATE Productos SET Estado = 0 WHERE `IdCliente`='" + pro.Id + "';");
                manejador.Ejecutar("commit;");
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string cambia(float coef)
        {
            string res = coef.ToString();
            string resposta = string.Empty;
            foreach(char x in res)
            {
                if(x == ',')
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        public void Modificacion(iEntidad entidad)
        {
            Producto pro = (Producto)entidad;
            try
            {
                manejador.Ejecutar("UPDATE Productos SET Descripcion='" + pro.Descripcion + "', PrecioCosto=" + pro.PrecioCosto + ", Stock=" + pro.Stock + ", StockMinimo=" + pro.StockMinimo + ", CoefUtil=" + cambia(pro.CoefUtil) + ", IdCategoria=" + pro.IdCategoria + ", Talle='" + pro.Talle + "',Estado=" + pro.Estado + " WHERE IdProducto=" + pro.Id + ";");
                manejador.Ejecutar("commit;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ModificacionStock(iEntidad entidad)
        {
            Producto pro = (Producto)entidad;
            try
            {
                manejador.Ejecutar("UPDATE Productos SET Stock= stock-" + pro.Stock + " WHERE IdProducto=" + pro.Id + ";");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Productos;");
            List<iEntidad> aux2 = new List<iEntidad>();
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            ManejaProveedor x = new ManejaProveedor();
            foreach (DataRow i in aux.Rows)
            {
                Producto res = new Producto();
                res.Id = Convert.ToInt32(i["IdProducto"]);
                res.Descripcion = i["Descripcion"].ToString();
                res.PrecioCosto = (float)i["PrecioCosto"];
                res.Stock = Convert.ToInt32(i["Stock"].ToString());
                res.StockMinimo = Convert.ToInt32(i["StockMinimo"]);
                res.CoefUtil = (float)i["CoefUtil"];
                res.IdCategoria =Convert.ToInt32(i["IdCategoria"].ToString());
                res.Talle = i["Talle"].ToString();
                res.Estado = Convert.ToBoolean(i["Estado"]);
                
                res.Proveedor = (Proveedor)x.buscaPorId(Convert.ToInt32(i["IdProveedor"]));
                aux2.Add(res);
            }
            return aux2;
        }

        public iEntidad buscaPorId(int id)
        {
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            DataRow aux = manejador.ConsultarId("Select * from Productos WHERE `IdProducto`='" + id + "';");
            Producto res = new Producto();
            ManejaProveedor x = new ManejaProveedor();
            res.Id = Convert.ToInt32(aux["IdProducto"]);
            res.Descripcion = aux["Descripcion"].ToString();
            res.PrecioCosto = (float)aux["PrecioCosto"];
            res.Stock = Convert.ToInt32(aux["Stock"].ToString());
            res.StockMinimo = Convert.ToInt32(aux["StockMinimo"]);
            res.CoefUtil = (float)aux["CoefUtil"];
            res.IdCategoria = Convert.ToInt32(aux["IdCategoria"].ToString());
            res.Talle = aux["Talle"].ToString();
            res.Estado = Convert.ToBoolean(aux["Estado"]);
            res.Proveedor =(Proveedor)x.buscaPorId(Convert.ToInt32(aux["IdProveedor"]));
            return res;
        }
    }
}
