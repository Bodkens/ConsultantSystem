using DataLayer;
using BusinessLayer;
namespace ConsultantSystem
{
    public partial class ConsultantForm : Form
    {
        public ConsultantForm()
        {
            InitializeComponent();
        }

        public static FlowLayoutPanel newTicketsPanelStatic = new FlowLayoutPanel();
        public static FlowLayoutPanel myTicketsPanelStatic = new FlowLayoutPanel();
        public static void GlobalReload()
        {
            ReloadNewTickets();
            ReloadMyTickets();
        }

        private void ConsultantForm_Load(object sender, EventArgs e)
        {
            newTicketsPanelStatic = newTicketsPanel;
            myTicketsPanelStatic = myTicketsPanel;
            loginLabel.Text = LoginManager.consultant?.Login;
            firstLastNameLabel.Text = $"{LoginManager.consultant?.FirstName} {LoginManager.consultant?.LastName}";
            isAdminLabel.Text = (LoginManager.consultant?.IsAdmin == true) ? "Admin" : "Consultant";
            isAdminLabel.ForeColor = (LoginManager.consultant?.IsAdmin == true) ? Color.OrangeRed : Color.Olive;

            GlobalReload();
            
        }
        //Reloading FlowControlPanel with unassigned tickets
        public static void ReloadNewTickets()
        {
            TicketManager.LoadNewTicketsList();
            newTicketsPanelStatic.Controls.Clear();
            for (int i = 0; i < TicketManager.NewTickets.Count; i++)
            {



                TicketView ticketView = new TicketView();

                ticketView.CurrentTicket = TicketManager.NewTickets[i];
                

                ticketView.ContactText = TicketManager.NewTickets[i].Contact;
                ticketView.ProblemText = TicketManager.NewTickets[i].Problem;
                ticketView.DescriptionText = TicketManager.NewTickets[i].Description;
                ticketView.ReturnVisible = false;
                ticketView.DeleteVisible = false;
                if (LoginManager.consultant?.IsAdmin == true)
                {
                    ticketView.DeleteVisible = true;
                }
                
                ticketView.ButtonText = "Assign";

                newTicketsPanelStatic.Controls.Add(ticketView);
            }
        }

        //Reloading FlowControlPanel with consultants assigned tickets
        public static void ReloadMyTickets()
        {
            
            TicketManager.LoadMyTicketsList();
            myTicketsPanelStatic.Controls.Clear();
            for (int i = 0; i < TicketManager.MyTickets.Count; i++)
            {


                TicketView ticketView = new TicketView();

                ticketView.CurrentTicket = TicketManager.MyTickets[i];
                
                ticketView.ContactText = TicketManager.MyTickets[i].Contact;
                ticketView.ProblemText = TicketManager.MyTickets[i].Problem;
                ticketView.DescriptionText = TicketManager.MyTickets[i].Description;
                ticketView.ReturnVisible = true;
                ticketView.DeleteVisible = false;
                ticketView.ButtonText = "Close";

                myTicketsPanelStatic.Controls.Add(ticketView);
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            GlobalReload(); 
        }
        private void ConsultantForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string? login = LoginManager.consultant?.Login;
            Log log = new Log(login == null ? "undefined" : login, "Signing Out");
            log.WriteLog();
        }
    }
}