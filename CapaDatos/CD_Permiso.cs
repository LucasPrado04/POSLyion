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
    public class CD_Permiso
    {
        public List<Permiso> Listar(int id_usuario)
        {
            List<Permiso> lista = new List<Permiso>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se crea la cadena de consulta
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT permiso.id_rol, nombre_menu FROM Permiso");
                    query.AppendLine("INNER JOIN Rol ON permiso.id_rol = rol.id_rol");
                    query.AppendLine("INNER JOIN Usuario ON usuario.id_rol = rol.id_rol");
                    query.AppendLine("WHERE usuario.id_usuario = @id_usuario");
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), con);
                    // Se especifica que el comando es de tipo texto
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Usuarios, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Usuario por cada registro con sus atributos
                            lista.Add(new Permiso()
                            {
                                Rol = new Rol() { id_rol = Convert.ToInt32(reader["id_rol"]) },
                                nombre_menu = reader["nombre_menu"].ToString()
                            }); ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Permiso>();
                }
            }
            return lista;
        }
    }
}
