using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplicacionPos
{    
    class BBDD
    {
        SqlConnection conexion = new SqlConnection();

        public BBDD(string user, string pass)
        {
            string cadena = $"server = LAPTOP-99JPHKNE; database = dbTienda; user id = {user}; password = {pass}";
            conexion.ConnectionString = cadena;
        }
        public bool Conectar()
        {
            conexion.Close();
            try
            {
                conexion.Open();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
                return false;
            }
        }

        public void Desconectar()
        {
            conexion.Close();
        }

        public bool comando(string query)
        {
            SqlCommand comando = new SqlCommand(query, conexion);

            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error !", ex.Message);
                return false;
            }
        }
        public bool comando(string cVenta, int Cantidad, string cProd)
        {
            string query;
            query = "insert into tblVenta values (@venta,@cantidad,@producto)";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@venta", cVenta);
            comando.Parameters.AddWithValue("@cantidad", Cantidad);
            comando.Parameters.AddWithValue("@producto", cProd);
            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error !", ex.Message);
                return false;
            }
        }
        public bool comando(string codigo,string nombre,int precio, int stock)
        {
            string query;
            query = "insert into tblProductos values (@codigo,@nombre,@precio,@cantidad)";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", stock);
            try
            {
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error !", ex.Message);
                return false;
            }
        }
    }
}
