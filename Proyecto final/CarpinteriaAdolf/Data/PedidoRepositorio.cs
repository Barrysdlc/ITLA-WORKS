using CarpinteriaAdolf.Models;
using CarpinteriaAdolf_Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CarpinteriaAdolf.Data
{
    public class PedidoRepositorio
    {
        private readonly ConexionBD _conexion = new ConexionBD();

        public int InsertarPedido(Pedido pedido, List<PedidoDetalle> detalles)
        {
            using (var cn = _conexion.ObtenerConexion())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        // Insertar encabezado
                        var cmdPedido = new SqlCommand(
                            "INSERT INTO Pedido (IdCliente, FechaPedido, FechaEntrega, Estado, CostoTotal) " +
                            "OUTPUT INSERTED.IdPedido " +
                            "VALUES (@idCliente, @fechaPedido, @fechaEntrega, @estado, @costoTotal)", cn, tx);

                        cmdPedido.Parameters.AddWithValue("@idCliente", pedido.IdCliente);
                        cmdPedido.Parameters.AddWithValue("@fechaPedido", pedido.FechaPedido);
                        cmdPedido.Parameters.AddWithValue("@fechaEntrega", (object)pedido.FechaEntrega ?? DBNull.Value);
                        cmdPedido.Parameters.AddWithValue("@estado", pedido.Estado ?? "Pendiente");
                        cmdPedido.Parameters.AddWithValue("@costoTotal", pedido.CostoTotal);

                        int idPedido = (int)cmdPedido.ExecuteScalar();

                        // Insertar detalles
                        foreach (var d in detalles)
                        {
                            var cmdDet = new SqlCommand(
                                "INSERT INTO PedidoMueble (IdPedido, IdMueble, Cantidad, Subtotal) " +
                                "VALUES (@idPedido, @idMueble, @cant, @sub)", cn, tx);

                            cmdDet.Parameters.AddWithValue("@idPedido", idPedido);
                            cmdDet.Parameters.AddWithValue("@idMueble", d.IdMueble);
                            cmdDet.Parameters.AddWithValue("@cant", d.Cantidad);
                            cmdDet.Parameters.AddWithValue("@sub", d.Subtotal);

                            cmdDet.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return idPedido;
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}

