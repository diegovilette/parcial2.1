using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Interfaces;


namespace Manejadores
{
    public class bdMetodos : IbdMetodos
    {
        //Propiedades
        MySqlConnection conexion;

        //Metodos
        /// <summary>
        /// Metodo para realizar Update, Insert o Delete.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Ejecutar(String sql)
        {
            int res = -1;
            MySqlCommand comando = new MySqlCommand();
            try
            {
                comando.Connection = getConnection();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql;
                res = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
                return res;
            }
            catch (MySqlException e)
            {
                comando.CommandText = "rollback;";
                comando.ExecuteScalar();
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Metodo para realizar Select.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Consultar(String sql)
        {
            DataTable aux = new DataTable("Auxiliar");
            MySqlCommand comando = new MySqlCommand();
            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            try
            {
                comando.Connection = getConnection();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql;
                dAdapter.SelectCommand = comando;
                dAdapter.Fill(aux);
            }
            catch (MySqlException e)
            {
                throw e;

            }
            finally
            {
                conexion.Close();
            }
            return aux;
        }

        /// <summary>
        /// Metodos sobrecargado para consultar por una sola fila; Ejemplo buscar por ID;
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataRow ConsultarId(String sql)
        {
            DataTable aux = new DataTable("Auxiliar");
            MySqlCommand comando = new MySqlCommand();
            MySqlDataAdapter dAdapter = new MySqlDataAdapter();
            try
            {
                comando.Connection = getConnection();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql;
                dAdapter.SelectCommand = comando;
                dAdapter.Fill(aux);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            if(aux.Rows==null)
            {
                return null;
            }
            else {
                return aux.Rows[0];
            }
            
        }

        private MySqlConnection getConnection()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

        //Constructores
        public bdMetodos()
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = "Server=" + "localhost" + ";Port=3306;Database=" + "parcial2" + ";Uid=" + "root" + ";Pwd=" + "" + "; Convert Zero DateTime=true;";
        }

        /// <summary>
        /// Metodo sobre cargado que recive el string de conexion de otra base que no se la por defecto.
        /// </summary>
        /// <param name="conexBase"></param>
        public bdMetodos(String conexBase)
        {
            conexion = new MySqlConnection();
            conexion.ConnectionString = conexBase;
        }
    }
}
