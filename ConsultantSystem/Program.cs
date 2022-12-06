using BusinessLayer;
using System.Data.SQLite;
using DataLayer;

namespace ConsultantSystem
{
    internal static class Program
    {
        

        //Identity Map, checks if ticket already added
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        //Loading new unassigned tickets from database to a List<Ticket>
        
        //Loading nassigned to current consultant tickets from database to a List<Ticket>
        

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            
            Application.Run(new LoginForm());
        }
    }
}