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
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            lblArrow = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            pictureBox2 = new PictureBox();
            cmbDestination = new ComboBox();
            pnlTrigger = new FlowLayoutPanel();
            pnlPopup = new Panel();
            picMinusChild = new PictureBox();
            picMinusAdult = new PictureBox();
            picMinusRoom = new PictureBox();
            picPlusChild = new PictureBox();
            picPlusAdult = new PictureBox();
            picPlusRoom = new PictureBox();
            lblChildCount = new Label();
            lblAdultCount = new Label();
            lblRoomCount = new Label();
            label9 = new Label();
            label8 = new Label();
            lblChildTitle = new Label();
            lblAdultTitle = new Label();
            lblRoomTitle = new Label();
            panel3 = new Panel();
            pictureBox_max = new PictureBox();
            pictureBox_close = new PictureBox();
            pictureBox_min = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            lblTriggerAdults = new Label();
            lblTriggerRoom = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlPopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinusChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinusAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMinusRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlusChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlusAdult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlusRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_min).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 336);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 632);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblArrow);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpCheckOut);
            panel2.Controls.Add(dtpCheckIn);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(cmbDestination);
            panel2.Controls.Add(pnlTrigger);
            panel2.Location = new Point(261, 154);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1405, 139);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1240, 42);
            button1.Name = "button1";
            button1.Size = new Size(111, 56);
            button1.TabIndex = 14;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.WindowFrame;
            label6.Location = new Point(960, 71);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 13;
            label6.Text = "1 Room";
            label6.Click += pnlTrigger_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(958, 47);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 12;
            label5.Text = "1 Adult";
            label5.Click += pnlTrigger_Click;
            // 
            // lblArrow
            // 
            lblArrow.BackColor = Color.White;
            lblArrow.Image = (Image)resources.GetObject("lblArrow.Image");
            lblArrow.Location = new Point(1140, 45);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(45, 50);
            lblArrow.TabIndex = 6;
            lblArrow.TabStop = false;
            lblArrow.Click += pnlTrigger_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(891, 42);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 56);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(393, 42);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 56);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(662, 15);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 8;
            label4.Text = "Check Out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(452, 15);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 7;
            label3.Text = "Check In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(76, 12);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 6;
            label2.Text = "Destination";
            label2.Click += label2_Click;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CalendarFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckOut.Format = DateTimePickerFormat.Short;
            dtpCheckOut.Location = new Point(662, 45);
            dtpCheckOut.Margin = new Padding(3, 2, 3, 2);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(204, 53);
            dtpCheckOut.TabIndex = 5;
            dtpCheckOut.Value = new DateTime(2026, 11, 7, 0, 27, 48, 0);
            dtpCheckOut.ValueChanged += dtpCheckOut_ValueChanged;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CalendarFont = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCheckIn.Format = DateTimePickerFormat.Short;
            dtpCheckIn.Location = new Point(452, 45);
            dtpCheckIn.Margin = new Padding(3, 2, 3, 2);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(204, 53);
            dtpCheckIn.TabIndex = 2;
            dtpCheckIn.Value = new DateTime(2026, 11, 7, 0, 27, 48, 0);
            dtpCheckIn.ValueChanged += dtpCheckIn_ValueChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 42);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // cmbDestination
            // 
            cmbDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDestination.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDestination.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDestination.FormattingEnabled = true;
            cmbDestination.Location = new Point(76, 42);
            cmbDestination.Margin = new Padding(3, 2, 3, 2);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(294, 56);
            cmbDestination.TabIndex = 0;
            cmbDestination.SelectedIndexChanged += cmbDestination_SelectedIndexChanged;
            cmbDestination.Enter += cmbDestination_Enter;
            cmbDestination.Leave += cmbDestination_Leave;
            // 
            // pnlTrigger
            // 
            pnlTrigger.Anchor = AnchorStyles.None;
            pnlTrigger.BackColor = Color.White;
            pnlTrigger.Location = new Point(951, 42);
            pnlTrigger.Name = "pnlTrigger";
            pnlTrigger.Size = new Size(237, 56);
            pnlTrigger.TabIndex = 10;
            pnlTrigger.Click += pnlTrigger_Click;
            pnlTrigger.Paint += flowLayoutPanel1_Paint;
            // 
            // pnlPopup
            // 
            pnlPopup.BackColor = Color.White;
            pnlPopup.Controls.Add(picMinusChild);
            pnlPopup.Controls.Add(picMinusAdult);
            pnlPopup.Controls.Add(picMinusRoom);
            pnlPopup.Controls.Add(picPlusChild);
            pnlPopup.Controls.Add(picPlusAdult);
            pnlPopup.Controls.Add(picPlusRoom);
            pnlPopup.Controls.Add(lblChildCount);
            pnlPopup.Controls.Add(lblAdultCount);
            pnlPopup.Controls.Add(lblRoomCount);
            pnlPopup.Controls.Add(label9);
            pnlPopup.Controls.Add(label8);
            pnlPopup.Controls.Add(lblChildTitle);
            pnlPopup.Controls.Add(lblAdultTitle);
            pnlPopup.Controls.Add(lblRoomTitle);
            pnlPopup.Location = new Point(1212, 260);
            pnlPopup.Name = "pnlPopup";
            pnlPopup.Size = new Size(307, 191);
            pnlPopup.TabIndex = 11;
            pnlPopup.Visible = false;
            pnlPopup.Paint += panel4_Paint_1;
            // 
            // picMinusChild
            // 
            picMinusChild.Image = (Image)resources.GetObject("picMinusChild.Image");
            picMinusChild.Location = new Point(170, 126);
            picMinusChild.Name = "picMinusChild";
            picMinusChild.Size = new Size(32, 32);
            picMinusChild.SizeMode = PictureBoxSizeMode.Zoom;
            picMinusChild.TabIndex = 14;
            picMinusChild.TabStop = false;
            picMinusChild.Click += picMinusChild_Click;
            // 
            // picMinusAdult
            // 
            picMinusAdult.Image = (Image)resources.GetObject("picMinusAdult.Image");
            picMinusAdult.Location = new Point(170, 72);
            picMinusAdult.Name = "picMinusAdult";
            picMinusAdult.Size = new Size(32, 32);
            picMinusAdult.SizeMode = PictureBoxSizeMode.Zoom;
            picMinusAdult.TabIndex = 15;
            picMinusAdult.TabStop = false;
            picMinusAdult.Click += picMinusAdult_Click;
            // 
            // picMinusRoom
            // 
            picMinusRoom.Image = (Image)resources.GetObject("picMinusRoom.Image");
            picMinusRoom.Location = new Point(170, 16);
            picMinusRoom.Name = "picMinusRoom";
            picMinusRoom.Size = new Size(32, 32);
            picMinusRoom.SizeMode = PictureBoxSizeMode.Zoom;
            picMinusRoom.TabIndex = 13;
            picMinusRoom.TabStop = false;
            picMinusRoom.Click += picMinusRoom_Click;
            // 
            // picPlusChild
            // 
            picPlusChild.Image = (Image)resources.GetObject("picPlusChild.Image");
            picPlusChild.Location = new Point(241, 128);
            picPlusChild.Name = "picPlusChild";
            picPlusChild.Size = new Size(32, 32);
            picPlusChild.SizeMode = PictureBoxSizeMode.Zoom;
            picPlusChild.TabIndex = 13;
            picPlusChild.TabStop = false;
            picPlusChild.Click += picPlusChild_Click;
            // 
            // picPlusAdult
            // 
            picPlusAdult.Image = (Image)resources.GetObject("picPlusAdult.Image");
            picPlusAdult.Location = new Point(241, 72);
            picPlusAdult.Name = "picPlusAdult";
            picPlusAdult.Size = new Size(32, 32);
            picPlusAdult.SizeMode = PictureBoxSizeMode.Zoom;
            picPlusAdult.TabIndex = 14;
            picPlusAdult.TabStop = false;
            picPlusAdult.Click += picPlusAdult_Click;
            // 
            // picPlusRoom
            // 
            picPlusRoom.Image = (Image)resources.GetObject("picPlusRoom.Image");
            picPlusRoom.Location = new Point(241, 16);
            picPlusRoom.Name = "picPlusRoom";
            picPlusRoom.Size = new Size(32, 32);
            picPlusRoom.SizeMode = PictureBoxSizeMode.Zoom;
            picPlusRoom.TabIndex = 12;
            picPlusRoom.TabStop = false;
            picPlusRoom.Click += picPlusRoom_Click;
            // 
            // lblChildCount
            // 
            lblChildCount.AutoSize = true;
            lblChildCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChildCount.ForeColor = Color.Black;
            lblChildCount.Location = new Point(208, 128);
            lblChildCount.Name = "lblChildCount";
            lblChildCount.Size = new Size(25, 30);
            lblChildCount.TabIndex = 13;
            lblChildCount.Text = "0";
            // 
            // lblAdultCount
            // 
            lblAdultCount.AutoSize = true;
            lblAdultCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdultCount.ForeColor = Color.Black;
            lblAdultCount.Location = new Point(208, 72);
            lblAdultCount.Name = "lblAdultCount";
            lblAdultCount.Size = new Size(25, 30);
            lblAdultCount.TabIndex = 13;
            lblAdultCount.Text = "1";
            // 
            // lblRoomCount
            // 
            lblRoomCount.AutoSize = true;
            lblRoomCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomCount.ForeColor = Color.Black;
            lblRoomCount.Location = new Point(208, 16);
            lblRoomCount.Name = "lblRoomCount";
            lblRoomCount.Size = new Size(25, 30);
            lblRoomCount.TabIndex = 12;
            lblRoomCount.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.WindowFrame;
            label9.Location = new Point(15, 153);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 13;
            label9.Text = "Ages 0 - 17";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.WindowFrame;
            label8.Location = new Point(15, 97);
            label8.Name = "label8";
            label8.Size = new Size(131, 21);
            label8.TabIndex = 12;
            label8.Text = "Ages 18 or above";
            // 
            // lblChildTitle
            // 
            lblChildTitle.AutoSize = true;
            lblChildTitle.BackColor = Color.Transparent;
            lblChildTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildTitle.ForeColor = Color.Black;
            lblChildTitle.Location = new Point(13, 128);
            lblChildTitle.Name = "lblChildTitle";
            lblChildTitle.Size = new Size(100, 30);
            lblChildTitle.TabIndex = 13;
            lblChildTitle.Text = "Children";
            // 
            // lblAdultTitle
            // 
            lblAdultTitle.AutoSize = true;
            lblAdultTitle.BackColor = Color.Transparent;
            lblAdultTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdultTitle.ForeColor = Color.Black;
            lblAdultTitle.Location = new Point(13, 72);
            lblAdultTitle.Name = "lblAdultTitle";
            lblAdultTitle.Size = new Size(70, 30);
            lblAdultTitle.TabIndex = 13;
            lblAdultTitle.Text = "Adult";
            // 
            // lblRoomTitle
            // 
            lblRoomTitle.AutoSize = true;
            lblRoomTitle.BackColor = Color.Transparent;
            lblRoomTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomTitle.ForeColor = Color.Black;
            lblRoomTitle.Location = new Point(13, 16);
            lblRoomTitle.Name = "lblRoomTitle";
            lblRoomTitle.Size = new Size(72, 30);
            lblRoomTitle.TabIndex = 12;
            lblRoomTitle.Text = "Room";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Location = new Point(835, 336);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 673);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox_max
            // 
            pictureBox_max.Image = (Image)resources.GetObject("pictureBox_max.Image");
            pictureBox_max.Location = new Point(1841, -3);
            pictureBox_max.Margin = new Padding(3, 2, 3, 2);
            pictureBox_max.Name = "pictureBox_max";
            pictureBox_max.Padding = new Padding(5);
            pictureBox_max.Size = new Size(40, 40);
            pictureBox_max.TabIndex = 2;
            pictureBox_max.TabStop = false;
            pictureBox_max.Click += pictureBox_max_Click;
            pictureBox_max.MouseEnter += pictureBox_min_MouseEnter;
            pictureBox_max.MouseLeave += pictureBox_min_MouseLeave;
            // 
            // pictureBox_close
            // 
            pictureBox_close.Image = (Image)resources.GetObject("pictureBox_close.Image");
            pictureBox_close.Location = new Point(1881, -3);
            pictureBox_close.Margin = new Padding(3, 2, 3, 2);
            pictureBox_close.Name = "pictureBox_close";
            pictureBox_close.Padding = new Padding(5);
            pictureBox_close.Size = new Size(40, 40);
            pictureBox_close.TabIndex = 1;
            pictureBox_close.TabStop = false;
            pictureBox_close.Click += pictureBox_close_Click;
            pictureBox_close.MouseEnter += pictureBox_min_MouseEnter;
            pictureBox_close.MouseLeave += pictureBox_min_MouseLeave;
            // 
            // pictureBox_min
            // 
            pictureBox_min.Image = (Image)resources.GetObject("pictureBox_min.Image");
            pictureBox_min.Location = new Point(1801, -3);
            pictureBox_min.Margin = new Padding(3, 2, 3, 2);
            pictureBox_min.Name = "pictureBox_min";
            pictureBox_min.Padding = new Padding(5);
            pictureBox_min.Size = new Size(40, 40);
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
            label1.Click += label1_Click_2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 45, 80);
            panel1.Controls.Add(pictureBox6);
            panel1.Location = new Point(-4, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1925, 70);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(34, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(99, 66);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // lblTriggerAdults
            // 
            lblTriggerAdults.AutoSize = true;
            lblTriggerAdults.BackColor = Color.White;
            lblTriggerAdults.ForeColor = Color.Black;
            lblTriggerAdults.Location = new Point(962, 47);
            lblTriggerAdults.Name = "lblTriggerAdults";
            lblTriggerAdults.Size = new Size(70, 25);
            lblTriggerAdults.TabIndex = 12;
            lblTriggerAdults.Text = "1 Adult";
            lblTriggerAdults.Click += pnlTrigger_Click;
            // 
            // lblTriggerRoom
            // 
            lblTriggerRoom.AutoSize = true;
            lblTriggerRoom.BackColor = Color.White;
            lblTriggerRoom.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTriggerRoom.ForeColor = SystemColors.WindowFrame;
            lblTriggerRoom.Location = new Point(963, 73);
            lblTriggerRoom.Name = "lblTriggerRoom";
            lblTriggerRoom.Size = new Size(65, 21);
            lblTriggerRoom.TabIndex = 13;
            lblTriggerRoom.Text = "1 Room";
            lblTriggerRoom.Click += pnlTrigger_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
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
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)picMinusRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlusChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlusAdult).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlusRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_max).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_min).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private ComboBox cmbDestination;
        private PictureBox pictureBox2;
        private PictureBox pictureBox_max;
        private PictureBox pictureBox_close;
        private PictureBox pictureBox_min;
        private Label label1;
        private DateTimePicker dtpCheckIn;
        private Label label2;
        private DateTimePicker dtpCheckOut;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox4;
        private FlowLayoutPanel pnlTrigger;
        
        private PictureBox lblArrow;
        private Panel pnlPopup;
        private Label lblChildTitle;
        private Label lblAdultTitle;
        private Label lblRoomTitle;
        private Label label8;
        private Label label9;
        private Label lblRoomCount;
        private Label lblChildCount;
        private Label lblAdultCount;
        private PictureBox picMinusChild;
        private PictureBox picMinusAdult;
        private PictureBox picMinusRoom;
        private PictureBox picPlusChild;
        private PictureBox picPlusAdult;
        private PictureBox picPlusRoom;
        private Label lblTriggerAdults;
        private Label lblTriggerRoom;
        private Label label6;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
