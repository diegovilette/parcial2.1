using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Manejadores;
using Interfaces;

namespace Logica
{
    public enum ABM { Alta, Baja, Modificacion };

    public class Devuelve
    {
        public static List<Categoria> Categorias()
        {
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            List<Categoria> res = new List<Categoria>();
            foreach (iEntidad i in manejaCategoria.Todo())
            {
                if (((Categoria)i).Estado)
                {
                    res.Add((Categoria)i);
                }            
            }
            return res;
        }

        public static Categoria Categoria(int id)
        {
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            Categoria res = new Categoria();
            res = (Categoria)manejaCategoria.buscaPorId(id);
            return res;
        }

        public static List<Cliente> Clientes()
        {
            ManejaCliente manejaCliente = new ManejaCliente();
            List<Cliente> res = new List<Cliente>();
            foreach (iEntidad i in manejaCliente.Todo())
            {
                res.Add((Cliente)i);
            }
            return res;
        }

        public static Cliente Cliente(int id)
        {
            ManejaCliente manejaCliente = new ManejaCliente();
            Cliente res = new Cliente();
            res = (Cliente)manejaCliente.buscaPorId(id);
            return res;
        }

        public static List<Telefono> Telefonos()
        {
            ManejaTelefono manejaTelefono = new ManejaTelefono();
            List<Telefono> res = new List<Telefono>();
            foreach (iEntidad i in manejaTelefono.Todo())
            {
                res.Add((Telefono)i);
            }
            return res;
        }

        public static Telefono Telefono(int id)
        {
            ManejaTelefono manejaTelefono = new ManejaTelefono();
            Telefono res = new Telefono();
            res = (Telefono)manejaTelefono.buscaPorId(id);
            return res;
        }


        public static List<DetalleVenta> DetallesVentas()
        {
            ManejaDetalleVenta manejaDetalleVenta = new ManejaDetalleVenta();
            List<DetalleVenta> res = new List<DetalleVenta>();
            foreach (iEntidad i in manejaDetalleVenta.Todo())
            {
                res.Add((DetalleVenta)i);
            }
            return res;
        }

        public static DetalleVenta DetalleVenta(int id)
        {
            ManejaDetalleVenta manejaDetalleVenta = new ManejaDetalleVenta();
            DetalleVenta res = new DetalleVenta();
            res = (DetalleVenta)manejaDetalleVenta.buscaPorId(id);
            return res;
        }

        public static List<Factura> Facturas()
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            List<Factura> res = new List<Factura>();
            foreach (iEntidad i in manejaFactura.Todo())
            {
                res.Add((Factura)i);
            }
            return res;
        }

        public static Factura Factura(int id)
        {
            ManejaFactura manejaTipoEvento = new ManejaFactura();
            Factura res = new Factura();
            res = (Factura)manejaTipoEvento.buscaPorId(id);
            return res;
        }

        public static List<Producto> Productos()
        {
            ManejaProducto manejaProducto = new ManejaProducto();
            List<Producto> res = new List<Producto>();
            foreach (iEntidad i in manejaProducto.Todo())
            {
                if (((Producto)i).Estado)
                {
                    res.Add((Producto)i);
                }   
            }
            return res;
        }

        public static Producto Producto(int id)
        {
            ManejaProducto manejaProducto = new ManejaProducto();
            Producto res = new Producto();
            res = (Producto)manejaProducto.buscaPorId(id);
            return res;
        }

        public static List<Remito> Remitos()
        {
            ManejaRemito manejaRemito = new ManejaRemito();
            List<Remito> res = new List<Remito>();
            foreach (iEntidad i in manejaRemito.Todo())
            {
                res.Add((Remito)i);
            }
            return res;
        }

        public static Remito Remito(int id)
        {
            ManejaRemito manejaRemito = new ManejaRemito();
            Remito res = new Remito();
            res = (Remito)manejaRemito.buscaPorId(id);
            return res;
        }

        public static List<Proveedor> Proveedores()
        {
            ManejaProveedor manejaProveedor = new ManejaProveedor();
            List<Proveedor> res = new List<Proveedor>();
            foreach (iEntidad i in manejaProveedor.Todo())
            {
                if (((Proveedor)i).Estado)
                {
                    res.Add((Proveedor)i);
                }                
            }
            return res;
        }

        public static Proveedor Proveedor(int id)
        {
            ManejaProveedor manejaProveedor = new ManejaProveedor();
            Proveedor res = new Proveedor();
            res = (Proveedor)manejaProveedor.buscaPorId(id);
            return res;
        }

        public static List<Venta> Ventas()
        {
            ManejaVenta manejoVenta = new ManejaVenta();
            List<Venta> res = new List<Venta>();
            foreach (iEntidad i in manejoVenta.Todo())
            {
                res.Add((Venta)i);
            }
            return res;
        }

        public static Venta Venta(int id)
        {
            ManejaVenta manejaVenta = new ManejaVenta();
            Venta res = new Venta();
            res = (Venta)manejaVenta.buscaPorId(id);
            return res;
        }


        public static List<Pedido> Pedidos()
        {
            ManejaPedido manejaPedido = new ManejaPedido();
            List<Pedido> res = new List<Pedido>();
            foreach (iEntidad i in manejaPedido.Todo())
            {
                res.Add((Pedido)i);
            }
            return res;
        }

        public static Pedido Pedido(int id)
        {
            ManejaPedido manejaPedido = new ManejaPedido();
            Pedido res = new Pedido();
            res = (Pedido)manejaPedido.buscaPorId(id);
            return res;
        }
         
    }
}
