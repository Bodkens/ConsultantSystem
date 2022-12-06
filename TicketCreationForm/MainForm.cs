using DataLayer;
using BusinessLayer;
namespace TicketCreationForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void ticketCreationButton_Click(object sender, EventArgs e)
        {
            if (!(emailTextbox.Text.Length > 0 && problemTextbox.Text.Length > 0 && descriptionTextBox.Text.Length > 0))
            {
                MessageBox.Show("Please fill all neccesery forms", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            

            Ticket ticket = new Ticket(0, emailTextbox.Text, problemTextbox.Text, descriptionTextBox.Text, null, "NEW");

            if (TicketGateway.InsertTicket(ticket))
            {
                MessageBox.Show("Ticket created succesfully. Consultants will contact you as soon as possible", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong while adding ticket", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
    }
}