using System;
using System.Data.SQLite;
using DataLayer;

namespace BusinessLayer
{
    public class Consultant : UserBase
    {
  

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Salary { get; set; }
        public bool IsAdmin { get; set; }

        public Consultant(int id, string login, string password, string firstName, string lastName, int salary, bool isAdmin) : base(id, login, password)
        {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.IsAdmin = isAdmin;
        }

        public void Insert()
        {


            try
            {
                Gateway.ExecuteNonQuerryCommand(

                $"INSERT INTO consultant(login, password, first_name, last_name, salary, is_admin) VALUES('{this.Login}', '{this.Password}', '{this.FirstName}', '{this.LastName}', {this.Salary}, {(this.IsAdmin ? 1 : 0)})");
            }
            catch
            {
                Console.WriteLine("SQL Error!");
            }

        }
        public void Update(string login, string password, string firstName, string lastName, int salary, bool isAdmin)
        {


            try
            {
                Gateway.ExecuteNonQuerryCommand(
                    $"UPDATE consultant" +
                    $"SET login = '{login}', " +
                    $"SET password = '{password}', " +
                    $"SET first_name = '{firstName}', " +
                    $"SET last_name = '{lastName}', " +
                    $"SET salary = {salary}, " +
                    $"SET is_admin = {(isAdmin ? 1 : 0)} " +
                    $"WHERE login = '{this.Login}'"
                    );
            }
            catch
            {
                Console.WriteLine("SQL Error!");
            }
        }

       

        public void Delete()
        {
            try
            {
                Gateway.ExecuteNonQuerryCommand(
                   $"DELETE FROM consultant WHERE login = '{this.Login}'"
                    );
            }
            catch
            {
                Console.WriteLine("SQL Error!");
            }
        }



    }
}

