using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CarpinteriaAdolf.Models;
using CarpinteriaAdolf_Data;

namespace CarpinteriaAdolf.Data
{
    public class ClienteRepositorio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        // LISTAR todos los clientes
        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();

            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "SELECT IdCliente, Nombre, Direccion, Telefono, Email FROM Cliente", cn))
            {
                cn.Open(); // solo UNA vez

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Cliente
                        {
                            IdCliente = (int)dr["IdCliente"],
                            Nombre = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString()
                        });
                    }
                }
            }

            return lista;
        }


        // INSERTAR cliente nuevo
        public void Insertar(Cliente cliente)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "INSERT INTO Cliente (Nombre, Direccion, Telefono, Email) VALUES (@nombre, @direccion, @telefono, @email)", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre ?? "");
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion ?? "");
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");
                cmd.Parameters.AddWithValue("@email", cliente.Email ?? "");

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR cliente existente
        public void Actualizar(Cliente cliente)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(
                "UPDATE Cliente SET Nombre = @nombre, Direccion = @direccion, Telefono = @telefono, Email = @email WHERE IdCliente = @id", cn))
            {
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre ?? "");
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion ?? "");
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono ?? "");
                cmd.Parameters.AddWithValue("@email", cliente.Email ?? "");
                cmd.Parameters.AddWithValue("@id", cliente.IdCliente);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        
        public void Eliminar(int idCliente)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", idCliente);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // OBTENER un cliente por ID
        public Cliente ObtenerPorId(int idCliente)
        {
            using (var cn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand("SELECT IdCliente, Nombre, Direccion, Telefono, Email FROM Cliente WHERE IdCliente = @id", cn))
            {
                cmd.Parameters.AddWithValue("@id", idCliente);
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return new Cliente
                        {
                            IdCliente = (int)dr["IdCliente"],
                            Nombre = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Email = dr["Email"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}

