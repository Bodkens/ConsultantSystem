using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketManager //TableDataGateway
    {
        public static List<Ticket> NewTickets { get; private set; } = new List<Ticket>(); //Tickets that have NEW state and are unassigned

        public static List<Ticket> MyTickets { get; private set; } = new List<Ticket>(); //Tickets that have ASSIGNED state and are assigned to current consultant

        public static bool InsertTicket(Ticket ticket)
        {
            Gateway.OpenConnectionToDatabase();

            try
            {
                Gateway.ExecuteNonQuerryCommand(

                $"INSERT INTO ticket(contact, user_id, problem, description, consultant_id, state) VALUES('{ticket.Contact}', NULL , '{ticket.Problem}', '{ticket.Description}', {(ticket.AssignedConsultant?.ID == null ? "NULL" : ticket.AssignedConsultant?.ID)}, '{ticket.State}')"
                );
            }
            catch
            {
                Console.WriteLine("SQL Error!");
                return false;
            }


            Gateway.CloseConnectionToDatabase();

            return true;
        }
        public static void LoadNewTicketsList()
        {
            Gateway.OpenConnectionToDatabase();
            SQLiteDataReader loadedTickets = Gateway.ExecuteReaderCommand
                (
                    "SELECT * " +
                    "FROM ticket " +
                    "WHERE state = 'NEW'"
                );
            while (loadedTickets.Read())
            {
                string? _id = loadedTickets["ticket_id"]?.ToString();
                int id = 0;
                if (_id != null)
                {
                    id = int.Parse(_id.ToString());
                }

                string? _contact = loadedTickets["contact"]?.ToString();
                string contact = "";
                if (_contact != null)
                {
                    contact = _contact;
                }

                string? _problem = loadedTickets["problem"]?.ToString();
                string problem = "";
                if (_problem != null)
                {
                    problem = _problem;
                }

                string? _description = loadedTickets["description"]?.ToString();
                string description = "";
                if (_description != null)
                {
                    description = _description;
                }

                string? _state = loadedTickets["state"]?.ToString();
                string state = "";
                if (_state != null)
                {
                    state = _state;
                }

                Ticket ticket = new Ticket(id, contact, problem, description, null, state);
                if (!TicketIdentityMapCheckExistByID(id, TicketManager.NewTickets))
                {
                    NewTickets.Add(ticket);
                }


            }

            Gateway.CloseConnectionToDatabase();
        }


        public static void LoadMyTicketsList()
        {

            Gateway.OpenConnectionToDatabase();
            SQLiteDataReader loadedTickets = Gateway.ExecuteReaderCommand
                (
                    "SELECT * " +
                    "FROM ticket " +
                    $"WHERE state = 'ASSIGNED' AND consultant_id = {LoginManager.consultant?.ID}"
                );

            while (loadedTickets.Read())
            {
                string? _id = loadedTickets["ticket_id"]?.ToString();
                int id = 0;
                if (_id != null)
                {
                    id = int.Parse(_id.ToString());
                }

                string? _contact = loadedTickets["contact"]?.ToString();
                string contact = "";
                if (_contact != null)
                {
                    contact = _contact;
                }

                string? _problem = loadedTickets["problem"]?.ToString();
                string problem = "";
                if (_problem != null)
                {
                    problem = _problem;
                }

                string? _description = loadedTickets["description"]?.ToString();
                string description = "";
                if (_description != null)
                {
                    description = _description;
                }


                string? _state = loadedTickets["state"]?.ToString();
                string state = "";
                if (_state != null)
                {
                    state = _state;
                }

                Ticket ticket = new Ticket(id, contact, problem, description, null, state);
                if (!TicketIdentityMapCheckExistByID(id, TicketManager.MyTickets))
                {
                    MyTickets.Add(ticket);
                }
            }

            Gateway.CloseConnectionToDatabase();
        }

        private static bool TicketIdentityMapCheckExistByID(int id, List<Ticket> ticketList)
        {

            for (int i = 0; i < ticketList.Count; i++)
            {
                if (ticketList[i].TicketID == id)
                {
                    return true;
                }
            }

            return false;
        }
        //Deletes ticket from NewTickets by ID
        public static void TicketDeleteFromNewListByID(int id)
        {
            List<Ticket> newList = new List<Ticket>();
            for (int i = 0; i < NewTickets.Count; i++)
            {
                if (NewTickets[i].TicketID != id)
                {
                    newList.Add(NewTickets[i]);
                }
            }

            NewTickets.Clear();

            NewTickets.AddRange(newList);
        }
        //Deletes ticket from MyTickets by ID
        public static void TicketDeleteFromMyListByID(int id)
        {
            List<Ticket> newList = new List<Ticket>();
            for (int i = 0; i < MyTickets.Count; i++)
            {
                if (MyTickets[i].TicketID != id)
                {
                    newList.Add(MyTickets[i]);
                }
            }

            MyTickets.Clear();

            MyTickets.AddRange(newList);
        }

        public static bool AssignTicket(Ticket ticket)
        {
            if (ticket.State == "NEW")
            {
                Gateway.OpenConnectionToDatabase();
                Gateway.ExecuteNonQuerryCommand($"UPDATE ticket " +
                    $"SET state = 'ASSIGNED', consultant_id = {LoginManager.consultant?.ID} WHERE ticket_id = {ticket.TicketID} AND state = 'NEW'");
                ticket.AssignedConsultant = LoginManager.consultant;
                ticket.State = "ASSIGNED";
                
                TicketManager.TicketDeleteFromNewListByID(ticket.TicketID);
                
                Gateway.CloseConnectionToDatabase();
                return true;
            }
            return false;
        }
        public static bool ReturnTicket(Ticket ticket)
        {
            if (ticket.State == "ASSIGNED")
            {
                Gateway.OpenConnectionToDatabase();
                Gateway.ExecuteNonQuerryCommand($"UPDATE ticket " +
                    $"SET state = 'NEW', consultant_id = NULL WHERE ticket_id = {ticket.TicketID} AND state = 'ASSIGNED'");
                
                ticket.AssignedConsultant = null;
                TicketManager.TicketDeleteFromMyListByID(ticket.TicketID);
                Gateway.CloseConnectionToDatabase();
                return true;
            }

            return false;
        }
        public static bool CloseTicket(Ticket ticket)
        {

            if (ticket.State == "ASSIGNED")
            {
                Gateway.OpenConnectionToDatabase();
                Gateway.ExecuteNonQuerryCommand($"UPDATE ticket " +
                    $"SET state = 'CLOSED' WHERE ticket_id = {ticket.TicketID} AND consultant_id = {LoginManager.consultant?.ID} AND state = 'ASSIGNED'");
                
                ticket.State = "CLOSED";
               
                TicketManager.TicketDeleteFromMyListByID(ticket.TicketID);
                Gateway.CloseConnectionToDatabase();
                return true;
            }

            return false;
        }

        public static bool DeleteTicket(Ticket ticket)
        {
            if (ticket.State == "NEW")
            {
                Gateway.OpenConnectionToDatabase();
                Gateway.ExecuteNonQuerryCommand($"DELETE FROM ticket " +
                    $"WHERE ticket_id = {ticket.TicketID} AND state = 'NEW'");
                
                TicketManager.TicketDeleteFromNewListByID(ticket.TicketID);
                Gateway.CloseConnectionToDatabase();
                return true;
            }
            return false;
        }


    }
}
