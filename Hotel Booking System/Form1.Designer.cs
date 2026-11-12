using System.Drawing.Drawing2D;
namespace Hotel_Booking_System

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnlDestCard = new Panel();
            lblDestHeader = new Label();
            cmbDestination = new ComboBox();
            pictureBox2 = new PictureBox();
            pnlDivider1 = new Panel();
            pnlDateCard = new Panel();
            pictureBox3 = new PictureBox();
            lblDateHeader = new Label();
            lblDateDisplay = new Label();
            lblStayDuration = new Label();
            pnlDivider2 = new Panel();
            pnlGuestCard = new Panel();
            pictureBox4 = new PictureBox();
            lblGuestHeader = new Label();
            label5 = new Label();
            lblGuestSub = new Label();
            lblArrow = new PictureBox();
            button1 = new Button();
            pnlPopup = new Panel();
            picMinusChild = new PictureBox();
            picMinusAdult = new PictureBox();
            picPlusChild = new PictureBox();
            picPlusAdult = new PictureBox();
            lblChildCount = new Label();
            lblAdultCount = new Label();
            label9 = new Label();
            label8 = new Label();
            lblChildTitle = new Label();
            lblAdultTitle = new Label();
            btnGuestsDone = new Button();
            customCalendar = new CustomCalendarControl();
            panel3 = new Panel();
            pictureBox_max = new PictureBox();
            pictureBox_close = new PictureBox();
            pictureBox_min = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            flpNavLeft = new FlowLayoutPanel();
            btnNavHome = new Button();
            btnNavRooms = new Button();
            btnNavMyBookings = new Button();
            btnNavAbout = new Button();
            btnNavContact = new Button();
            flpNavRight = new FlowLayoutPanel();
            btnAdminPortal = new Button();
            btnSignIn = new Button();
            pnlUserSession = new FlowLayoutPanel();
            lblUserGreeting = new Label();
            btnLogout = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlDestCard.SuspendLayout();
            pnlDateCard.SuspendLayout();
            pnlGuestCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinusChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinusAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlusChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlusAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_min).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flpNavLeft.SuspendLayout();
            flpNavRight.SuspendLayout();
            pnlUserSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 336);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 632);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(pnlDestCard);
            panel2.Controls.Add(pnlDivider1);
            panel2.Controls.Add(pnlDateCard);
            panel2.Controls.Add(pnlDivider2);
            panel2.Controls.Add(pnlGuestCard);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(222, 142);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1475, 146);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pnlDestCard
            // 
            pnlDestCard.BackColor = Color.White;
            pnlDestCard.Controls.Add(pictureBox2);
            pnlDestCard.Controls.Add(lblDestHeader);
            pnlDestCard.Controls.Add(cmbDestination);
            pnlDestCard.Location = new Point(24, 20);
            pnlDestCard.Name = "pnlDestCard";
            pnlDestCard.Size = new Size(380, 106);
            pnlDestCard.TabIndex = 0;
            pnlDestCard.Paint += pnlDestCard_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 33);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // lblDestHeader
            // 
            lblDestHeader.AutoSize = true;
            lblDestHeader.BackColor = Color.Transparent;
            lblDestHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestHeader.ForeColor = Color.FromArgb(23, 45, 80);
            lblDestHeader.Location = new Point(64, 18);
            lblDestHeader.Name = "lblDestHeader";
            lblDestHeader.Size = new Size(128, 25);
            lblDestHeader.TabIndex = 2;
            lblDestHeader.Text = "DESTINATION";
            // 
            // cmbDestination
            // 
            cmbDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDestination.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDestination.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDestination.FormattingEnabled = true;
            cmbDestination.Location = new Point(64, 46);
            cmbDestination.Margin = new Padding(3, 2, 3, 2);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(300, 41);
            cmbDestination.TabIndex = 3;
            cmbDestination.Enter += cmbDestination_Enter;
            cmbDestination.Leave += cmbDestination_Leave;
            // 
            // pnlDivider1
            // 
            pnlDivider1.BackColor = Color.FromArgb(215, 225, 235);
            pnlDivider1.Location = new Point(416, 28);
            pnlDivider1.Name = "pnlDivider1";
            pnlDivider1.Size = new Size(1, 90);
            pnlDivider1.TabIndex = 1;
            // 
            // pnlDateCard
            // 
            pnlDateCard.BackColor = Color.White;
            pnlDateCard.Controls.Add(pictureBox3);
            pnlDateCard.Controls.Add(lblDateHeader);
            pnlDateCard.Controls.Add(lblDateDisplay);
            pnlDateCard.Controls.Add(lblStayDuration);
            pnlDateCard.Cursor = Cursors.Hand;
            pnlDateCard.Location = new Point(428, 20);
            pnlDateCard.Name = "pnlDateCard";
            pnlDateCard.Size = new Size(430, 106);
            pnlDateCard.TabIndex = 2;
            pnlDateCard.Click += pnlDateCard_Click;
            pnlDateCard.Paint += pnlDateCard_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 33);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pnlDateCard_Click;
            // 
            // lblDateHeader
            // 
            lblDateHeader.AutoSize = true;
            lblDateHeader.BackColor = Color.Transparent;
            lblDateHeader.Cursor = Cursors.Hand;
            lblDateHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateHeader.ForeColor = Color.FromArgb(23, 45, 80);
            lblDateHeader.Location = new Point(64, 18);
            lblDateHeader.Name = "lblDateHeader";
            lblDateHeader.Size = new Size(230, 25);
            lblDateHeader.TabIndex = 2;
            lblDateHeader.Text = "CHECK-IN  →  CHECK-OUT";
            lblDateHeader.Click += pnlDateCard_Click;
            // 
            // lblDateDisplay
            // 
            lblDateDisplay.AutoSize = true;
            lblDateDisplay.BackColor = Color.Transparent;
            lblDateDisplay.Cursor = Cursors.Hand;
            lblDateDisplay.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateDisplay.ForeColor = Color.FromArgb(23, 45, 80);
            lblDateDisplay.Location = new Point(64, 44);
            lblDateDisplay.Name = "lblDateDisplay";
            lblDateDisplay.Size = new Size(330, 35);
            lblDateDisplay.TabIndex = 3;
            lblDateDisplay.Text = "Thu, Nov 12 → Fri, Nov 13";
            lblDateDisplay.Click += pnlDateCard_Click;
            // 
            // lblStayDuration
            // 
            lblStayDuration.AutoSize = true;
            lblStayDuration.BackColor = Color.Transparent;
            lblStayDuration.Cursor = Cursors.Hand;
            lblStayDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStayDuration.ForeColor = Color.FromArgb(43, 108, 176);
            lblStayDuration.Location = new Point(64, 76);
            lblStayDuration.Name = "lblStayDuration";
            lblStayDuration.Size = new Size(205, 25);
            lblStayDuration.TabIndex = 4;
            lblStayDuration.Text = "🌙 1 night stay (2 days)";
            lblStayDuration.Click += pnlDateCard_Click;
            // 
            // pnlDivider2
            // 
            pnlDivider2.BackColor = Color.FromArgb(215, 225, 235);
            pnlDivider2.Location = new Point(870, 28);
            pnlDivider2.Name = "pnlDivider2";
            pnlDivider2.Size = new Size(1, 90);
            pnlDivider2.TabIndex = 3;
            // 
            // pnlGuestCard
            // 
            pnlGuestCard.BackColor = Color.White;
            pnlGuestCard.Controls.Add(pictureBox4);
            pnlGuestCard.Controls.Add(lblGuestHeader);
            pnlGuestCard.Controls.Add(label5);
            pnlGuestCard.Controls.Add(lblGuestSub);
            pnlGuestCard.Controls.Add(lblArrow);
            pnlGuestCard.Cursor = Cursors.Hand;
            pnlGuestCard.Location = new Point(882, 20);
            pnlGuestCard.Name = "pnlGuestCard";
            pnlGuestCard.Size = new Size(320, 106);
            pnlGuestCard.TabIndex = 4;
            pnlGuestCard.Click += pnlGuestCard_Click;
            pnlGuestCard.Paint += pnlGuestCard_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 33);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pnlGuestCard_Click;
            // 
            // lblGuestHeader
            // 
            lblGuestHeader.AutoSize = true;
            lblGuestHeader.BackColor = Color.Transparent;
            lblGuestHeader.Cursor = Cursors.Hand;
            lblGuestHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestHeader.ForeColor = Color.FromArgb(23, 45, 80);
            lblGuestHeader.Location = new Point(64, 18);
            lblGuestHeader.Name = "lblGuestHeader";
            lblGuestHeader.Size = new Size(81, 25);
            lblGuestHeader.TabIndex = 2;
            lblGuestHeader.Text = "GUESTS";
            lblGuestHeader.Click += pnlGuestCard_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 45, 80);
            label5.Location = new Point(64, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 35);
            label5.TabIndex = 3;
            label5.Text = "1 Adult";
            label5.Click += pnlGuestCard_Click;
            // 
            // lblGuestSub
            // 
            lblGuestSub.AutoSize = true;
            lblGuestSub.BackColor = Color.Transparent;
            lblGuestSub.Cursor = Cursors.Hand;
            lblGuestSub.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGuestSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblGuestSub.Location = new Point(64, 76);
            lblGuestSub.Name = "lblGuestSub";
            lblGuestSub.Size = new Size(160, 23);
            lblGuestSub.TabIndex = 4;
            lblGuestSub.Text = "All ages (18+ / 0-17)";
            lblGuestSub.Click += pnlGuestCard_Click;
            // 
            // lblArrow
            // 
            lblArrow.BackColor = Color.Transparent;
            lblArrow.Cursor = Cursors.Hand;
            lblArrow.Image = (Image)resources.GetObject("lblArrow.Image");
            lblArrow.Location = new Point(276, 40);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(26, 26);
            lblArrow.SizeMode = PictureBoxSizeMode.Zoom;
            lblArrow.TabIndex = 5;
            lblArrow.TabStop = false;
            lblArrow.Click += pnlGuestCard_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 45, 80);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1216, 32);
            button1.Name = "button1";
            button1.Size = new Size(235, 82);
            button1.TabIndex = 5;
            button1.Text = "🔍 SEARCH ROOMS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlPopup
            // 
            pnlPopup.BackColor = Color.White;
            pnlPopup.Controls.Add(lblAdultTitle);
            pnlPopup.Controls.Add(label8);
            pnlPopup.Controls.Add(picMinusAdult);
            pnlPopup.Controls.Add(lblAdultCount);
            pnlPopup.Controls.Add(picPlusAdult);
            pnlPopup.Controls.Add(lblChildTitle);
            pnlPopup.Controls.Add(label9);
            pnlPopup.Controls.Add(picMinusChild);
            pnlPopup.Controls.Add(lblChildCount);
            pnlPopup.Controls.Add(picPlusChild);
            pnlPopup.Controls.Add(btnGuestsDone);
            pnlPopup.Location = new Point(1100, 290);
            pnlPopup.Name = "pnlPopup";
            pnlPopup.Size = new Size(320, 185);
            pnlPopup.TabIndex = 11;
            pnlPopup.Visible = false;
            pnlPopup.Paint += panel4_Paint_1;
            // 
            // lblAdultTitle
            // 
            lblAdultTitle.AutoSize = true;
            lblAdultTitle.BackColor = Color.Transparent;
            lblAdultTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdultTitle.ForeColor = Color.Black;
            lblAdultTitle.Location = new Point(18, 16);
            lblAdultTitle.Name = "lblAdultTitle";
            lblAdultTitle.Size = new Size(79, 30);
            lblAdultTitle.TabIndex = 0;
            lblAdultTitle.Text = "Adults";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(19, 44);
            label8.Name = "label8";
            label8.Size = new Size(137, 23);
            label8.TabIndex = 1;
            label8.Text = "Ages 18 or above";
            // 
            // picMinusAdult
            // 
            picMinusAdult.Cursor = Cursors.Hand;
            picMinusAdult.Image = (Image)resources.GetObject("picMinusAdult.Image");
            picMinusAdult.Location = new Point(176, 22);
            picMinusAdult.Name = "picMinusAdult";
            picMinusAdult.Size = new Size(34, 34);
            picMinusAdult.SizeMode = PictureBoxSizeMode.Zoom;
            picMinusAdult.TabIndex = 2;
            picMinusAdult.TabStop = false;
            picMinusAdult.Click += picMinusAdult_Click;
            // 
            // lblAdultCount
            // 
            lblAdultCount.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdultCount.ForeColor = Color.Black;
            lblAdultCount.Location = new Point(213, 22);
            lblAdultCount.Name = "lblAdultCount";
            lblAdultCount.Size = new Size(32, 34);
            lblAdultCount.TabIndex = 3;
            lblAdultCount.Text = "1";
            lblAdultCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picPlusAdult
            // 
            picPlusAdult.Cursor = Cursors.Hand;
            picPlusAdult.Image = (Image)resources.GetObject("picPlusAdult.Image");
            picPlusAdult.Location = new Point(252, 22);
            picPlusAdult.Name = "picPlusAdult";
            picPlusAdult.Size = new Size(34, 34);
            picPlusAdult.SizeMode = PictureBoxSizeMode.Zoom;
            picPlusAdult.TabIndex = 4;
            picPlusAdult.TabStop = false;
            picPlusAdult.Click += picPlusAdult_Click;
            // 
            // lblChildTitle
            // 
            lblChildTitle.AutoSize = true;
            lblChildTitle.BackColor = Color.Transparent;
            lblChildTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildTitle.ForeColor = Color.Black;
            lblChildTitle.Location = new Point(18, 76);
            lblChildTitle.Name = "lblChildTitle";
            lblChildTitle.Size = new Size(101, 30);
            lblChildTitle.TabIndex = 5;
            lblChildTitle.Text = "Children";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(19, 104);
            label9.Name = "label9";
            label9.Size = new Size(93, 23);
            label9.TabIndex = 6;
            label9.Text = "Ages 0 - 17";
            // 
            // picMinusChild
            // 
            picMinusChild.Cursor = Cursors.Hand;
            picMinusChild.Image = (Image)resources.GetObject("picMinusChild.Image");
            picMinusChild.Location = new Point(176, 82);
            picMinusChild.Name = "picMinusChild";
            picMinusChild.Size = new Size(34, 34);
            picMinusChild.SizeMode = PictureBoxSizeMode.Zoom;
            picMinusChild.TabIndex = 7;
            picMinusChild.TabStop = false;
            picMinusChild.Click += picMinusChild_Click;
            // 
            // lblChildCount
            // 
            lblChildCount.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildCount.ForeColor = Color.Black;
            lblChildCount.Location = new Point(213, 82);
            lblChildCount.Name = "lblChildCount";
            lblChildCount.Size = new Size(32, 34);
            lblChildCount.TabIndex = 8;
            lblChildCount.Text = "0";
            lblChildCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picPlusChild
            // 
            picPlusChild.Cursor = Cursors.Hand;
            picPlusChild.Image = (Image)resources.GetObject("picPlusChild.Image");
            picPlusChild.Location = new Point(252, 82);
            picPlusChild.Name = "picPlusChild";
            picPlusChild.Size = new Size(34, 34);
            picPlusChild.SizeMode = PictureBoxSizeMode.Zoom;
            picPlusChild.TabIndex = 9;
            picPlusChild.TabStop = false;
            picPlusChild.Click += picPlusChild_Click;
            // 
            // btnGuestsDone
            // 
            btnGuestsDone.BackColor = Color.FromArgb(23, 45, 80);
            btnGuestsDone.Cursor = Cursors.Hand;
            btnGuestsDone.FlatAppearance.BorderSize = 0;
            btnGuestsDone.FlatStyle = FlatStyle.Flat;
            btnGuestsDone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestsDone.ForeColor = Color.White;
            btnGuestsDone.Location = new Point(20, 136);
            btnGuestsDone.Name = "btnGuestsDone";
            btnGuestsDone.Size = new Size(276, 36);
            btnGuestsDone.TabIndex = 10;
            btnGuestsDone.Text = "Done";
            btnGuestsDone.UseVisualStyleBackColor = false;
            btnGuestsDone.Click += btnGuestsDone_Click;
            // 
            // customCalendar
            // 
            customCalendar.Location = new Point(650, 290);
            customCalendar.Name = "customCalendar";
            customCalendar.Size = new Size(500, 510);
            customCalendar.TabIndex = 12;
            customCalendar.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Location = new Point(835, 336);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 632);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox_max
            // 
            pictureBox_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_max.Cursor = Cursors.Hand;
            pictureBox_max.Image = (Image)resources.GetObject("pictureBox_max.Image");
            pictureBox_max.Location = new Point(1841, 4);
            pictureBox_max.Margin = new Padding(3, 2, 3, 2);
            pictureBox_max.Name = "pictureBox_max";
            pictureBox_max.Padding = new Padding(5);
            pictureBox_max.Size = new Size(36, 36);
            pictureBox_max.TabIndex = 2;
            pictureBox_max.TabStop = false;
            pictureBox_max.Click += pictureBox_max_Click;
            pictureBox_max.MouseEnter += pictureBox_min_MouseEnter;
            pictureBox_max.MouseLeave += pictureBox_min_MouseLeave;
            // 
            // pictureBox_close
            // 
            pictureBox_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_close.Cursor = Cursors.Hand;
            pictureBox_close.Image = (Image)resources.GetObject("pictureBox_close.Image");
            pictureBox_close.Location = new Point(1881, 4);
            pictureBox_close.Margin = new Padding(3, 2, 3, 2);
            pictureBox_close.Name = "pictureBox_close";
            pictureBox_close.Padding = new Padding(5);
            pictureBox_close.Size = new Size(36, 36);
            pictureBox_close.TabIndex = 1;
            pictureBox_close.TabStop = false;
            pictureBox_close.Click += pictureBox_close_Click;
            pictureBox_close.MouseEnter += pictureBox_min_MouseEnter;
            pictureBox_close.MouseLeave += pictureBox_min_MouseLeave;
            // 
            // pictureBox_min
            // 
            pictureBox_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox_min.Cursor = Cursors.Hand;
            pictureBox_min.Image = (Image)resources.GetObject("pictureBox_min.Image");
            pictureBox_min.Location = new Point(1801, 4);
            pictureBox_min.Margin = new Padding(3, 2, 3, 2);
            pictureBox_min.Name = "pictureBox_min";
            pictureBox_min.Padding = new Padding(5);
            pictureBox_min.Size = new Size(36, 36);
            pictureBox_min.TabIndex = 3;
            pictureBox_min.TabStop = false;
            pictureBox_min.Click += pictureBox_min_Click;
            pictureBox_min.MouseEnter += pictureBox_min_MouseEnter;
            pictureBox_min.MouseLeave += pictureBox_min_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 45, 80);
            label1.Location = new Point(39, 7);
            label1.Name = "label1";
            label1.Size = new Size(326, 28);
            label1.TabIndex = 4;
            label1.Text = "GrandStay Hotel Booking System";
            label1.MouseDown += Form1_MouseDown;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(23, 45, 80);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(flpNavLeft);
            panel1.Controls.Add(flpNavRight);
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 74);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(34, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(104, 69);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // flpNavLeft
            // 
            flpNavLeft.AutoSize = true;
            flpNavLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpNavLeft.BackColor = Color.Transparent;
            flpNavLeft.Controls.Add(btnNavHome);
            flpNavLeft.Controls.Add(btnNavRooms);
            flpNavLeft.Controls.Add(btnNavMyBookings);
            flpNavLeft.Controls.Add(btnNavAbout);
            flpNavLeft.Controls.Add(btnNavContact);
            flpNavLeft.Location = new Point(148, 11);
            flpNavLeft.Name = "flpNavLeft";
            flpNavLeft.Size = new Size(814, 52);
            flpNavLeft.TabIndex = 6;
            flpNavLeft.WrapContents = false;
            // 
            // btnNavHome
            // 
            btnNavHome.AutoSize = true;
            btnNavHome.Cursor = Cursors.Hand;
            btnNavHome.FlatAppearance.BorderSize = 0;
            btnNavHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnNavHome.FlatStyle = FlatStyle.Flat;
            btnNavHome.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavHome.ForeColor = Color.White;
            btnNavHome.Location = new Point(3, 0);
            btnNavHome.Margin = new Padding(3, 0, 8, 0);
            btnNavHome.Name = "btnNavHome";
            btnNavHome.Padding = new Padding(13, 7, 13, 7);
            btnNavHome.Size = new Size(107, 52);
            btnNavHome.TabIndex = 14;
            btnNavHome.Text = "Home";
            btnNavHome.UseMnemonic = false;
            btnNavHome.UseVisualStyleBackColor = true;
            btnNavHome.Click += btnNavHome_Click;
            // 
            // btnNavRooms
            // 
            btnNavRooms.AutoSize = true;
            btnNavRooms.Cursor = Cursors.Hand;
            btnNavRooms.FlatAppearance.BorderSize = 0;
            btnNavRooms.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnNavRooms.FlatStyle = FlatStyle.Flat;
            btnNavRooms.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavRooms.ForeColor = Color.White;
            btnNavRooms.Location = new Point(121, 0);
            btnNavRooms.Margin = new Padding(3, 0, 8, 0);
            btnNavRooms.Name = "btnNavRooms";
            btnNavRooms.Padding = new Padding(13, 7, 13, 7);
            btnNavRooms.Size = new Size(206, 52);
            btnNavRooms.TabIndex = 15;
            btnNavRooms.Text = "Rooms & Suites";
            btnNavRooms.UseMnemonic = false;
            btnNavRooms.UseVisualStyleBackColor = true;
            btnNavRooms.Click += btnNavRooms_Click;
            // 
            // btnNavMyBookings
            // 
            btnNavMyBookings.AutoSize = true;
            btnNavMyBookings.Cursor = Cursors.Hand;
            btnNavMyBookings.FlatAppearance.BorderSize = 0;
            btnNavMyBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnNavMyBookings.FlatStyle = FlatStyle.Flat;
            btnNavMyBookings.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavMyBookings.ForeColor = Color.White;
            btnNavMyBookings.Location = new Point(338, 0);
            btnNavMyBookings.Margin = new Padding(3, 0, 8, 0);
            btnNavMyBookings.Name = "btnNavMyBookings";
            btnNavMyBookings.Padding = new Padding(13, 7, 13, 7);
            btnNavMyBookings.Size = new Size(177, 52);
            btnNavMyBookings.TabIndex = 16;
            btnNavMyBookings.Text = "My Bookings";
            btnNavMyBookings.UseMnemonic = false;
            btnNavMyBookings.UseVisualStyleBackColor = true;
            btnNavMyBookings.Click += btnNavMyBookings_Click;
            // 
            // btnNavAbout
            // 
            btnNavAbout.AutoSize = true;
            btnNavAbout.Cursor = Cursors.Hand;
            btnNavAbout.FlatAppearance.BorderSize = 0;
            btnNavAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnNavAbout.FlatStyle = FlatStyle.Flat;
            btnNavAbout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavAbout.ForeColor = Color.White;
            btnNavAbout.Location = new Point(526, 0);
            btnNavAbout.Margin = new Padding(3, 0, 8, 0);
            btnNavAbout.Name = "btnNavAbout";
            btnNavAbout.Padding = new Padding(13, 7, 13, 7);
            btnNavAbout.Size = new Size(140, 52);
            btnNavAbout.TabIndex = 17;
            btnNavAbout.Text = "About Us";
            btnNavAbout.UseMnemonic = false;
            btnNavAbout.UseVisualStyleBackColor = true;
            btnNavAbout.Click += btnNavAbout_Click;
            // 
            // btnNavContact
            // 
            btnNavContact.AutoSize = true;
            btnNavContact.Cursor = Cursors.Hand;
            btnNavContact.FlatAppearance.BorderSize = 0;
            btnNavContact.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnNavContact.FlatStyle = FlatStyle.Flat;
            btnNavContact.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavContact.ForeColor = Color.White;
            btnNavContact.Location = new Point(677, 0);
            btnNavContact.Margin = new Padding(3, 0, 8, 0);
            btnNavContact.Name = "btnNavContact";
            btnNavContact.Padding = new Padding(13, 7, 13, 7);
            btnNavContact.Size = new Size(125, 52);
            btnNavContact.TabIndex = 18;
            btnNavContact.Text = "Contact";
            btnNavContact.UseMnemonic = false;
            btnNavContact.UseVisualStyleBackColor = true;
            btnNavContact.Click += btnNavContact_Click;
            // 
            // flpNavRight
            // 
            flpNavRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flpNavRight.AutoSize = true;
            flpNavRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpNavRight.BackColor = Color.Transparent;
            flpNavRight.Controls.Add(btnAdminPortal);
            flpNavRight.Controls.Add(btnSignIn);
            flpNavRight.Controls.Add(pnlUserSession);
            flpNavRight.Location = new Point(1160, 11);
            flpNavRight.Name = "flpNavRight";
            flpNavRight.Size = new Size(730, 54);
            flpNavRight.TabIndex = 7;
            flpNavRight.WrapContents = false;
            // 
            // btnAdminPortal
            // 
            btnAdminPortal.AutoSize = true;
            btnAdminPortal.Cursor = Cursors.Hand;
            btnAdminPortal.FlatAppearance.BorderColor = Color.FromArgb(70, 105, 150);
            btnAdminPortal.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnAdminPortal.FlatStyle = FlatStyle.Flat;
            btnAdminPortal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPortal.ForeColor = Color.LightSteelBlue;
            btnAdminPortal.Location = new Point(3, 0);
            btnAdminPortal.Margin = new Padding(3, 0, 12, 0);
            btnAdminPortal.Name = "btnAdminPortal";
            btnAdminPortal.Padding = new Padding(15, 7, 15, 7);
            btnAdminPortal.Size = new Size(222, 54);
            btnAdminPortal.TabIndex = 19;
            btnAdminPortal.Text = "🔒 Admin Portal";
            btnAdminPortal.UseMnemonic = false;
            btnAdminPortal.UseVisualStyleBackColor = true;
            btnAdminPortal.Click += btnAdminPortal_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSize = true;
            btnSignIn.BackColor = Color.White;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.FromArgb(23, 45, 80);
            btnSignIn.Location = new Point(240, 0);
            btnSignIn.Margin = new Padding(3, 0, 20, 0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Padding = new Padding(19, 7, 19, 7);
            btnSignIn.Size = new Size(233, 54);
            btnSignIn.TabIndex = 20;
            btnSignIn.Text = "Sign In / Register";
            btnSignIn.UseMnemonic = false;
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pnlUserSession
            // 
            pnlUserSession.AutoSize = true;
            pnlUserSession.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlUserSession.BackColor = Color.Transparent;
            pnlUserSession.Controls.Add(lblUserGreeting);
            pnlUserSession.Controls.Add(btnLogout);
            pnlUserSession.Location = new Point(496, 1);
            pnlUserSession.Margin = new Padding(3, 1, 20, 1);
            pnlUserSession.Name = "pnlUserSession";
            pnlUserSession.Size = new Size(234, 49);
            pnlUserSession.TabIndex = 21;
            pnlUserSession.Visible = false;
            pnlUserSession.WrapContents = false;
            // 
            // lblUserGreeting
            // 
            lblUserGreeting.AutoSize = true;
            lblUserGreeting.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserGreeting.ForeColor = Color.White;
            lblUserGreeting.Location = new Point(3, 8);
            lblUserGreeting.Margin = new Padding(3, 8, 12, 0);
            lblUserGreeting.Name = "lblUserGreeting";
            lblUserGreeting.Size = new Size(103, 30);
            lblUserGreeting.TabIndex = 0;
            lblUserGreeting.Text = "Hi, Guest";
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(192, 57, 43);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(121, 2);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(13, 5, 13, 5);
            btnLogout.Size = new Size(111, 45);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.MouseDown += Form1_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(customCalendar);
            Controls.Add(pictureBox5);
            Controls.Add(pnlPopup);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox_min);
            Controls.Add(pictureBox_close);
            Controls.Add(panel3);
            Controls.Add(pictureBox_max);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrandStay Hotel Booking System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDestCard.ResumeLayout(false);
            pnlDestCard.PerformLayout();
            pnlDateCard.ResumeLayout(false);
            pnlDateCard.PerformLayout();
            pnlGuestCard.ResumeLayout(false);
            pnlGuestCard.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlPopup.ResumeLayout(false);
            pnlPopup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMinusChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMinusAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlusChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlusAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_min).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flpNavLeft.ResumeLayout(false);
            flpNavLeft.PerformLayout();
            flpNavRight.ResumeLayout(false);
            flpNavRight.PerformLayout();
            pnlUserSession.ResumeLayout(false);
            pnlUserSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;

        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            if (panel == null || panel.Width <= radius * 2 || panel.Height <= radius * 2) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);
            }
        }

        private Panel pnlDestCard;
        private Label lblDestHeader;
        private ComboBox cmbDestination;
        private PictureBox pictureBox2;
        private Panel pnlDivider1;
        private Panel pnlDateCard;
        private PictureBox pictureBox3;
        private Label lblDateHeader;
        private Label lblDateDisplay;
        private Label lblStayDuration;
        private Panel pnlDivider2;
        private Panel pnlGuestCard;
        private PictureBox pictureBox4;
        private Label lblGuestHeader;
        private Label label5;
        private Label lblGuestSub;
        private PictureBox lblArrow;
        private Button button1;

        private Panel pnlPopup;
        private Label lblAdultTitle;
        private Label label8;
        private PictureBox picMinusAdult;
        private Label lblAdultCount;
        private PictureBox picPlusAdult;
        private Label lblChildTitle;
        private Label label9;
        private PictureBox picMinusChild;
        private Label lblChildCount;
        private PictureBox picPlusChild;
        private Button btnGuestsDone;

        private CustomCalendarControl customCalendar;

        private PictureBox pictureBox_max;
        private PictureBox pictureBox_close;
        private PictureBox pictureBox_min;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private FlowLayoutPanel flpNavLeft;
        private Button btnNavHome;
        private Button btnNavRooms;
        private Button btnNavMyBookings;
        private Button btnNavAbout;
        private Button btnNavContact;
        private FlowLayoutPanel flpNavRight;
        private Button btnAdminPortal;
        private Button btnSignIn;
        private FlowLayoutPanel pnlUserSession;
        private Label lblUserGreeting;
        private Button btnLogout;
    }
}
