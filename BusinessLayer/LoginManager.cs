using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoginManager
    {
        public static Consultant? consultant; //Logged Consultant

        //Logging Into System
        public static bool TryLogin(string login, string password)
        {


            Gateway.OpenConnectionToDatabase();


            SQLiteDataReader reader = Gateway.ExecuteReaderCommand(
                $"SELECT * " +
                $"FROM consultant " +
                $"WHERE login = '{login}' AND password = '{PasswordEncryptor.Encrypt(password)}'"
                );

            List<string?[]> loaded = new List<string?[]>();

            while (reader.Read())
            {
                string?[] line = new string?[7];

                line[0] = reader["consultant_id"]?.ToString();
                line[1] = reader["login"]?.ToString();
                line[2] = reader["password"]?.ToString();
                line[3] = reader["first_name"]?.ToString();
                line[4] = reader["last_name"]?.ToString();
                line[5] = reader["salary"]?.ToString();
                line[6] = reader["is_admin"]?.ToString();
                loaded.Add(line);
            }

            if (loaded.Count < 1)
            {
                return false;
            }

            string? id = loaded[0][0];
            string? consultant_login = loaded[0][1];
            string? consultant_password = loaded[0][2];

            string? first_name = loaded[0][3];
            string? last_name = loaded[0][4];
            string? salary = loaded[0][5];
            string? is_admin = loaded[0][6];

            LoginManager.consultant = new Consultant(
                id == null ? 0 : int.Parse(id),
                consultant_login == null ? "no_login" : consultant_login,
                consultant_password == null ? "no_password" : consultant_password,
                first_name == null ? "no_name" : first_name,
                last_name == null ? "no_surname" : last_name,
                salary == null ? 0 : int.Parse(salary),
                is_admin == "True" ? true : false
                );



            Gateway.CloseConnectionToDatabase();
            
            return true;
        }

    }
}
