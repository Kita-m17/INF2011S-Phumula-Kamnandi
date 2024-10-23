namespace Phumla_Kamnandi_project.Presentation
{
    partial class ManageBookings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listLabel = new System.Windows.Forms.Label();
            this.bookingListView = new System.Windows.Forms.ListView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.signOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.signInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adultsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.childrenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.roomsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adultslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adultsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listLabel);
            this.groupBox1.Controls.Add(this.bookingListView);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.hotelComboBox);
            this.groupBox1.Controls.Add(this.signOutDateTimePicker);
            this.groupBox1.Controls.Add(this.signInDateTimePicker);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.adultsNumericUpDown);
            this.groupBox1.Controls.Add(this.childrenNumericUpDown);
            this.groupBox1.Controls.Add(this.roomsNumericUpDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adultslabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 507);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(299, 19);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(167, 17);
            this.listLabel.TabIndex = 32;
            this.listLabel.Text = "Listing of all bookings";
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(20, 39);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(695, 217);
            this.bookingListView.TabIndex = 31;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.bookingListView_SelectedIndexChanged_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(367, 466);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(703, 466);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 34);
            this.submitButton.TabIndex = 29;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(40, 466);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 34);
            this.backButton.TabIndex = 27;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Items.AddRange(new object[] {
            "Richmond",
            "Merlin"});
            this.hotelComboBox.Location = new System.Drawing.Point(107, 278);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(236, 26);
            this.hotelComboBox.TabIndex = 26;
            // 
            // signOutDateTimePicker
            // 
            this.signOutDateTimePicker.Location = new System.Drawing.Point(106, 347);
            this.signOutDateTimePicker.Name = "signOutDateTimePicker";
            this.signOutDateTimePicker.Size = new System.Drawing.Size(236, 24);
            this.signOutDateTimePicker.TabIndex = 25;
            // 
            // signInDateTimePicker
            // 
            this.signInDateTimePicker.Location = new System.Drawing.Point(107, 315);
            this.signInDateTimePicker.Name = "signInDateTimePicker";
            this.signInDateTimePicker.Size = new System.Drawing.Size(236, 24);
            this.signInDateTimePicker.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(430, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Children";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Number of rooms";
            // 
            // adultsNumericUpDown
            // 
            this.adultsNumericUpDown.Location = new System.Drawing.Point(562, 279);
            this.adultsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.adultsNumericUpDown.Name = "adultsNumericUpDown";
            this.adultsNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.adultsNumericUpDown.TabIndex = 21;
            this.adultsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // childrenNumericUpDown
            // 
            this.childrenNumericUpDown.Location = new System.Drawing.Point(562, 314);
            this.childrenNumericUpDown.Name = "childrenNumericUpDown";
            this.childrenNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.childrenNumericUpDown.TabIndex = 20;
            // 
            // roomsNumericUpDown
            // 
            this.roomsNumericUpDown.Location = new System.Drawing.Point(562, 350);
            this.roomsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsNumericUpDown.Name = "roomsNumericUpDown";
            this.roomsNumericUpDown.Size = new System.Drawing.Size(120, 24);
            this.roomsNumericUpDown.TabIndex = 19;
            this.roomsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sign-in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sign-out";
            // 
            // adultslabel
            // 
            this.adultslabel.AutoSize = true;
            this.adultslabel.Location = new System.Drawing.Point(430, 285);
            this.adultslabel.Name = "adultslabel";
            this.adultslabel.Size = new System.Drawing.Size(48, 18);
            this.adultslabel.TabIndex = 8;
            this.adultslabel.Text = "Adults";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hotel";
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.garbage_17608000;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Location = new System.Drawing.Point(545, 395);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 50);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.edit_8023699;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.Location = new System.Drawing.Point(433, 395);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 50);
            this.editButton.TabIndex = 3;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ManageBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Phumla_Kamnandi_project.Properties.Resources.Screenshot_2024_09_22_140548;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 583);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "ManageBookings";
            this.Text = "Manage Bookings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adultsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.DateTimePicker signOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker signInDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown adultsNumericUpDown;
        private System.Windows.Forms.NumericUpDown childrenNumericUpDown;
        private System.Windows.Forms.NumericUpDown roomsNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label adultslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.Label listLabel;
    }
}