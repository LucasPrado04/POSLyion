using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Net;
using System.Security.Claims;

namespace CapaDatos
{
    public class CD_Usuario {
        // Funcion que retorna una lista de usuarios de la BD
        public List<Usuario> Listar() {
            List<Usuario> lista = new List<Usuario>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena)) {
                try {
                    // Se crea la cadena de consulta
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("SELECT usuario.id_usuario, usuario.dni, usuario.nombre_completo,usuario.email, usuario.clave, usuario.estado, rol.id_rol, rol.descripcion FROM Usuario");
                    consulta.AppendLine("INNER JOIN Rol ON usuario.id_rol = rol.id_rol");
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        // Mientras lee cada uno de los registros de la tabla Usuarios, realiza:
                        while (reader.Read()) {
                            // Crea un nuevo objeto de tipo Usuario por cada registro con sus atributos
                            lista.Add(new Usuario() {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                dni = reader["dni"].ToString(),
                                nombre_completo = reader["nombre_completo"].ToString(),
                                email = reader["email"].ToString(),
                                clave = reader["clave"].ToString(),
                                Rol = new Rol() { id_rol = Convert.ToInt32(reader["id_rol"]), descripcion = reader["descripcion"].ToString() },
                                estado = Convert.ToBoolean(reader["estado"])
                            });
                        }
                    }
                } catch (Exception ex) {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        // Función que registra un usuario en la BD
        public int Registrar(Usuario usuario, out string mensaje)
        {
            int id_usuario_generado = 0;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Agregar_Usuario", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("dni", usuario.dni);
                    cmd.Parameters.AddWithValue("nombre_completo", usuario.nombre_completo);
                    cmd.Parameters.AddWithValue("email", usuario.email);
                    cmd.Parameters.AddWithValue("clave", usuario.clave);
                    cmd.Parameters.AddWithValue("id_rol", usuario.Rol.id_rol);
                    cmd.Parameters.AddWithValue("estado", usuario.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("id_usuario_resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    id_usuario_generado = Convert.ToInt32(cmd.Parameters["id_usuario_resultado"].Value);
                    mensaje = cmd.Parameters["mensaje"].Value.ToString();
                }
            } catch (Exception ex)
            {
                id_usuario_generado = 0;
                mensaje = ex.Message;
            }
            return id_usuario_generado;
        }

        // Función que edita un usuario de la BD
        public bool Editar(Usuario usuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Editar_Usuario", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_usuario", usuario.id_usuario);
                    cmd.Parameters.AddWithValue("dni", usuario.dni);
                    cmd.Parameters.AddWithValue("nombre_completo", usuario.nombre_completo);
                    cmd.Parameters.AddWithValue("email", usuario.email);
                    cmd.Parameters.AddWithValue("clave", usuario.clave);
                    cmd.Parameters.AddWithValue("id_rol", usuario.Rol.id_rol);
                    cmd.Parameters.AddWithValue("estado", usuario.estado);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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

        // Función que elimina un usuario de la BD
        public bool Eliminar(Usuario usuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;
            try
            {
                // Se establece conexión con la base de datos
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    // Se crea el comando que recibe como parámetro el procedimiento almacenado y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand("Eliminar_Usuario", con);
                    // Se definen los parámetros de entrada del procedimiento almacenado
                    cmd.Parameters.AddWithValue("id_usuario", usuario.id_usuario);
                    // Se definen los parámetros de salida del procedimiento almacenado
                    cmd.Parameters.Add("respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    // Se especifica que el comando es de tipo procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se abre la conexión con la base de datos y se envía la ejecución del procedimiento almacenado
                    con.Open();
                    cmd.ExecuteNonQuery();
                    // Se recuperan los parámetros de salida
                    respuesta = Convert.ToBoolean(cmd.Parameters["respuesta"].Value);
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
