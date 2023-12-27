using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Categoria
    {
        // Funcion que retorna una lista de categorías de la BD
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se crea la cadena de consulta
                    string consulta = "SELECT id_categoria, descripcion, estado FROM Categoria";
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Categoría, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Categoría por cada registro con sus atributos
                            lista.Add(new Categoria()
                            {
                                id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                descripcion = reader["descripcion"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Categoria>();
                }
            }
            return lista;
        }

        // Función que registra un Categoría en la BD
        public int Registrar(Categoria categoria, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Agregar_Categoria", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("descripcion", categoria.descripcion);
                    cmd.Parameters.AddWithValue("estado", categoria.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    resultado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = 0;
                mensaje = ex.Message;
            }
            return resultado;
        }

        // Función que edita un Categoría de la BD
        public bool Editar(Categoria categoria, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Editar_Categoria", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_categoria", categoria.id_categoria);
                    cmd.Parameters.AddWithValue("descripcion", categoria.descripcion);
                    cmd.Parameters.AddWithValue("estado", categoria.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }
            return resultado;
        }

        // Función que elimina un Categoría de la BD
        public bool Eliminar(Categoria categoria, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Eliminar_Categoria", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_categoria", categoria.id_categoria);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    resultado = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                resultado = false;
                mensaje = ex.Message;
            }
            return resultado;
        }
    }
}
