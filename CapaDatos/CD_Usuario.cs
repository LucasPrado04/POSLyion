using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario {
        // Método que hace una consulta y devuelve un objeto de tipo lista
        public List<Usuario> Listar() {
            List<Usuario> lista = new List<Usuario>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena)) {
                try {
                    // Se crea la cadena de consulta
                    string consulta = "SELECT id_usuario, dni, nombre_completo, email, clave, estado FROM Usuario";
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta, con);
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
    }
}
