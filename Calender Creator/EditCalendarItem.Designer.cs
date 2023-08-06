namespace Calender_Creator
{
    partial class EditCalendarItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allDayCheckBox = new System.Windows.Forms.CheckBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.endMBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.endHBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endsTimePanel = new System.Windows.Forms.Panel();
            this.endsAMPMBox = new System.Windows.Forms.ComboBox();
            this.startsTimePanel = new System.Windows.Forms.Panel();
            this.startsAMPMBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.startHBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startMBox = new System.Windows.Forms.TextBox();
            this.travelTimeBox = new System.Windows.Forms.ComboBox();
            this.travelTimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.repeatBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.alertBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.busyFreeBox = new System.Windows.Forms.ComboBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.endsTimePanel.SuspendLayout();
            this.startsTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(113, 31);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(559, 30);
            this.titleBox.TabIndex = 1;
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.Location = new System.Drawing.Point(113, 70);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(559, 30);
            this.locationBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location:";
            // 
            // allDayCheckBox
            // 
            this.allDayCheckBox.AutoSize = true;
            this.allDayCheckBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDayCheckBox.Location = new System.Drawing.Point(14, 131);
            this.allDayCheckBox.Name = "allDayCheckBox";
            this.allDayCheckBox.Size = new System.Drawing.Size(89, 26);
            this.allDayCheckBox.TabIndex = 4;
            this.allDayCheckBox.Text = "All-Day";
            this.allDayCheckBox.UseVisualStyleBackColor = true;
            this.allDayCheckBox.CheckedChanged += new System.EventHandler(this.allDayCheckBox_CheckedChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(111, 131);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(118, 30);
            this.startDatePicker.TabIndex = 5;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // startsLabel
            // 
            this.startsLabel.AutoSize = true;
            this.startsLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsLabel.Location = new System.Drawing.Point(137, 106);
            this.startsLabel.Name = "startsLabel";
            this.startsLabel.Size = new System.Drawing.Size(56, 22);
            this.startsLabel.TabIndex = 6;
            this.startsLabel.Text = "Starts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Min";
            // 
            // endMBox
            // 
            this.endMBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endMBox.Location = new System.Drawing.Point(55, 25);
            this.endMBox.MaxLength = 2;
            this.endMBox.Name = "endMBox";
            this.endMBox.Size = new System.Drawing.Size(32, 30);
            this.endMBox.TabIndex = 16;
            this.endMBox.Text = "30";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hour";
            // 
            // endHBox
            // 
            this.endHBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endHBox.Location = new System.Drawing.Point(7, 25);
            this.endHBox.MaxLength = 2;
            this.endHBox.Name = "endHBox";
            this.endHBox.Size = new System.Drawing.Size(32, 30);
            this.endHBox.TabIndex = 14;
            this.endHBox.Text = "12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 22);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ends";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(391, 131);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(118, 30);
            this.endDatePicker.TabIndex = 12;
            // 
            // endsTimePanel
            // 
            this.endsTimePanel.Controls.Add(this.endsAMPMBox);
            this.endsTimePanel.Controls.Add(this.label9);
            this.endsTimePanel.Controls.Add(this.label7);
            this.endsTimePanel.Controls.Add(this.endHBox);
            this.endsTimePanel.Controls.Add(this.label8);
            this.endsTimePanel.Controls.Add(this.endMBox);
            this.endsTimePanel.Location = new System.Drawing.Point(515, 106);
            this.endsTimePanel.Name = "endsTimePanel";
            this.endsTimePanel.Size = new System.Drawing.Size(155, 63);
            this.endsTimePanel.TabIndex = 19;
            // 
            // endsAMPMBox
            // 
            this.endsAMPMBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endsAMPMBox.FormattingEnabled = true;
            this.endsAMPMBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.endsAMPMBox.Location = new System.Drawing.Point(92, 25);
            this.endsAMPMBox.Name = "endsAMPMBox";
            this.endsAMPMBox.Size = new System.Drawing.Size(54, 30);
            this.endsAMPMBox.TabIndex = 22;
            this.endsAMPMBox.Text = "PM";
            // 
            // startsTimePanel
            // 
            this.startsTimePanel.Controls.Add(this.startsAMPMBox);
            this.startsTimePanel.Controls.Add(this.label4);
            this.startsTimePanel.Controls.Add(this.label5);
            this.startsTimePanel.Controls.Add(this.startHBox);
            this.startsTimePanel.Controls.Add(this.label6);
            this.startsTimePanel.Controls.Add(this.startMBox);
            this.startsTimePanel.Location = new System.Drawing.Point(230, 106);
            this.startsTimePanel.Name = "startsTimePanel";
            this.startsTimePanel.Size = new System.Drawing.Size(155, 63);
            this.startsTimePanel.TabIndex = 20;
            // 
            // startsAMPMBox
            // 
            this.startsAMPMBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startsAMPMBox.FormattingEnabled = true;
            this.startsAMPMBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.startsAMPMBox.Location = new System.Drawing.Point(93, 25);
            this.startsAMPMBox.Name = "startsAMPMBox";
            this.startsAMPMBox.Size = new System.Drawing.Size(54, 30);
            this.startsAMPMBox.TabIndex = 21;
            this.startsAMPMBox.Text = "AM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = ":";
            // 
            // startHBox
            // 
            this.startHBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startHBox.Location = new System.Drawing.Point(7, 25);
            this.startHBox.MaxLength = 2;
            this.startHBox.Name = "startHBox";
            this.startHBox.Size = new System.Drawing.Size(32, 30);
            this.startHBox.TabIndex = 14;
            this.startHBox.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Min";
            // 
            // startMBox
            // 
            this.startMBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMBox.Location = new System.Drawing.Point(55, 25);
            this.startMBox.MaxLength = 2;
            this.startMBox.Name = "startMBox";
            this.startMBox.Size = new System.Drawing.Size(32, 30);
            this.startMBox.TabIndex = 16;
            this.startMBox.Text = "30";
            // 
            // travelTimeBox
            // 
            this.travelTimeBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelTimeBox.FormattingEnabled = true;
            this.travelTimeBox.Items.AddRange(new object[] {
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "1 Hour"});
            this.travelTimeBox.Location = new System.Drawing.Point(676, 131);
            this.travelTimeBox.Name = "travelTimeBox";
            this.travelTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.travelTimeBox.Size = new System.Drawing.Size(157, 30);
            this.travelTimeBox.TabIndex = 21;
            this.travelTimeBox.Text = "1 Hour";
            // 
            // travelTimeLabel
            // 
            this.travelTimeLabel.AutoSize = true;
            this.travelTimeLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelTimeLabel.Location = new System.Drawing.Point(705, 106);
            this.travelTimeLabel.Name = "travelTimeLabel";
            this.travelTimeLabel.Size = new System.Drawing.Size(106, 22);
            this.travelTimeLabel.TabIndex = 22;
            this.travelTimeLabel.Text = "Travel Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Repeat";
            // 
            // repeatBox
            // 
            this.repeatBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatBox.FormattingEnabled = true;
            this.repeatBox.Items.AddRange(new object[] {
            "Every Day"});
            this.repeatBox.Location = new System.Drawing.Point(10, 211);
            this.repeatBox.Name = "repeatBox";
            this.repeatBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.repeatBox.Size = new System.Drawing.Size(157, 30);
            this.repeatBox.TabIndex = 23;
            this.repeatBox.Text = "Every Day";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 22);
            this.label11.TabIndex = 26;
            this.label11.Text = "Alert";
            // 
            // alertBox
            // 
            this.alertBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertBox.FormattingEnabled = true;
            this.alertBox.Items.AddRange(new object[] {
            "On The Day of Event",
            "A Day Before"});
            this.alertBox.Location = new System.Drawing.Point(173, 211);
            this.alertBox.Name = "alertBox";
            this.alertBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.alertBox.Size = new System.Drawing.Size(157, 30);
            this.alertBox.TabIndex = 25;
            this.alertBox.Text = "A Day Before";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(376, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 22);
            this.label12.TabIndex = 28;
            this.label12.Text = "Show as";
            // 
            // busyFreeBox
            // 
            this.busyFreeBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busyFreeBox.FormattingEnabled = true;
            this.busyFreeBox.Items.AddRange(new object[] {
            "Busy",
            "Free"});
            this.busyFreeBox.Location = new System.Drawing.Point(341, 211);
            this.busyFreeBox.Name = "busyFreeBox";
            this.busyFreeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.busyFreeBox.Size = new System.Drawing.Size(157, 30);
            this.busyFreeBox.TabIndex = 27;
            this.busyFreeBox.Text = "Busy";
            // 
            // urlBox
            // 
            this.urlBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlBox.Location = new System.Drawing.Point(10, 272);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(559, 30);
            this.urlBox.TabIndex = 30;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(12, 247);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(44, 22);
            this.urlLabel.TabIndex = 31;
            this.urlLabel.Text = "URL";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(13, 304);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(56, 22);
            this.notesLabel.TabIndex = 33;
            this.notesLabel.Text = "Notes";
            // 
            // notesBox
            // 
            this.notesBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(11, 329);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(558, 132);
            this.notesBox.TabIndex = 32;
            // 
            // EditCalendarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 476);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.busyFreeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.alertBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repeatBox);
            this.Controls.Add(this.travelTimeLabel);
            this.Controls.Add(this.travelTimeBox);
            this.Controls.Add(this.startsTimePanel);
            this.Controls.Add(this.endsTimePanel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startsLabel);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.allDayCheckBox);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label1);
            this.Name = "EditCalendarItem";
            this.Text = "Edit Calender Item";
            this.Load += new System.EventHandler(this.EditCalendarItem_Load);
            this.endsTimePanel.ResumeLayout(false);
            this.endsTimePanel.PerformLayout();
            this.startsTimePanel.ResumeLayout(false);
            this.startsTimePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox allDayCheckBox;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox endMBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox endHBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Panel endsTimePanel;
        private System.Windows.Forms.Panel startsTimePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox startHBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox startMBox;
        private System.Windows.Forms.ComboBox startsAMPMBox;
        private System.Windows.Forms.ComboBox endsAMPMBox;
        private System.Windows.Forms.ComboBox travelTimeBox;
        private System.Windows.Forms.Label travelTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox repeatBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox alertBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox busyFreeBox;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.TextBox notesBox;
    }
}