namespace Phumla_Kamnandi_project
{
    partial class menupage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.makeEnquiryButton = new System.Windows.Forms.Button();
            this.makeBookingButton = new System.Windows.Forms.Button();
            this.manageBookingbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generateReportsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryButton = new System.Windows.Forms.Button();
            this.occupancyButton = new System.Windows.Forms.Button();
            this.reportsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeEnquiryButton
            // 
            this.makeEnquiryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeEnquiryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.makeEnquiryButton.Location = new System.Drawing.Point(423, 48);
            this.makeEnquiryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeEnquiryButton.Name = "makeEnquiryButton";
            this.makeEnquiryButton.Size = new System.Drawing.Size(277, 68);
            this.makeEnquiryButton.TabIndex = 0;
            this.makeEnquiryButton.Text = "Make An Equiry";
            this.makeEnquiryButton.UseVisualStyleBackColor = true;
            this.makeEnquiryButton.Click += new System.EventHandler(this.makeEnquiryButton_Click);
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.makeBookingButton.Location = new System.Drawing.Point(423, 123);
            this.makeBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.Size = new System.Drawing.Size(277, 68);
            this.makeBookingButton.TabIndex = 2;
            this.makeBookingButton.Text = "Make a Booking ";
            this.makeBookingButton.UseVisualStyleBackColor = true;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // manageBookingbutton
            // 
            this.manageBookingbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBookingbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.manageBookingbutton.Location = new System.Drawing.Point(423, 204);
            this.manageBookingbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manageBookingbutton.Name = "manageBookingbutton";
            this.manageBookingbutton.Size = new System.Drawing.Size(277, 68);
            this.manageBookingbutton.TabIndex = 3;
            this.manageBookingbutton.Text = "Manage Bookings";
            this.manageBookingbutton.UseVisualStyleBackColor = true;
            this.manageBookingbutton.Click += new System.EventHandler(this.manageBookingbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME ";
            // 
            // generateReportsButton
            // 
            this.generateReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.generateReportsButton.Location = new System.Drawing.Point(423, 286);
            this.generateReportsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateReportsButton.Name = "generateReportsButton";
            this.generateReportsButton.Size = new System.Drawing.Size(277, 68);
            this.generateReportsButton.TabIndex = 8;
            this.generateReportsButton.Text = "Generate Reports";
            this.generateReportsButton.UseVisualStyleBackColor = true;
            this.generateReportsButton.Click += new System.EventHandler(this.generateReportsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.logoutButton.Location = new System.Drawing.Point(423, 368);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(277, 68);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // reportsPanel
            // 
            this.reportsPanel.BackColor = System.Drawing.Color.White;
            this.reportsPanel.Controls.Add(this.label3);
            this.reportsPanel.Controls.Add(this.summaryButton);
            this.reportsPanel.Controls.Add(this.occupancyButton);
            this.reportsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportsPanel.Location = new System.Drawing.Point(92, 221);
            this.reportsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.reportsPanel.Name = "reportsPanel";
            this.reportsPanel.Size = new System.Drawing.Size(299, 123);
            this.reportsPanel.TabIndex = 13;
            this.reportsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select report to generate";
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(163, 54);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(100, 28);
            this.summaryButton.TabIndex = 1;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // occupancyButton
            // 
            this.occupancyButton.Location = new System.Drawing.Point(24, 54);
            this.occupancyButton.Margin = new System.Windows.Forms.Padding(4);
            this.occupancyButton.Name = "occupancyButton";
            this.occupancyButton.Size = new System.Drawing.Size(131, 28);
            this.occupancyButton.TabIndex = 0;
            this.occupancyButton.Text = "Occupancy Report";
            this.occupancyButton.UseVisualStyleBackColor = true;
            this.occupancyButton.Click += new System.EventHandler(this.occupancyButton_Click);
            // 
            // menupage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.Screenshot_2024_09_22_140548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 512);
            this.Controls.Add(this.reportsPanel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.generateReportsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageBookingbutton);
            this.Controls.Add(this.makeBookingButton);
            this.Controls.Add(this.makeEnquiryButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menupage";
            this.Text = "menupage";
            this.reportsPanel.ResumeLayout(false);
            this.reportsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeEnquiryButton;
        private System.Windows.Forms.Button makeBookingButton;
        private System.Windows.Forms.Button manageBookingbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateReportsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel reportsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button occupancyButton;
    }
}