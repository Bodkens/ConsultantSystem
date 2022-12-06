namespace ConsultantSystem
{
    partial class ConsultantForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.firstLastNameLabel = new System.Windows.Forms.Label();
            this.consultantPicture = new System.Windows.Forms.PictureBox();
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.newTicketsLabel = new System.Windows.Forms.Label();
            this.myTicketsLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.newTicketsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.myTicketsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.consultantPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(1194, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(37, 15);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // firstLastNameLabel
            // 
            this.firstLastNameLabel.AutoSize = true;
            this.firstLastNameLabel.Location = new System.Drawing.Point(1194, 56);
            this.firstLastNameLabel.Name = "firstLastNameLabel";
            this.firstLastNameLabel.Size = new System.Drawing.Size(123, 15);
            this.firstLastNameLabel.TabIndex = 1;
            this.firstLastNameLabel.Text = "First Name Last Name";
            // 
            // consultantPicture
            // 
            this.consultantPicture.Image = global::ConsultantSystem.Properties.Resources.consultant_icon1;
            this.consultantPicture.Location = new System.Drawing.Point(1323, 28);
            this.consultantPicture.Name = "consultantPicture";
            this.consultantPicture.Size = new System.Drawing.Size(67, 70);
            this.consultantPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.consultantPicture.TabIndex = 2;
            this.consultantPicture.TabStop = false;
            // 
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Location = new System.Drawing.Point(1194, 83);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(56, 15);
            this.isAdminLabel.TabIndex = 3;
            this.isAdminLabel.Text = "isAdmin?";
            // 
            // newTicketsLabel
            // 
            this.newTicketsLabel.AutoSize = true;
            this.newTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newTicketsLabel.Location = new System.Drawing.Point(264, 63);
            this.newTicketsLabel.Name = "newTicketsLabel";
            this.newTicketsLabel.Size = new System.Drawing.Size(180, 40);
            this.newTicketsLabel.TabIndex = 5;
            this.newTicketsLabel.Text = "New Tickets";
            // 
            // myTicketsLabel
            // 
            this.myTicketsLabel.AutoSize = true;
            this.myTicketsLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.myTicketsLabel.Location = new System.Drawing.Point(974, 58);
            this.myTicketsLabel.Name = "myTicketsLabel";
            this.myTicketsLabel.Size = new System.Drawing.Size(160, 40);
            this.myTicketsLabel.TabIndex = 6;
            this.myTicketsLabel.Text = "My Tickets";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(660, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(95, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Load Tickets";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // newTicketsPanel
            // 
            this.newTicketsPanel.AutoScroll = true;
            this.newTicketsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.newTicketsPanel.Location = new System.Drawing.Point(12, 122);
            this.newTicketsPanel.Name = "newTicketsPanel";
            this.newTicketsPanel.Size = new System.Drawing.Size(678, 472);
            this.newTicketsPanel.TabIndex = 9;
            // 
            // myTicketsPanel
            // 
            this.myTicketsPanel.AutoScroll = true;
            this.myTicketsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.myTicketsPanel.Location = new System.Drawing.Point(713, 122);
            this.myTicketsPanel.Name = "myTicketsPanel";
            this.myTicketsPanel.Size = new System.Drawing.Size(678, 472);
            this.myTicketsPanel.TabIndex = 10;
            // 
            // ConsultantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 672);
            this.Controls.Add(this.myTicketsPanel);
            this.Controls.Add(this.newTicketsPanel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.myTicketsLabel);
            this.Controls.Add(this.newTicketsLabel);
            this.Controls.Add(this.isAdminLabel);
            this.Controls.Add(this.consultantPicture);
            this.Controls.Add(this.firstLastNameLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "ConsultantForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultantForm_FormClosed);
            this.Load += new System.EventHandler(this.ConsultantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultantPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLabel;
        private Label firstLastNameLabel;
        private PictureBox consultantPicture;
        private Label isAdminLabel;
        private Label newTicketsLabel;
        private Label myTicketsLabel;
        private Button updateButton;
        public FlowLayoutPanel newTicketsPanel;
        public FlowLayoutPanel myTicketsPanel;
    }
}