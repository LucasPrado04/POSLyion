using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Datos_Negocio
    {

        // Metodo para guardar los datos del negocio
        public Datos_Negocio Obtener_Datos()
        {
            Datos_Negocio negocio = new Datos_Negocio();
            // Se establece la conexión a la BD y se conultan los datos del negocio
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string consulta = "SELECT id, nombre, cuit, direccion FROM Datos_Negocio WHERE id = 1";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.CommandType = CommandType.Text;
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            negocio = new Datos_Negocio()
                            {
                                id = Convert.ToInt32(reader["id"].ToString()),
                                nombre = reader["nombre"].ToString(),
                                cuit = reader["cuit"].ToString(),
                                direccion = reader["direccion"].ToString()
                            };
                        }
                    }
                }
            } catch (Exception ex)
            {
                negocio = new Datos_Negocio();

            }
            return negocio;
        }

        // Metodo para guardar los datos de negocio
        public bool Guardar_Datos(Datos_Negocio negocio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            // Se establece la conexión a la BD y se conultan los datos del negocio
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Datos_Negocio SET nombre = @nombre,");
                    consulta.AppendLine("cuit = @cuit,");
                    consulta.AppendLine("direccion = @direccion");
                    consulta.AppendLine("WHERE id = 1;");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    cmd.Parameters.AddWithValue("@nombre", negocio.nombre);
                    cmd.Parameters.AddWithValue("@cuit", negocio.cuit);
                    cmd.Parameters.AddWithValue("@direccion", negocio.direccion);
                    cmd.CommandType = CommandType.Text;
                    // Si el número de filas afectadas en la consulta es menor a 1, significa que no se actualizaron los datos
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudieron guardar los datos";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;
        }

        // Metodo para recuperar el logo de la BD
        public byte[] Obtener_Logo(out bool obtenido)
        {
            obtenido = true;
            byte[] logo = new byte[0];
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    string consulta = "SELECT logo FROM Datos_Negocio WHERE id = 1";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            logo = (byte[])reader["logo"];
                        }
                    }
                    // Si el número de filas afectadas en la consulta es menor a 1, significa que no se actualizaron los datos
                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                logo = new byte[0];
            }
            return logo;
        }

        public bool Actualizar_Logo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            // Se establece la conexión a la BD y se conultan los datos del negocio
            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    con.Open();
                    StringBuilder consulta = new StringBuilder();
                    consulta.AppendLine("UPDATE Datos_Negocio SET logo = @imagen");
                    consulta.AppendLine("WHERE id = 1;");
                    SqlCommand cmd = new SqlCommand(consulta.ToString(), con);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.CommandType = CommandType.Text;
                    // Si el número de filas afectadas en la consulta es menor a 1, significa que no se actualizaron los datos
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;
        }
    }
}
