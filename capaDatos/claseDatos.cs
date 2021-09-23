using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
   public class claseDatos
    {
        public SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=cafeteria;User ID=sa;Password=rasta");

        public void Conectar() {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
        }

        public void Desconectar() {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }

        public DataSet Listado(string query)
        {
            Conectar();
            DataSet dt = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(query, conexion);
            ad.Fill(dt);
            Desconectar();
            return dt;
        }

        public int ejecutar(string query)
        {
            Conectar();
            SqlCommand com = new SqlCommand(query, conexion);
            int numero = com.ExecuteNonQuery();
            Desconectar();
            return numero;
        }

    }
}
