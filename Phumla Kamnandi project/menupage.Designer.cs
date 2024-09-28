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
            this.label2 = new System.Windows.Forms.Label();
            this.generateReportsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeEnquiryButton
            // 
            this.makeEnquiryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeEnquiryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.makeEnquiryButton.Location = new System.Drawing.Point(423, 66);
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
            this.makeBookingButton.Location = new System.Drawing.Point(423, 140);
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
            this.manageBookingbutton.Location = new System.Drawing.Point(423, 214);
            this.manageBookingbutton.Name = "manageBookingbutton";
            this.manageBookingbutton.Size = new System.Drawing.Size(277, 68);
            this.manageBookingbutton.TabIndex = 3;
            this.manageBookingbutton.Text = "Manage Bookings";
            this.manageBookingbutton.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(195, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME ";
            // 
            // generateReportsButton
            // 
            this.generateReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportsButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.generateReportsButton.Location = new System.Drawing.Point(423, 288);
            this.generateReportsButton.Name = "generateReportsButton";
            this.generateReportsButton.Size = new System.Drawing.Size(277, 68);
            this.generateReportsButton.TabIndex = 8;
            this.generateReportsButton.Text = "Generate Reports";
            this.generateReportsButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.logoutButton.Location = new System.Drawing.Point(423, 362);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(277, 68);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // menupage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.Screenshot_2024_09_22_140548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.generateReportsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manageBookingbutton);
            this.Controls.Add(this.makeBookingButton);
            this.Controls.Add(this.makeEnquiryButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "menupage";
            this.Text = "menupage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeEnquiryButton;
        private System.Windows.Forms.Button makeBookingButton;
        private System.Windows.Forms.Button manageBookingbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateReportsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}