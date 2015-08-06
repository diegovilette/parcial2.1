using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public class Remito : iEntidad
    {
        public int Id
        { get; set; }

        public Remito()
        {

        }


        List<Producto> productos;

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        int idProveedor;

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        int idPedido;

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        float precioCosto;

        public float PrecioCosto
        {
            get { return precioCosto; }
            set { precioCosto = value; }
        }
    }
}
