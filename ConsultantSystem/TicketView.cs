using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultantSystem
{
    public partial class TicketView : UserControl
    {

        public Ticket CurrentTicket { get; set; } = new Ticket(0, " ", " ", " ", null, " ");

        private string _contactText = "";
        public string ContactText 
        {
            get
            {
                return _contactText;
            }
            set
            {
                contactLabel.Text = value;
                _contactText = value;
            }
        }
        private string _problemText = "";
        public string ProblemText
        {
            get
            {
                return _problemText;
            }
            set
            {
                problemLabel.Text = value;
                _problemText = value;
            }
        }
        private string _descriptionText = "";
        public string DescriptionText
        {
            get
            {
                return _descriptionText;
            }
            set
            {
                descriptionLabel.Text = value;
                _descriptionText = value;
            }
        }
        private string _buttonText = "Assign";
        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                assignButton.Text = value;
                _buttonText = value;
            }
        }

        private bool _returnVisible;
        public bool ReturnVisible 
        {
            get 
            {
                return this._returnVisible;
            }
            set
            {
                _returnVisible = value;
                returnButton.Visible = value;
            }
        }

        private bool _deleteVisible;
        public bool DeleteVisible
        {
            get
            {
                return this._deleteVisible;
            }
            set
            {
                _deleteVisible = value;
                deleteButton.Visible = value;
            }
        }

        public TicketView()
        {
            InitializeComponent();
        }

        

        private void assignButton_Click(object sender, EventArgs e)
        {

            

            if (this.CurrentTicket.State == "NEW")
            {
                if (!TicketManager.AssignTicket(this.CurrentTicket))
                {
                    MessageBox.Show("Something went wrong during Ticket operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }
                ConsultantForm.GlobalReload();
                return;
            }

            if (this.CurrentTicket.State == "ASSIGNED")
            {
                if (!TicketManager.CloseTicket(this.CurrentTicket))
                {
                    MessageBox.Show("Something went wrong during Ticket operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                ConsultantForm.GlobalReload();
                return;
            }

            

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (!TicketManager.ReturnTicket(this.CurrentTicket))
            {
                MessageBox.Show("Something went wrong during Ticket operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConsultantForm.GlobalReload();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!TicketManager.DeleteTicket(this.CurrentTicket) && LoginManager.consultant?.IsAdmin != true)
            {
                MessageBox.Show("Something went wrong during Ticket operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ConsultantForm.GlobalReload();
        }
    }
}
