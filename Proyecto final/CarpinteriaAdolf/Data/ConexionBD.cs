
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarpinteriaAdolf_Data
{
    public class ConexionBD
    {
        // Nota: Integrated Security suele llevar espacio, no guion bajo.
        private readonly string _cadenaConexion =
            "Server=ADOLF\\MSSQLSERVER01;Database=Carpinteria_Adolf;Integrated Security=true;";

        public SqlConnection ObtenerConexion()
        {
            var cn = new SqlConnection(_cadenaConexion);
            // NO llamar a cn.Open() aquí
            return cn;
        }

    }
}