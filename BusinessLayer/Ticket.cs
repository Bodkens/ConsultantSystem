using System;
using System.Data.SQLite;
using DataLayer;

namespace BusinessLayer
{
	public class Ticket 
	{
        public int TicketID { get; private set;}
		public string Contact { get; set;}
        public string Problem { get; set;}
        public string Description { get; set; }
        public Consultant? AssignedConsultant { get; set; }// Foreign Key Mapping
        public string State { get; set; }

		public Ticket(int id, string contact, string problem, string description, Consultant? consultant, string state)
		{
            this.TicketID = id;
			this.Contact = contact;
			
			this.Problem = problem;
			this.Description = description;
            this.AssignedConsultant = consultant;
			this.State = state;
		}
    }
}

