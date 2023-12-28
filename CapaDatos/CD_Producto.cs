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
    public class CD_Producto
    {
        // Funcion que retorna una lista de productos de la BD
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    // Se crea la cadena de consulta
                    consulta.AppendLine("SELECT id_producto, codigo, producto.descripcion, stock, precio_costo, precio_venta, producto.estado, categoria.id_categoria, categoria.descripcion[DescripcionCategoria] FROM Producto");
                    consulta.AppendLine("INNER JOIN Categoria ON categoria.id_categoria = producto.id_categoria");
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Producto, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Producto por cada registro con sus atributos
                            lista.Add(new Producto()
                            {
                                id_producto = Convert.ToInt32(reader["id_producto"]),
                                codigo = reader["codigo"].ToString(),
                                descripcion = reader["descripcion"].ToString(),
                                categoria = new Categoria() { id_categoria = Convert.ToInt32(reader["id_categoria"].ToString()), descripcion = reader["DescripcionCategoria"].ToString() },
                                stock = Convert.ToInt32(reader["stock"].ToString()),
                                precio_costo = Convert.ToDecimal(reader["precio_costo"].ToString()),
                                precio_venta = Convert.ToDecimal(reader["precio_venta"].ToString()),
                                estado = Convert.ToBoolean(reader["estado"].ToString())
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Producto>();
                }
            }
            return lista;
        }

        // Función que registra un Producto en la BD
        public int Registrar(Producto producto, out string mensaje)
        {
            int resultado = 0;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Agregar_Producto", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("codigo", producto.codigo);
                    cmd.Parameters.AddWithValue("descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("id_categoria", producto.categoria.id_categoria);
                    cmd.Parameters.AddWithValue("estado", producto.estado);
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

        // Función que edita un Producto de la BD
        public bool Editar(Producto producto, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Editar_Producto", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_producto", producto.id_producto);
                    cmd.Parameters.AddWithValue("codigo", producto.codigo);
                    cmd.Parameters.AddWithValue("descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("id_categoria", producto.categoria.id_categoria);
                    cmd.Parameters.AddWithValue("estado", producto.estado);
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

        // Función que elimina un Producto de la BD
        public bool Eliminar(Producto producto, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Eliminar_Producto", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_producto", producto.id_producto);
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
