using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class DetalleVenta : iEntidad
    {
        public int Id
        { get; set; }

        public DetalleVenta()
        {
            venta = new Venta();
            producto = new Producto();
        }

        public DetalleVenta(Venta v,Producto p)
        {
            venta = v;
            producto = p;
        }

        Venta venta;

        public Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }
        Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }
        float precioCosto;

        public float PrecioCosto
        {
            get { return precioCosto; }
            set { precioCosto = value; }
        }
        float coefUrtil;

        public float CoefUrtil
        {
            get { return coefUrtil; }
            set { coefUrtil = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}
