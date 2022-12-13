using MySql.Data.MySqlClient;

namespace Parsik
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=2332386stabfurer;database=students");
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
