namespace Phumla_Kamnandi_project
{
    partial class Make_enquiry
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.signOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.signInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HotelsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.makeBookingButton = new System.Windows.Forms.Button();
            this.facilitiesCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.availRoomsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Location = new System.Drawing.Point(52, 119);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.backButton);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.checkButton);
            this.splitContainer1.Panel1.Controls.Add(this.signOutDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.signInDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.HotelsComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.makeBookingButton);
            this.splitContainer1.Panel2.Controls.Add(this.facilitiesCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.rateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.availRoomsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(721, 366);
            this.splitContainer1.SplitterDistance = 434;
            this.splitContainer1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(43, 316);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(163, 34);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Enquiry Details";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(256, 316);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(163, 34);
            this.checkButton.TabIndex = 15;
            this.checkButton.Text = "Check Availability";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // signOutDateTimePicker
            // 
            this.signOutDateTimePicker.Location = new System.Drawing.Point(125, 180);
            this.signOutDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signOutDateTimePicker.MinDate = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            this.signOutDateTimePicker.Name = "signOutDateTimePicker";
            this.signOutDateTimePicker.Size = new System.Drawing.Size(293, 28);
            this.signOutDateTimePicker.TabIndex = 14;
            this.signOutDateTimePicker.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // signInDateTimePicker
            // 
            this.signInDateTimePicker.Location = new System.Drawing.Point(125, 130);
            this.signInDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signInDateTimePicker.MinDate = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            this.signInDateTimePicker.Name = "signInDateTimePicker";
            this.signInDateTimePicker.Size = new System.Drawing.Size(293, 28);
            this.signInDateTimePicker.TabIndex = 13;
            this.signInDateTimePicker.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sign-out date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sign-in date";
            // 
            // HotelsComboBox
            // 
            this.HotelsComboBox.FormattingEnabled = true;
            this.HotelsComboBox.Location = new System.Drawing.Point(125, 82);
            this.HotelsComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HotelsComboBox.Name = "HotelsComboBox";
            this.HotelsComboBox.Size = new System.Drawing.Size(293, 30);
            this.HotelsComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hotel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(23, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "(per room)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Estimated amount :";
            // 
            // makeBookingButton
            // 
            this.makeBookingButton.Location = new System.Drawing.Point(44, 316);
            this.makeBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makeBookingButton.Name = "makeBookingButton";
            this.makeBookingButton.Size = new System.Drawing.Size(163, 34);
            this.makeBookingButton.TabIndex = 19;
            this.makeBookingButton.Text = "Make Booking";
            this.makeBookingButton.UseVisualStyleBackColor = true;
            this.makeBookingButton.Click += new System.EventHandler(this.makeBookingButton_Click);
            // 
            // facilitiesCheckBox
            // 
            this.facilitiesCheckBox.FormattingEnabled = true;
            this.facilitiesCheckBox.Items.AddRange(new object[] {
            "Pool",
            "Game Room"});
            this.facilitiesCheckBox.Location = new System.Drawing.Point(27, 202);
            this.facilitiesCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facilitiesCheckBox.Name = "facilitiesCheckBox";
            this.facilitiesCheckBox.Size = new System.Drawing.Size(209, 27);
            this.facilitiesCheckBox.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Facilities:";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(204, 110);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(0, 22);
            this.rateLabel.TabIndex = 22;
            // 
            // availRoomsLabel
            // 
            this.availRoomsLabel.AutoSize = true;
            this.availRoomsLabel.Location = new System.Drawing.Point(204, 66);
            this.availRoomsLabel.Name = "availRoomsLabel";
            this.availRoomsLabel.Size = new System.Drawing.Size(0, 22);
            this.availRoomsLabel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Available rooms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Details";
            // 
            // Make_enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.Screenshot_2024_09_22_140548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 505);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Make_enquiry";
            this.Text = "Make_enquiry";
            this.Load += new System.EventHandler(this.Make_enquiry_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.DateTimePicker signOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker signInDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox HotelsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label availRoomsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox facilitiesCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button makeBookingButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}