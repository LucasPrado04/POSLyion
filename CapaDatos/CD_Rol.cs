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
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();
            // Se establece conexión con la base de datos
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se crea la cadena de consulta
                    string consulta = "SELECT id_rol, descripcion FROM Rol";
                    // Se crea el comando que recibe como parámetro la consulta y la cadena de conexión de la base de datos
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    // Se especifica que el comando es de tipo texto
                    cmd.CommandType = CommandType.Text;
                    // Se abre la conexión con la base de datos y se envía la consulta
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras lee cada uno de los registros de la tabla Rol, realiza:
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto de tipo Rol por cada registro con sus atributos
                            lista.Add(new Rol()
                            {
                                id_rol = Convert.ToInt32(reader["id_rol"]),
                                descripcion = reader["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Si la conexión con la base de datos no fue exitosa, se crea y se retorna una lista vacía
                    lista = new List<Rol>();
                }
            }
            return lista;
        }
    }
}
