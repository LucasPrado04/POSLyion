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
    public class CD_Proveedor
    {
        // Funcion que retorna una lista de proveedores de la BD
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se crea la cadena de consulta
                    string consulta = "SELECT cuit, razon_social, email, telefono, estado FROM Proveedor";
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Proveedor, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Proveedor por cada registro con sus atributos
                            lista.Add(new Proveedor()
                            {
                                id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                cuit = reader["cuit"].ToString(),
                                razon_social = reader["razon_social"].ToString(),
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
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }

        // Función que registra un proveedor en la BD
        public int Registrar(Proveedor proveedor, out string mensaje)
        {
            int id_proveedor_generado = 0;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Agregar_Proveedor", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("cuit", proveedor.cuit);
                    cmd.Parameters.AddWithValue("razon_social", proveedor.razon_social);
                    cmd.Parameters.AddWithValue("email", proveedor.email);
                    cmd.Parameters.AddWithValue("telefono", proveedor.telefono);
                    cmd.Parameters.AddWithValue("estado", proveedor.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    id_proveedor_generado = Convert.ToInt32(cmd.Parameters["resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                id_proveedor_generado = 0;
                mensaje = ex.Message;
            }
            return id_proveedor_generado;
        }

        // Función que edita un proveedor de la BD
        public bool Editar(Proveedor proveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Editar_Proveedor", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_proveedor", proveedor.id_proveedor);
                    cmd.Parameters.AddWithValue("cuit", proveedor.cuit);
                    cmd.Parameters.AddWithValue("razon_social", proveedor.razon_social);
                    cmd.Parameters.AddWithValue("email", proveedor.email);
                    cmd.Parameters.AddWithValue("telefono", proveedor.telefono);
                    cmd.Parameters.AddWithValue("estado", proveedor.estado);
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

        // Función que elimina un proveedor de la BD
        public bool Eliminar(Proveedor proveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Eliminar_Proveedor", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_proveedor", proveedor.id_proveedor);
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
