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
    public class ManejaCategoria : iMetodosBasicos
    {
         //Atributos
        bdMetodos manejador;

        //Constructor
        public ManejaCategoria()
        {
            manejador = new bdMetodos();
        }

        //Metodos
        public void Alta(iEntidad entidad)
        {
            Categoria cat = (Categoria)entidad;
            try
            {
               cat.Id = manejador.Ejecutar("Insert into Categorias (Descripcion,Estado) values ('" + cat.Descripcion + "',1);SELECT @@identity;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Baja(iEntidad entidad)
        {
            Categoria cat = (Categoria)entidad;
            try
            {
                manejador.Ejecutar("UPDATE Categorias set Estado=0 WHERE IdCategoria="+cat.Id+";");
            }
            catch (Exception e)
            {
                throw e;
              
            }
        }


        public void Modificacion(iEntidad entidad)
        {
            Categoria cat = (Categoria)entidad;
            try
            {
                manejador.Ejecutar("UPDATE `Categorias` SET `Descripcion`='" + cat.Descripcion + "', Estado=" + cat.Estado + " WHERE `IdCategoria`='" + cat.Id + "';SELECT @@identity;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<iEntidad> Todo()
        {
            DataTable aux = manejador.Consultar("Select * from Categorias;");
            List<iEntidad> res = new List<iEntidad>();
            foreach (DataRow i in aux.Rows)
            {
                Categoria auxEva = new Categoria();
                auxEva.Id = Convert.ToInt32(i["IdCategoria"]);
                auxEva.Descripcion = i["Descripcion"].ToString();
                auxEva.Estado = Convert.ToBoolean(i["Estado"]);
                res.Add(auxEva);
            }
            return res;
        }

        public iEntidad buscaPorId(int id)
        {
            DataRow aux = manejador.ConsultarId("Select * from Categorias WHERE `IdCategoria`='" + id + "';");
            Categoria res = new Categoria();
            res.Id = Convert.ToInt32(aux["IdCategoria"]);
            res.Descripcion = aux["Descripcion"].ToString();
            res.Estado = Convert.ToBoolean(aux["Estado"]);
            return res;
        }
    }
}
