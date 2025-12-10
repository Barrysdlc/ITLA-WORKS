using CarpinteriaAdolf.Models;
using CarpinteriaAdolf_Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CarpinteriaAdolf.Data
{
    public class MuebleRepositorio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public List<mueble> Listar()
        {
            var lista = new List<mueble>();

            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT IdMueble, Nombre, Descripcion, PrecioBase, TiempoProduccion FROM Mueble", cn))
            {
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new mueble
                        {
                            IdMueble = (int)dr["IdMueble"],
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString(),
                            PrecioBase = (decimal)dr["PrecioBase"],
                            TiempoProduccion = (int)dr["TiempoProduccion"]
                        });
                    }
                }
            }

            return lista;
        }

        public void Insertar(mueble m)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "INSERT INTO Mueble (Nombre, Descripcion, PrecioBase, TiempoProduccion) " +
                "VALUES (@n, @d, @p, @t)", cn))
            {
                cmd.Parameters.AddWithValue("@n", m.Nombre ?? "");
                cmd.Parameters.AddWithValue("@d", m.Descripcion ?? "");
                cmd.Parameters.AddWithValue("@p", m.PrecioBase);
                cmd.Parameters.AddWithValue("@t", m.TiempoProduccion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(mueble m)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "UPDATE Mueble SET Nombre=@n, Descripcion=@d, PrecioBase=@p, TiempoProduccion=@t " +
                "WHERE IdMueble=@id", cn))
            {
                cmd.Parameters.AddWithValue("@n", m.Nombre ?? "");
                cmd.Parameters.AddWithValue("@d", m.Descripcion ?? "");
                cmd.Parameters.AddWithValue("@p", m.PrecioBase);
                cmd.Parameters.AddWithValue("@t", m.TiempoProduccion);
                cmd.Parameters.AddWithValue("@id", m.IdMueble);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "DELETE FROM Mueble WHERE IdMueble=@id", cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

