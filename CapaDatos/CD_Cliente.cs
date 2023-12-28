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
    public class CD_Cliente
    {
        // Funcion que retorna una lista de clientes de la BD
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se crea la cadena de consulta
                    string consulta = "SELECT id_cliente, dni, nombre_completo, email, telefono, estado FROM Cliente";
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Clientes, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Cliente por cada registro con sus atributos
                            lista.Add(new Cliente()
                            {
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                dni = reader["dni"].ToString(),
                                nombre_completo = reader["nombre_completo"].ToString(),
                                email = reader["email"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Cliente>();
                }
            }
            return lista;
        }

        // Función que registra un cliente en la BD
        public int Registrar(Cliente cliente, out string mensaje)
        {
            int id_cliente_generado = 0;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Agregar_Cliente", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("nombre_completo", cliente.nombre_completo);
                    cmd.Parameters.AddWithValue("dni", cliente.dni);
                    cmd.Parameters.AddWithValue("email", cliente.email);
                    cmd.Parameters.AddWithValue("telefono", cliente.telefono);
                    cmd.Parameters.AddWithValue("estado", cliente.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    id_cliente_generado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                id_cliente_generado = 0;
                mensaje = ex.Message;
            }
            return id_cliente_generado;
        }

        // Función que edita un cliente de la BD
        public bool Editar(Cliente cliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Editar_Cliente", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_cliente", cliente.id_cliente);
                    cmd.Parameters.AddWithValue("nombre_completo", cliente.nombre_completo);
                    cmd.Parameters.AddWithValue("dni", cliente.dni);
                    cmd.Parameters.AddWithValue("email", cliente.email);
                    cmd.Parameters.AddWithValue("telefono", cliente.telefono);
                    cmd.Parameters.AddWithValue("estado", cliente.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }

        // Función que elimina un cliente de la BD
        public bool Eliminar(Cliente cliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Eliminar_Cliente", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_cliente", cliente.id_cliente);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }
            return respuesta;
        }
    }
}
