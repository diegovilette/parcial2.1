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

        public int CantidadVendidoPorCategoria(DateTime desde, int idCategoria)
        {
            string mes = desde.Month.ToString();
            DataTable aux = manejador.Consultar("Select sum(Cantidad) as total from DetalleVentas,ventas,productos where Ventas.IdVenta=DetalleVentas.IdVenta and DetalleVentas.IdProducto=productos.IdProducto and productos.IdCategoria='" + idCategoria + "' and  EXTRACT(month FROM ventas.fecha)='" + mes + "'  group by idCategoria ;");
            try
            {
                DataRow x = aux.Rows[0];
                return Convert.ToInt32(x[0]);
            }
            catch (Exception e)
            {
                return 0;
            }

        }
        public int CantidadVendidoPorCategoriaSucursal(DateTime desde, int idCategoria)
        {
            string mes = desde.Month.ToString();
            DataTable aux = manejador.Consultar("Select sum(Cantidad) as total from DetalleVentas,ventas,productos where Ventas.IdVenta=DetalleVentas.IdVenta and DetalleVentas.IdProducto=productos.IdProducto and productos.IdCategoria='" + idCategoria + "' and ventas.sucursal='" + bdMetodos.Serial() + "' and  EXTRACT(month FROM ventas.fecha)='" + mes + "'  group by idCategoria ;");
            try
            {
                DataRow x = aux.Rows[0];
                return Convert.ToInt32(x[0]);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public double CantidadVendidoDia(int dia, int mes)
        {
            DataTable aux = manejador.Consultar("Select detalleventas.coefutil as coe,detalleventas.PrecioCosto as p,detalleventas.cantidad from DetalleVentas,ventas,productos where Ventas.IdVenta=DetalleVentas.IdVenta and DetalleVentas.IdProducto=productos.IdProducto and  EXTRACT(month FROM ventas.fecha)='" + mes + "' and EXTRACT(day FROM ventas.fecha)='" + dia + "' ;");
            double total = 0;
            foreach (DataRow i in aux.Rows)
            {
                int cantidad = Convert.ToInt32(i["cantidad"]);
                double coe = Convert.ToDouble(i["coe"]);
                double precio = Convert.ToDouble(i["p"]);
                total += cantidad * coe * precio;
            }
            return total;
        }

        public double CantidadVendidoDiaSucursal(int dia, int mes)
        {
            DataTable aux = manejador.Consultar("Select detalleventas.coefutil as coe,detalleventas.PrecioCosto as p,detalleventas.cantidad from DetalleVentas,ventas,productos where Ventas.IdVenta=DetalleVentas.IdVenta and DetalleVentas.IdProducto=productos.IdProducto and  EXTRACT(month FROM ventas.fecha)='" + mes + "' and EXTRACT(day FROM ventas.fecha)='" + dia + "' and ventas.sucursal='" + bdMetodos.Serial() + "' ;");
            double total = 0;
            foreach (DataRow i in aux.Rows)
            {
                int cantidad = Convert.ToInt32(i["cantidad"]);
                double coe = Convert.ToDouble(i["coe"]);
                double precio = Convert.ToDouble(i["p"]);
                total += cantidad * coe * precio;
            }
            return total;
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
                dve.Id = manejador.Ejecutar("Insert into DetalleVentas (IdVenta, IdProducto, PrecioCosto,CoefUtil,Cantidad) values ('" + dve.Venta.Id + "','" + dve.Producto.Id + "','" + cambia(dve.PrecioCosto) + "','" + cambia(dve.CoefUrtil) + "','" + dve.Cantidad + "');SELECT @@identity;");
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
