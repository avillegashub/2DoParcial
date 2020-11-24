using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class DataBase
    {
        const string STRINGCONNEC = @"Data Source =.\SQLExpress;Database=SegundoParcial;Integrated Security=true;";
        static SqlConnection sqlConn;
        static SqlCommand command;

        static DataBase()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }


        public static void TraerProductos()
        {
            string consulta = " Select * from Productos ";
            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                Comercio.productos.Clear();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Comercio.productos.Add(new Producto(int.Parse(dr["Id"].ToString()), dr["Nombre"].ToString(), float.Parse(dr["Precio"].ToString()), int.Parse(dr["TiempoP"].ToString())));
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public static void TraerClientes()
        {
            string consulta = " Select * from Clientes ";
            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    Comercio.clientes.Add(new Cliente(int.Parse(dr["ID"].ToString()), dr["Nombre"].ToString(), dr["Apellido"].ToString(), int.Parse(dr["Dni"].ToString()), dr["Direccion"].ToString()));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public static void InsertarProducto(string nombre, string precio)
        {
            string consulta = " INSERT INTO Productos ([Nombre],[Precio],[Stock]) VALUES (@Nombre ,@Precio,@Stock)";
            try
            {
                command.CommandText = consulta;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Nombre", nombre));
                command.Parameters.Add(new SqlParameter("@Precio", precio));
                command.Parameters.Add(new SqlParameter("@Stock", "0"));
                sqlConn.Open();
                int retorno = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConn.Close();
            }
        }
        public static void UpdateProducto(int id, string stock)
        {
            string consulta = " UPDATE productos  SET [Stock] = @Stock WHERE id = @id";
            try
            {
                command.CommandText = consulta;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@id", id));
                command.Parameters.Add(new SqlParameter("@Stock", stock));
                sqlConn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                sqlConn.Close();
                TraerProductos();
            }
        }
        public static void InsertarCliente(string nombre, string apellido, string dni)
        {
            string consulta = " INSERT INTO Personas ([Nombre],[Apellido],[Dni]) VALUES (@Nombre ,@Apellido,@Dni)";
            try
            {
                command.CommandText = consulta;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@Nombre", nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", apellido));
                command.Parameters.Add(new SqlParameter("@Dni", dni));
                sqlConn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
                TraerClientes();
            }
        }


    }
}

