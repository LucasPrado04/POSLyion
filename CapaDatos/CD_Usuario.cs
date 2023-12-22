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
        public List<Usuario> Listar() {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection con = new SqlConnection(Conexion.cadena)) {
                try {
                    string consulta = "SELECT id_usuario, dni, nombre_completo, email, clave, estado FROM Usuario";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
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
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
    }
}
