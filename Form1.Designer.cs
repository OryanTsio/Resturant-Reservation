namespace LinuxOs_Project
{
    partial class ResForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.HrCombo = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblNumOfPeople = new System.Windows.Forms.Label();
            this.DateCal = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.rdOutside = new System.Windows.Forms.RadioButton();
            this.rdOnTheBar = new System.Windows.Forms.RadioButton();
            this.rdInside = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnTable = new System.Windows.Forms.Button();
            this.lblTableNum = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.grpTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(487, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservation";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // HrCombo
            // 
            this.HrCombo.FormattingEnabled = true;
            this.HrCombo.Items.AddRange(new object[] {
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00"});
            this.HrCombo.Location = new System.Drawing.Point(84, 153);
            this.HrCombo.Name = "HrCombo";
            this.HrCombo.Size = new System.Drawing.Size(164, 24);
            this.HrCombo.TabIndex = 1;
            this.HrCombo.SelectedIndexChanged += new System.EventHandler(this.HrCombo_SelectedIndexChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHour.Location = new System.Drawing.Point(78, 99);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(225, 40);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Choose an hour :";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(1041, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(852, 540);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(143, 65);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumOfPeople
            // 
            this.lblNumOfPeople.AutoSize = true;
            this.lblNumOfPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfPeople.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPeople.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumOfPeople.Location = new System.Drawing.Point(78, 207);
            this.lblNumOfPeople.Name = "lblNumOfPeople";
            this.lblNumOfPeople.Size = new System.Drawing.Size(165, 40);
            this.lblNumOfPeople.TabIndex = 6;
            this.lblNumOfPeople.Text = "How many?";
            this.lblNumOfPeople.Click += new System.EventHandler(this.lblNumOfPeople_Click);
            // 
            // DateCal
            // 
            this.DateCal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.DateCal.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCal.Location = new System.Drawing.Point(852, 139);
            this.DateCal.Name = "DateCal";
            this.DateCal.TabIndex = 7;
            this.DateCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateCal_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(845, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Date :";
            // 
            // grpTable
            // 
            this.grpTable.BackColor = System.Drawing.Color.Transparent;
            this.grpTable.Controls.Add(this.rdOutside);
            this.grpTable.Controls.Add(this.rdOnTheBar);
            this.grpTable.Controls.Add(this.rdInside);
            this.grpTable.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpTable.Location = new System.Drawing.Point(119, 419);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(441, 186);
            this.grpTable.TabIndex = 9;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "where?";
            this.grpTable.Enter += new System.EventHandler(this.grpTable_Enter);
            // 
            // rdOutside
            // 
            this.rdOutside.AutoSize = true;
            this.rdOutside.Location = new System.Drawing.Point(59, 131);
            this.rdOutside.Name = "rdOutside";
            this.rdOutside.Size = new System.Drawing.Size(136, 44);
            this.rdOutside.TabIndex = 2;
            this.rdOutside.TabStop = true;
            this.rdOutside.Text = "Outside";
            this.rdOutside.UseVisualStyleBackColor = true;
            // 
            // rdOnTheBar
            // 
            this.rdOnTheBar.AutoSize = true;
            this.rdOnTheBar.Location = new System.Drawing.Point(59, 38);
            this.rdOnTheBar.Name = "rdOnTheBar";
            this.rdOnTheBar.Size = new System.Drawing.Size(172, 44);
            this.rdOnTheBar.TabIndex = 1;
            this.rdOnTheBar.TabStop = true;
            this.rdOnTheBar.Text = "On the bar";
            this.rdOnTheBar.UseVisualStyleBackColor = true;
            // 
            // rdInside
            // 
            this.rdInside.AutoSize = true;
            this.rdInside.Location = new System.Drawing.Point(59, 81);
            this.rdInside.Name = "rdInside";
            this.rdInside.Size = new System.Drawing.Size(117, 44);
            this.rdInside.TabIndex = 0;
            this.rdInside.TabStop = true;
            this.rdInside.Text = "Inside";
            this.rdInside.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(852, 479);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhone.Location = new System.Drawing.Point(845, 430);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(204, 37);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone Number :";
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(639, 540);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(148, 65);
            this.btnTable.TabIndex = 12;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTableNum.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNum.Location = new System.Drawing.Point(662, 484);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(0, 24);
            this.lblTableNum.TabIndex = 13;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCustomer.Location = new System.Drawing.Point(85, 250);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(159, 41);
            this.txtCustomer.TabIndex = 14;
            // 
            // ResForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1270, 661);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblTableNum);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.grpTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateCal);
            this.Controls.Add(this.lblNumOfPeople);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.HrCombo);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ResForm";
            this.Text = "O&S Resturant Reservation";
            this.Load += new System.EventHandler(this.ResForm_Load);
            this.grpTable.ResumeLayout(false);
            this.grpTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox HrCombo;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblNumOfPeople;
        private System.Windows.Forms.MonthCalendar DateCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.RadioButton rdOutside;
        private System.Windows.Forms.RadioButton rdOnTheBar;
        private System.Windows.Forms.RadioButton rdInside;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}

