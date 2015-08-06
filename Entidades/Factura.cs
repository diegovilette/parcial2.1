using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Factura : iEntidad
    {
        public int Id
        { get; set; }

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Factura()
        {
            cliente = new Cliente();
            venta = new Venta();
        }

        public Factura(Cliente c,Venta v)
        {
            cliente = c;
            venta = v;
        }

        Venta venta;

        public Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }
        Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        float iva;

        public float Iva
        {
            get { return iva; }
            set { iva = value; }
        }
    }
}
