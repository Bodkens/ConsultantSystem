namespace ConsultantSystem
{
    partial class TicketView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.assignButton = new System.Windows.Forms.Button();
            this.problemLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignButton
            // 
            this.assignButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignButton.Location = new System.Drawing.Point(301, 112);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(132, 46);
            this.assignButton.TabIndex = 0;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.problemLabel.Location = new System.Drawing.Point(41, 20);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(65, 20);
            this.problemLabel.TabIndex = 1;
            this.problemLabel.Text = "Problem";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactLabel.Location = new System.Drawing.Point(301, 32);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(52, 17);
            this.contactLabel.TabIndex = 2;
            this.contactLabel.Text = "Contact";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(41, 88);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton.Location = new System.Drawing.Point(163, 112);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(132, 46);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(16, 150);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete ticket";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.assignButton);
            this.Name = "TicketView";
            this.Size = new System.Drawing.Size(480, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button assignButton;
        private Label problemLabel;
        private Label contactLabel;
        private Label descriptionLabel;
        private Button returnButton;
        private Button deleteButton;
    }
}
