namespace DataLayer;

using System;
using System.Data.SQLite;
using System.Text;

public abstract class DatabaseCreator
{
    

    public static void CreateDatabase(string path)
    {
        SQLiteConnection.CreateFile(path);

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendFormat("Data Source={0};Version=3;", path);

        SQLiteConnection connection = new SQLiteConnection(stringBuilder.ToString());
        connection.Open();
        DatabaseCreator.CreateUserTable(connection);   
        DatabaseCreator.CreateConsultantTable(connection);
        DatabaseCreator.CreatePlatformTable(connection);
        DatabaseCreator.CreateCategoryTable(connection);
        DatabaseCreator.CreateGameTable(connection);
        DatabaseCreator.CreateKeyTable(connection);
        DatabaseCreator.CreateTicketTable(connection);
        connection.Close();
    }

    


    private static void CreateUserTable(SQLiteConnection connection)
    {
        

        string creationString = "CREATE TABLE user (" +
            "user_id INTEGER UNIQUE NOT NULL PRIMARY KEY AUTOINCREMENT, " +
            "login VARCHAR(20) CHECK(LENGTH(login) >= 5) UNIQUE NOT NULL, " +
            "password VARCHAR(20) CHECK(LENGTH(password) >= 8) NOT NULL, " +
            "card_number BIGINT(16), " +
            "expiracy_date DATE, " +
            "cvv INT(3)" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

        
    }
    private static void CreateConsultantTable(SQLiteConnection connection)
    {


        string creationString = "CREATE TABLE consultant (" +
            "consultant_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "login VARCHAR(20) CHECK(LENGTH(login) >= 5) NOT NULL UNIQUE, " +
            "password VARCHAR(20) CHECK(LENGTH(password) >= 8) NOT NULL, " +
            "first_name VARCHAR(20) NOT NULL, " +
            "last_name VARCHAR(20) NOT NULL, " +
            "salary INT(5) NOT NULL, " +
            "is_admin BIT NOT NULL" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();
    }
    private static void CreatePlatformTable(SQLiteConnection connection)
    {
        

        string creationString = "CREATE TABLE platform(" +
            "platform_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "name VARCHAR(20) NOT NULL UNIQUE" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

        
    }
    private static void CreateCategoryTable(SQLiteConnection connection)
    {
       

        string creationString = "CREATE TABLE category (" +
            "category_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "name VARCHAR(20) UNIQUE NOT NULL" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

       
    }
    private static void CreateGameTable(SQLiteConnection connection)
    {
       

        string creationString = "CREATE TABLE game (" +
            "game_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "name VARCHAR(50) NOT NULL, " +
            "description VARCHAR(255), " +
            "category_id INT NOT NULL, " +
            "platform_id INT NOT NULL, " +
            "popularity INT, " +
            "rating FLOAT(2), " +
            "price_usd SMALLMONEY NOT NULL, " +
            "sale_percent INT(3) CHECK(sale_percent >= 0 AND sale_percent <= 100) NOT NULL, " +
            "FOREIGN KEY(category_id) REFERENCES category(category_id), " +
            "FOREIGN KEY(platform_id) REFERENCES platform(platform_id)" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

        
    }
    private static void CreateKeyTable(SQLiteConnection connection)
    {
        

        string creationString = "CREATE TABLE key(" +
            "key_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "value VARCHAR(30) NOT NULL UNIQUE, " +
            "game_id INT NOT NULL, " +
            "user_id INT, " +
            "FOREIGN KEY(game_id) REFERENCES game(game_id), " +
            "FOREIGN KEY(user_id) REFERENCES user(user_id))";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

        
    }
    private static void CreateTicketTable(SQLiteConnection connection)
    {
        

        string creationString = "CREATE TABLE ticket(" +
            "ticket_id INTEGER NOT NULL UNIQUE PRIMARY KEY AUTOINCREMENT, " +
            "contact VARCHAR(30), " +
            "user_id INT ," +
            "problem VARCHAR(30) NOT NULL, " +
            "description TEXT NOT NULL, " +
            "consultant_id INT, " +
            "state VARCHAR(10) NOT NULL CHECK(state = 'NEW' OR state = 'ASSIGNED' OR state = 'CLOSED'), " +
            "FOREIGN KEY(consultant_id) REFERENCES consultant(consultant_id), " +
            "FOREIGN KEY(user_id) REFERENCES user(user_id)" +
            ")";

        SQLiteCommand creationCommand = new SQLiteCommand(creationString, connection);

        creationCommand.ExecuteNonQuery();

       
    }




}