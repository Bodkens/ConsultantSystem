using System;
using System.Data.SQLite;
using System.Text;

namespace DataLayer
{
    public abstract class Gateway
    {

        private static SQLiteConnection connection = new SQLiteConnection("");

        private static string path = @"F:\VP\ConsultantSystem\database.db";


        public static void SetDatabasePath(string path)
        {
            Gateway.path = path;
        }
        public static void OpenConnectionToDatabase()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendFormat("Data Source={0};Version=3;", path);

            Gateway.connection = new SQLiteConnection(stringBuilder.ToString());

            Gateway.connection.Open();
        }

        public static void CloseConnectionToDatabase()
        {


            Gateway.connection.Close();
        }


        public static void ExecuteNonQuerryCommand(string stringCommand)
        {


            SQLiteCommand command = new SQLiteCommand(stringCommand, Gateway.connection);

            command.ExecuteNonQuery();


        }
        public static SQLiteDataReader ExecuteReaderCommand(string stringCommand)
        {


            SQLiteCommand command = new SQLiteCommand(stringCommand, Gateway.connection);

            SQLiteDataReader reader = command.ExecuteReader();



            return reader;
        }
    }
}

