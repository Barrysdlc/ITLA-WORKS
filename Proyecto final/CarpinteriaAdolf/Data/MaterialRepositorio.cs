using CarpinteriaAdolf.Models;
using CarpinteriaAdolf_Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CarpinteriaAdolf.Data
{
    public class MaterialRepositorio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<Material> Listar()
        {
            var lista = new List<Material>();

            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT IdMaterial, Nombre, UnidadMedida, CostoUnitario, StockActual FROM Material", cn))
            {
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Material
                        {
                            IdMaterial = (int)dr["IdMaterial"],
                            Nombre = dr["Nombre"].ToString(),
                            UnidadMedida = dr["UnidadMedida"].ToString(),
                            CostoUnitario = (decimal)dr["CostoUnitario"],
                            StockActual = (int)dr["StockActual"]
                        });
                    }
                }
            }

            return lista;
        }

        public void Insertar(Material m)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "INSERT INTO Material (Nombre, UnidadMedida, CostoUnitario, StockActual) " +
                "VALUES (@n, @u, @c, @s)", cn))
            {
                cmd.Parameters.AddWithValue("@n", m.Nombre ?? "");
                cmd.Parameters.AddWithValue("@u", m.UnidadMedida ?? "");
                cmd.Parameters.AddWithValue("@c", m.CostoUnitario);
                cmd.Parameters.AddWithValue("@s", m.StockActual);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Material m)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "UPDATE Material SET Nombre=@n, UnidadMedida=@u, CostoUnitario=@c, StockActual=@s " +
                "WHERE IdMaterial=@id", cn))
            {
                cmd.Parameters.AddWithValue("@n", m.Nombre ?? "");
                cmd.Parameters.AddWithValue("@u", m.UnidadMedida ?? "");
                cmd.Parameters.AddWithValue("@c", m.CostoUnitario);
                cmd.Parameters.AddWithValue("@s", m.StockActual);
                cmd.Parameters.AddWithValue("@id", m.IdMaterial);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "DELETE FROM Material WHERE IdMaterial=@id", cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
