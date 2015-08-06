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
    public class Filtra
    {     
        public static DataTable Filtro(string talle, string categ, string descr)
        {
            bdMetodos manejador = new bdMetodos();
            string instruccion = "select * from Productos p, Categorias c where c.IdCategoria=p.IdCategoria and p.Estado=1 ";
            if (talle == "Todo" && categ == "Todo" && descr == "")
            {
                instruccion += ";";
            }
            else
            {
                if (talle == "Todo" && categ == "Todo" && descr != string.Empty)
                {
                    instruccion += "and p.Descripcion like '%" + descr + "%'";
                }
                else
                {
                    if (categ == "Todo" && descr == "")
                    {
                        instruccion += "and p.Talle='" + talle + "'";
                    }
                    else
                    {
                        if (categ == "Todo")
                        {
                            instruccion += "and p.Talle='" + talle + "' and p.Descripcion like '%" + descr + "%'";
                        }
                        else
                        {
                            if (talle == "Todo" && descr == "")
                            {
                                instruccion += "and c.Descripcion='" + categ + "'";
                            }
                            else
                            {
                                if (talle == "Todo")
                                {
                                    instruccion += "and c.Descripcion='" + categ + "' and p.Descripcion like '%" + descr + "%'";
                                }
                                else
                                {
                                    if (talle != string.Empty && categ != string.Empty && descr != string.Empty)
                                    {
                                        instruccion += "and p.Talle='" + talle + "' and c.Descripcion='" + categ + "' and p.Descripcion like '%" + descr + "%'";
                                    }
                                    else
                                    {
                                        instruccion += "and p.Talle='" + talle + "' and c.Descripcion='" + categ + "'";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return manejador.Consultar(instruccion);
        }


        public static DataTable FiltroProveedor(string talle, string categ, string descr,string provee)
        {
            bdMetodos manejador = new bdMetodos();
            string instruccion = "select * from Productos p, Categorias c, Proveedores pr where c.IdCategoria=p.IdCategoria and p.IdProveedor=pr.IdProveedor and pr.Nombre ='"+provee+"' and p.Estado=1 ";
            if (talle == "Todo" && categ == "Todo" && descr == "")
            {
                instruccion += "";
            }
            else
            {
                if (talle == "Todo" && categ == "Todo" && descr != string.Empty)
                {
                    instruccion += "and p.Descripcion like '%" + descr + "%'";
                }
                else
                {
                    if (categ == "Todo" && descr == "")
                    {
                        instruccion += "and p.Talle='" + talle + "'";
                    }
                    else
                    {
                        if (categ == "Todo")
                        {
                            instruccion += "and p.Talle='" + talle + "' and p.Descripcion like '%" + descr + "%'";
                        }
                        else
                        {
                            if (talle == "Todo" && descr == "")
                            {
                                instruccion += "and c.Descripcion='" + categ + "'";
                            }
                            else
                            {
                                if (talle == "Todo")
                                {
                                    instruccion += "and c.Descripcion='" + categ + "' and p.Descripcion like '%" + descr + "%'";
                                }
                                else
                                {
                                    if (talle != string.Empty && categ != string.Empty && descr != string.Empty)
                                    {
                                        instruccion += "and p.Talle='" + talle + "' and c.Descripcion='" + categ + "' and p.Descripcion like '%" + descr + "%'";
                                    }
                                    else
                                    {
                                        instruccion += "and p.Talle='" + talle + "' and c.Descripcion='" + categ + "'";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return manejador.Consultar(instruccion);
        }


    }
}
