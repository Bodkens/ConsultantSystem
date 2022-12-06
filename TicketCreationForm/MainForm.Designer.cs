namespace TicketCreationForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redText = new System.Windows.Forms.Label();
            this.ticketCreationButton = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.problemLabel = new System.Windows.Forms.Label();
            this.problemTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // redText
            // 
            this.redText.AutoSize = true;
            this.redText.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redText.ForeColor = System.Drawing.Color.Red;
            this.redText.Location = new System.Drawing.Point(12, 28);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(788, 78);
            this.redText.TabIndex = 0;
            this.redText.Text = "Need any help or have some problem?\r\nFill form below to create ticket and consult" +
    "ant will contact you";
            // 
            // ticketCreationButton
            // 
            this.ticketCreationButton.Location = new System.Drawing.Point(366, 435);
            this.ticketCreationButton.Name = "ticketCreationButton";
            this.ticketCreationButton.Size = new System.Drawing.Size(142, 37);
            this.ticketCreationButton.TabIndex = 1;
            this.ticketCreationButton.Text = "Create ticket";
            this.ticketCreationButton.UseVisualStyleBackColor = true;
            this.ticketCreationButton.Click += new System.EventHandler(this.ticketCreationButton_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.emailTextbox.Location = new System.Drawing.Point(33, 147);
            this.emailTextbox.MaxLength = 50;
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(165, 23);
            this.emailTextbox.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(33, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(39, 15);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(33, 193);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(52, 15);
            this.problemLabel.TabIndex = 5;
            this.problemLabel.Text = "Problem";
            // 
            // problemTextbox
            // 
            this.problemTextbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.problemTextbox.Location = new System.Drawing.Point(33, 211);
            this.problemTextbox.MaxLength = 50;
            this.problemTextbox.Name = "problemTextbox";
            this.problemTextbox.Size = new System.Drawing.Size(165, 23);
            this.problemTextbox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(33, 257);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(33, 287);
            this.descriptionTextBox.MaxLength = 355;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(807, 131);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 484);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.problemTextbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.ticketCreationButton);
            this.Controls.Add(this.redText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Ticket Creation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label redText;
        private Button ticketCreationButton;
        private Label emailLabel;
        private Label problemLabel;
        private Label descriptionLabel;
        public TextBox emailTextbox;
        public TextBox problemTextbox;
        public RichTextBox descriptionTextBox;
    }
}