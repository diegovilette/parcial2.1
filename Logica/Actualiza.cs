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
    public class Actualiza
    {
        public static void Categoria(iEntidad categoria)
        {
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            manejaCategoria.Modificacion(categoria);
        }

        public static void Cliente(iEntidad cliente)
        {
            ManejaCliente manejaCliente = new ManejaCliente();
            manejaCliente.Modificacion(cliente);
        }

        public static void Telefono(iEntidad telefono)
        {
            ManejaTelefono manejaTelefono = new ManejaTelefono();
            manejaTelefono.Modificacion(telefono);
        }

        public static void DetalleVenta(iEntidad detalleVenta)
        {
            ManejaDetalleVenta manejaDetalleVenta = new ManejaDetalleVenta();
            manejaDetalleVenta.Modificacion(detalleVenta);
        }

        public static void Factura(iEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Modificacion(factura);
        }

        public static void Pedido(iEntidad pedido)
        {
            ManejaPedido manejaPedido = new ManejaPedido();
            manejaPedido.Modificacion(pedido);
        }

        public static void Producto(iEntidad producto)
        {
            ManejaProducto manejaProductos = new ManejaProducto();
            manejaProductos.Modificacion(producto);
        }

        public static void Proveedor(iEntidad proveedor)
        {
            ManejaProveedor manejaProveedor = new ManejaProveedor();
            manejaProveedor.Modificacion(proveedor);
        }

        public static void Remito(iEntidad remito)
        {
            ManejaRemito manejaRemito = new ManejaRemito();
            manejaRemito.Modificacion(remito);
        }

        public static void Venta(iEntidad venta)
        {
            ManejaVenta manejaVenta = new ManejaVenta();
            manejaVenta.Modificacion(venta);
        }

        public static void TelefonoCliente(iEntidad Telefono, iEntidad Cliente)
        {
            ManejaTelefonoCliente manejaTelefonoCliente = new ManejaTelefonoCliente();
            manejaTelefonoCliente.Baja(Telefono, Cliente);
            manejaTelefonoCliente.Alta(Telefono, Cliente);
        }

        public static void TelefonoProveedor(iEntidad Telefono, iEntidad Proveedor)
        {
            ManejaTelefonoProveedor manejaTelefonoProveedor = new ManejaTelefonoProveedor();
            manejaTelefonoProveedor.Baja(Telefono, Proveedor);
            manejaTelefonoProveedor.Alta(Telefono, Proveedor);
        }
    }
}
