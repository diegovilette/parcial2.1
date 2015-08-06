using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Manejadores;
using Interfaces;
using System.Data;
namespace Logica
{
    public class Elimina
    {
        public static void Categoria(iEntidad categoria)
        {
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            ((Categoria)categoria).Estado = false;
            manejaCategoria.Modificacion(categoria);
        }

        public static void Cliente(iEntidad cliente)
        {
            ManejaCliente manejaCliente = new ManejaCliente();
            ((Cliente)cliente).Estado = false;
            manejaCliente.Modificacion(cliente);
        }

        public static void Telefono(iEntidad telefono)
        {
            ManejaTelefono manejaTelefono = new ManejaTelefono();
            manejaTelefono.Baja(telefono);
        }

        public static void DetalleVenta(iEntidad detalleVenta)
        {
            ManejaDetalleVenta manejaDetalleVenta = new ManejaDetalleVenta();
            manejaDetalleVenta.Baja(detalleVenta);
        }

        public static void Factura(iEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Baja(factura);
        }

        public static void Pedido(iEntidad pedido)
        {
            ManejaPedido manejaPedido = new ManejaPedido();
            manejaPedido.Baja(pedido);
        }

        public static void Producto(iEntidad producto)
        {
            ManejaProducto manejaProductos = new ManejaProducto();
            ((Producto)producto).Estado = false;
            ((Producto)producto).Stock = 0;
            manejaProductos.Modificacion(producto);
        }

        public static void Proveedor(iEntidad proveedor)
        {
            ManejaProveedor manejaProveedor = new ManejaProveedor();
            ((Proveedor)proveedor).Estado = false;
            manejaProveedor.Modificacion(proveedor);
        }

        public static void Remito(iEntidad remito)
        {
            ManejaRemito manejaRemito = new ManejaRemito();
            manejaRemito.Baja(remito);
        }

        public static void Venta(iEntidad venta)
        {
            bdMetodos manejador = new bdMetodos();
            string instruccion = "select * from DetalleVentas where IdVenta=" + venta.Id;
            DataTable dt = manejador.Consultar(instruccion);
            Producto p;
            foreach(DataRow row in dt.Rows)
            {
                p = Devuelve.Producto((int)row["IdProducto"]);
                p.Stock += (int)row["Cantidad"];
                Actualiza.Producto(p);
            }
            ((Venta)venta).Estado = false;
            ManejaVenta manejaVenta = new ManejaVenta();
            manejaVenta.Modificacion(venta);
        }

        public static void TelefonoCliente(iEntidad Telefono, iEntidad Cliente)
        {
            ManejaTelefonoCliente manejaTelefonoCliente = new ManejaTelefonoCliente();
            manejaTelefonoCliente.Baja(Telefono, Cliente);
        }

        public static void TelefonoProveedor(iEntidad Telefono, iEntidad Proveedor)
        {
            ManejaTelefonoProveedor manejaTelefonoProveedor = new ManejaTelefonoProveedor();
            manejaTelefonoProveedor.Baja(Telefono, Proveedor);
        }
    }
}
