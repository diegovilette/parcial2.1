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
    public class Agrega
    {
        public static void Categoria(iEntidad categoria)
        {            
            ManejaCategoria manejaCategoria = new ManejaCategoria();
            manejaCategoria.Alta(categoria);
        }

        public static bool Cliente(iEntidad cliente)
        {
            List<Cliente> aux = Devuelve.Clientes();

            foreach (Cliente pAux in aux)
            {
                if (((Cliente)cliente).Email == pAux.Email)
                {
                    return false;
                }
            }

            ManejaCliente manejaCliente = new ManejaCliente();
            manejaCliente.Alta(cliente);
            return true;
        }

        public static void Telefono(iEntidad telefono)
        {
            ManejaTelefono manejaTelefono = new ManejaTelefono();
            manejaTelefono.Alta(telefono);
        }

        public static void DetalleVenta(iEntidad detalleVenta)
        {
            ManejaDetalleVenta manejaDetalleVenta = new ManejaDetalleVenta();
            manejaDetalleVenta.Alta(detalleVenta);
        }

        public static void Factura(iEntidad factura)
        {
            ManejaFactura manejaFactura = new ManejaFactura();
            manejaFactura.Alta(factura);
        }

        public static void Pedido(iEntidad pedido)
        {
            ManejaPedido manejaPedido = new ManejaPedido();
            manejaPedido.Alta(pedido);
        }

        public static void Producto(iEntidad producto)
        {
            ManejaProducto manejaProductos = new ManejaProducto();
            manejaProductos.Alta(producto);
        }

        public static void Proveedor(iEntidad proveedor)
        {
            ManejaProveedor manejaProveedor = new ManejaProveedor();
            manejaProveedor.Alta(proveedor);
        }

        public static void Remito(iEntidad remito)
        {
            ManejaRemito manejaRemito = new ManejaRemito();
            manejaRemito.Alta(remito);
        }

        public static bool Venta(iEntidad venta,List<Producto> listProductos,iEntidad factura,bool tipoA)
        {
            return ManejaVenta.Alta(venta,listProductos,factura,tipoA);         
        }

        public static void TelefonoCliente(iEntidad Telefono, iEntidad Cliente)
        {
            ManejaTelefonoCliente manejaTelefonoCliente = new ManejaTelefonoCliente();
            manejaTelefonoCliente.Alta(Telefono,Cliente);
        }

        public static void TelefonoProveedor(iEntidad Telefono, iEntidad Proveedor)
        {
            ManejaTelefonoProveedor manejaTelefonoProveedor = new ManejaTelefonoProveedor();
            manejaTelefonoProveedor.Alta(Telefono, Proveedor);
        }
    }
}
