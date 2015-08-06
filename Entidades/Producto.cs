using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Entidades
{
    public enum eTalle {S,M,L,XL,XXL};

    public class Producto : iEntidad
    {
        public int Id
        { get; set; }

        public Producto()
        {
            
        }
        
        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        float precioCosto;

        public float PrecioCosto
        {
            get { return precioCosto; }
            set { precioCosto = value; }
        }
        float coefUtil;

        public float CoefUtil
        {
            get { return coefUtil; }
            set { coefUtil = value; }
        }
        int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        int stockMinimo;

        public int StockMinimo
        {
            get { return stockMinimo; }
            set { stockMinimo = value; }
        }

        int idCategoria;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        Proveedor proveedor;

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
    

        String talle;

        public String Talle
        {
            get { return talle; }
            set { talle = value; }
        }

        bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
