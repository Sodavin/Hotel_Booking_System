namespace Hotel_Booking_System
{
    partial class ContactForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            pnlContactInfo = new Panel();
            lblHoursDetail = new Label();
            lblHoursTitle = new Label();
            lblAddressDetail = new Label();
            lblAddressTitle = new Label();
            lblEmailDetail = new Label();
            lblEmailTitle = new Label();
            lblPhoneDetail = new Label();
            lblPhoneTitle = new Label();
            lblContactHeader = new Label();
            pnlForm = new Panel();
            btnSendMessage = new Button();
            txtMessage = new TextBox();
            lblMessage = new Label();
            cmbSubject = new ComboBox();
            lblSubject = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            lblFormHeader = new Label();
            pnlHeader.SuspendLayout();
            pnlContactInfo.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 45, 80);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(880, 55);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(360, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📞 GrandStay Concierge & 24/7 Support";
            lblTitle.MouseDown += pnlHeader_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(835, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlContactInfo
            // 
            pnlContactInfo.BackColor = Color.FromArgb(23, 45, 80);
            pnlContactInfo.Controls.Add(lblHoursDetail);
            pnlContactInfo.Controls.Add(lblHoursTitle);
            pnlContactInfo.Controls.Add(lblAddressDetail);
            pnlContactInfo.Controls.Add(lblAddressTitle);
            pnlContactInfo.Controls.Add(lblEmailDetail);
            pnlContactInfo.Controls.Add(lblEmailTitle);
            pnlContactInfo.Controls.Add(lblPhoneDetail);
            pnlContactInfo.Controls.Add(lblPhoneTitle);
            pnlContactInfo.Controls.Add(lblContactHeader);
            pnlContactInfo.Location = new Point(25, 75);
            pnlContactInfo.Name = "pnlContactInfo";
            pnlContactInfo.Size = new Size(340, 485);
            pnlContactInfo.TabIndex = 1;
            // 
            // lblHoursDetail
            // 
            lblHoursDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoursDetail.ForeColor = Color.Gainsboro;
            lblHoursDetail.Location = new Point(20, 395);
            lblHoursDetail.Name = "lblHoursDetail";
            lblHoursDetail.Size = new Size(295, 45);
            lblHoursDetail.TabIndex = 8;
            lblHoursDetail.Text = "Front Desk & Concierge: 24/7\nReservations: 7:00 AM – 10:00 PM";
            // 
            // lblHoursTitle
            // 
            lblHoursTitle.AutoSize = true;
            lblHoursTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoursTitle.ForeColor = Color.White;
            lblHoursTitle.Location = new Point(20, 370);
            lblHoursTitle.Name = "lblHoursTitle";
            lblHoursTitle.Size = new Size(160, 23);
            lblHoursTitle.TabIndex = 7;
            lblHoursTitle.Text = "⏰ Operating Hours";
            // 
            // lblAddressDetail
            // 
            lblAddressDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressDetail.ForeColor = Color.Gainsboro;
            lblAddressDetail.Location = new Point(20, 290);
            lblAddressDetail.Name = "lblAddressDetail";
            lblAddressDetail.Size = new Size(295, 65);
            lblAddressDetail.TabIndex = 6;
            lblAddressDetail.Text = "GrandStay Tower, No. 128 Norodom Blvd, Sangkat Boeung Keng Kang I, Phnom Penh, Cambodia";
            // 
            // lblAddressTitle
            // 
            lblAddressTitle.AutoSize = true;
            lblAddressTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddressTitle.ForeColor = Color.White;
            lblAddressTitle.Location = new Point(20, 265);
            lblAddressTitle.Name = "lblAddressTitle";
            lblAddressTitle.Size = new Size(150, 23);
            lblAddressTitle.TabIndex = 5;
            lblAddressTitle.Text = "📍 Head Concierge";
            // 
            // lblEmailDetail
            // 
            lblEmailDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailDetail.ForeColor = Color.Gainsboro;
            lblEmailDetail.Location = new Point(20, 195);
            lblEmailDetail.Name = "lblEmailDetail";
            lblEmailDetail.Size = new Size(295, 55);
            lblEmailDetail.TabIndex = 4;
            lblEmailDetail.Text = "concierge@grandstay.com.kh\nreservations@grandstay.com.kh";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailTitle.ForeColor = Color.White;
            lblEmailTitle.Location = new Point(20, 170);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(140, 23);
            lblEmailTitle.TabIndex = 3;
            lblEmailTitle.Text = "📧 Email Support";
            // 
            // lblPhoneDetail
            // 
            lblPhoneDetail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneDetail.ForeColor = Color.Gainsboro;
            lblPhoneDetail.Location = new Point(20, 105);
            lblPhoneDetail.Name = "lblPhoneDetail";
            lblPhoneDetail.Size = new Size(295, 50);
            lblPhoneDetail.TabIndex = 2;
            lblPhoneDetail.Text = "+855 (0) 23 999 888 (Toll-Free)\n+855 (0) 12 345 678 (WhatsApp/Telegram)";
            // 
            // lblPhoneTitle
            // 
            lblPhoneTitle.AutoSize = true;
            lblPhoneTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneTitle.ForeColor = Color.White;
            lblPhoneTitle.Location = new Point(20, 80);
            lblPhoneTitle.Name = "lblPhoneTitle";
            lblPhoneTitle.Size = new Size(130, 23);
            lblPhoneTitle.TabIndex = 1;
            lblPhoneTitle.Text = "📞 Direct Lines";
            // 
            // lblContactHeader
            // 
            lblContactHeader.AutoSize = true;
            lblContactHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactHeader.ForeColor = Color.White;
            lblContactHeader.Location = new Point(20, 25);
            lblContactHeader.Name = "lblContactHeader";
            lblContactHeader.Size = new Size(207, 32);
            lblContactHeader.TabIndex = 0;
            lblContactHeader.Text = "Get In Touch With Us";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.Controls.Add(btnSendMessage);
            pnlForm.Controls.Add(txtMessage);
            pnlForm.Controls.Add(lblMessage);
            pnlForm.Controls.Add(cmbSubject);
            pnlForm.Controls.Add(lblSubject);
            pnlForm.Controls.Add(txtPhone);
            pnlForm.Controls.Add(lblPhone);
            pnlForm.Controls.Add(txtEmail);
            pnlForm.Controls.Add(lblEmail);
            pnlForm.Controls.Add(txtFullName);
            pnlForm.Controls.Add(lblFullName);
            pnlForm.Controls.Add(lblFormHeader);
            pnlForm.Location = new Point(385, 75);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(470, 485);
            pnlForm.TabIndex = 2;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.FromArgb(23, 45, 80);
            btnSendMessage.Cursor = Cursors.Hand;
            btnSendMessage.FlatAppearance.BorderSize = 0;
            btnSendMessage.FlatStyle = FlatStyle.Flat;
            btnSendMessage.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendMessage.ForeColor = Color.White;
            btnSendMessage.Location = new Point(25, 420);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(420, 44);
            btnSendMessage.TabIndex = 11;
            btnSendMessage.Text = "Send Message to Concierge";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessage.Location = new Point(25, 305);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(420, 95);
            txtMessage.TabIndex = 10;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(23, 45, 80);
            lblMessage.Location = new Point(25, 280);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(130, 20);
            lblMessage.TabIndex = 9;
            lblMessage.Text = "Your Message *";
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] {
            "Room Booking & Availability",
            "Special Requests / Honeymoon / VIP",
            "Airport Pickup & Transportation",
            "Corporate / Group Booking",
            "Other Inquiry"});
            cmbSubject.Location = new Point(25, 235);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(420, 29);
            cmbSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubject.ForeColor = Color.FromArgb(23, 45, 80);
            lblSubject.Location = new Point(25, 210);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(69, 20);
            lblSubject.TabIndex = 7;
            lblSubject.Text = "Subject *";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(245, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 29);
            txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(23, 45, 80);
            lblPhone.Location = new Point(245, 135);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(106, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(25, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 29);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(23, 45, 80);
            lblEmail.Location = new Point(25, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(119, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address *";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(25, 90);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(420, 29);
            txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(23, 45, 80);
            lblFullName.Location = new Point(25, 65);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name *";
            // 
            // lblFormHeader
            // 
            lblFormHeader.AutoSize = true;
            lblFormHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormHeader.ForeColor = Color.FromArgb(23, 45, 80);
            lblFormHeader.Location = new Point(25, 20);
            lblFormHeader.Name = "lblFormHeader";
            lblFormHeader.Size = new Size(198, 30);
            lblFormHeader.TabIndex = 0;
            lblFormHeader.Text = "Send Us a Message";
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(880, 580);
            Controls.Add(pnlForm);
            Controls.Add(pnlContactInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ContactForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contact Concierge";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContactInfo.ResumeLayout(false);
            pnlContactInfo.PerformLayout();
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Panel pnlContactInfo;
        private Label lblContactHeader;
        private Label lblPhoneTitle;
        private Label lblPhoneDetail;
        private Label lblEmailTitle;
        private Label lblEmailDetail;
        private Label lblAddressTitle;
        private Label lblAddressDetail;
        private Label lblHoursTitle;
        private Label lblHoursDetail;
        private Panel pnlForm;
        private Label lblFormHeader;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblMessage;
        private TextBox txtMessage;
        private Button btnSendMessage;
    }
}
