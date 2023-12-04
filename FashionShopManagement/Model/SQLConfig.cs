namespace FashionShopApp.Model
{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;

    public class SQLConfig
    {
        //SqlConnection connection = new SqlConnection("Server=VANANH;Database=QL_FashionShop;User Id=sa;Password=123;");
        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1LB6J34\\SQLEXPRESS;Initial Catalog=FashionShopManagement;Integrated Security=True");
        private SqlConnection connection;

        // Phương thức khởi tạo với chuỗi kết nối
        public SQLConfig(string username, string password)
        {
            connection = new SqlConnection(string.Format("Server=DESKTOP-1LB6J34\\SQLEXPRESS;Database=FashionShopManagement;User Id={0};Password={1};",username,password));
        }

        //Truy vấn
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        // Lấy bảng dữ liệu
        public DataTable ExecuteSelectQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        //Lấy 1 kiểu dữ liệu
        public object ExecuteScalar(string query)
        {
            object result = null;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                result = command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public bool ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }

}