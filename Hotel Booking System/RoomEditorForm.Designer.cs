using System.ComponentModel;

namespace Hotel_Booking_System
{
    partial class RoomEditorForm
    {
        private IContainer components = null;

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
            pnlBody = new Panel();
            pnlTip = new Panel();
            lblTip = new Label();
            lblDestination = new Label();
            cmbDestination = new ComboBox();
            lblRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblRoomName = new Label();
            txtRoomName = new TextBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            lblAdults = new Label();
            nudAdults = new NumericUpDown();
            lblChildren = new Label();
            nudChildren = new NumericUpDown();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblCapacityHint = new Label();
            lblCapacityNote = new Label();
            lblAmenities = new Label();
            txtAmenities = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlTip.SuspendLayout();
            ((ISupportInitialize)nudPrice).BeginInit();
            ((ISupportInitialize)nudAdults).BeginInit();
            ((ISupportInitialize)nudChildren).BeginInit();
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
            pnlHeader.Size = new Size(820, 56);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(206, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🛏️ Add New Room";
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
            btnClose.Location = new Point(766, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(42, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.White;
            pnlBody.Controls.Add(pnlTip);
            pnlBody.Controls.Add(lblDestination);
            pnlBody.Controls.Add(cmbDestination);
            pnlBody.Controls.Add(lblRoomNumber);
            pnlBody.Controls.Add(txtRoomNumber);
            pnlBody.Controls.Add(lblRoomType);
            pnlBody.Controls.Add(cmbRoomType);
            pnlBody.Controls.Add(lblRoomName);
            pnlBody.Controls.Add(txtRoomName);
            pnlBody.Controls.Add(lblPrice);
            pnlBody.Controls.Add(nudPrice);
            pnlBody.Controls.Add(lblAdults);
            pnlBody.Controls.Add(nudAdults);
            pnlBody.Controls.Add(lblChildren);
            pnlBody.Controls.Add(nudChildren);
            pnlBody.Controls.Add(lblStatus);
            pnlBody.Controls.Add(cmbStatus);
            pnlBody.Controls.Add(lblCapacityHint);
            pnlBody.Controls.Add(lblCapacityNote);
            pnlBody.Controls.Add(lblAmenities);
            pnlBody.Controls.Add(txtAmenities);
            pnlBody.Controls.Add(lblDescription);
            pnlBody.Controls.Add(txtDescription);
            pnlBody.Controls.Add(btnCancel);
            pnlBody.Controls.Add(btnSave);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 56);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(820, 664);
            pnlBody.TabIndex = 1;
            pnlBody.Paint += pnlBody_Paint;
            // 
            // pnlTip
            // 
            pnlTip.BackColor = Color.FromArgb(242, 247, 255);
            pnlTip.Controls.Add(lblTip);
            pnlTip.Location = new Point(30, 16);
            pnlTip.Name = "pnlTip";
            pnlTip.Size = new Size(760, 42);
            pnlTip.TabIndex = 0;
            pnlTip.Paint += pnlTip_Paint;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTip.ForeColor = Color.FromArgb(23, 45, 80);
            lblTip.Location = new Point(14, 10);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(656, 21);
            lblTip.TabIndex = 0;
            lblTip.Text = "💡 Tip: Room code auto-formats from destination. Name & amenities auto-fill if left blank.";
            lblTip.UseMnemonic = false;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestination.ForeColor = Color.FromArgb(23, 45, 80);
            lblDestination.Location = new Point(30, 72);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(189, 21);
            lblDestination.TabIndex = 1;
            lblDestination.Text = "Destination / Location: *";
            // 
            // cmbDestination
            // 
            cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestination.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDestination.FormattingEnabled = true;
            cmbDestination.Items.AddRange(new object[] { "Phnom Penh", "Siem Reap", "Sihanoukville", "Kampot", "Battambang", "Kep" });
            cmbDestination.Location = new Point(30, 96);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(365, 31);
            cmbDestination.TabIndex = 2;
            cmbDestination.SelectedIndexChanged += cmbDestination_SelectedIndexChanged;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.ForeColor = Color.FromArgb(23, 45, 80);
            lblRoomNumber.Location = new Point(425, 72);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(207, 21);
            lblRoomNumber.TabIndex = 3;
            lblRoomNumber.Text = "Room Number / Code: *";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(425, 96);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.PlaceholderText = "e.g. 101 (Auto: PP-101)";
            txtRoomNumber.Size = new Size(365, 31);
            txtRoomNumber.TabIndex = 4;
            txtRoomNumber.Leave += txtRoomNumber_Leave;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomType.ForeColor = Color.FromArgb(23, 45, 80);
            lblRoomType.Location = new Point(30, 144);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(183, 21);
            lblRoomType.TabIndex = 5;
            lblRoomType.Text = "Room Type Category: *";
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Deluxe", "Suite", "Executive", "Presidential", "Villa", "Standard" });
            cmbRoomType.Location = new Point(30, 168);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(365, 31);
            cmbRoomType.TabIndex = 6;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomName.ForeColor = Color.FromArgb(23, 45, 80);
            lblRoomName.Location = new Point(425, 144);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(248, 21);
            lblRoomName.TabIndex = 7;
            lblRoomName.Text = "Room Name: (Auto-fills if blank)";
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomName.Location = new Point(425, 168);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.PlaceholderText = "Auto-fills standard room name";
            txtRoomName.Size = new Size(365, 30);
            txtRoomName.TabIndex = 8;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(23, 45, 80);
            lblPrice.Location = new Point(30, 216);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(160, 21);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price / Night ($): *";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrice.Location = new Point(30, 240);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(225, 30);
            nudPrice.TabIndex = 10;
            nudPrice.Value = new decimal(new int[] { 125, 0, 0, 0 });
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdults.ForeColor = Color.FromArgb(23, 45, 80);
            lblAdults.Location = new Point(285, 216);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(106, 21);
            lblAdults.TabIndex = 11;
            lblAdults.Text = "Max Adults: *";
            // 
            // nudAdults
            // 
            nudAdults.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudAdults.Location = new Point(285, 240);
            nudAdults.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudAdults.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdults.Name = "nudAdults";
            nudAdults.Size = new Size(225, 30);
            nudAdults.TabIndex = 12;
            nudAdults.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblChildren
            // 
            lblChildren.AutoSize = true;
            lblChildren.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildren.ForeColor = Color.FromArgb(23, 45, 80);
            lblChildren.Location = new Point(540, 216);
            lblChildren.Name = "lblChildren";
            lblChildren.Size = new Size(122, 21);
            lblChildren.TabIndex = 13;
            lblChildren.Text = "Max Children:";
            // 
            // nudChildren
            // 
            nudChildren.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudChildren.Location = new Point(540, 240);
            nudChildren.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudChildren.Name = "nudChildren";
            nudChildren.Size = new Size(250, 30);
            nudChildren.TabIndex = 14;
            nudChildren.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(23, 45, 80);
            lblStatus.Location = new Point(30, 288);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 21);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Operational Status: *";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance", "Reserved" });
            cmbStatus.Location = new Point(30, 312);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(365, 31);
            cmbStatus.TabIndex = 16;
            // 
            // lblCapacityHint
            // 
            lblCapacityHint.AutoSize = true;
            lblCapacityHint.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCapacityHint.ForeColor = Color.Gray;
            lblCapacityHint.Location = new Point(425, 288);
            lblCapacityHint.Name = "lblCapacityHint";
            lblCapacityHint.Size = new Size(130, 20);
            lblCapacityHint.TabIndex = 17;
            lblCapacityHint.Text = "Capacity Guidance:";
            // 
            // lblCapacityNote
            // 
            lblCapacityNote.AutoSize = true;
            lblCapacityNote.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacityNote.ForeColor = Color.FromArgb(50, 80, 120);
            lblCapacityNote.Location = new Point(425, 316);
            lblCapacityNote.Name = "lblCapacityNote";
            lblCapacityNote.Size = new Size(346, 21);
            lblCapacityNote.TabIndex = 18;
            lblCapacityNote.Text = "✨ Standard: 2 Adults, 1 Child (Fully Editable)";
            // 
            // lblAmenities
            // 
            lblAmenities.AutoSize = true;
            lblAmenities.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmenities.ForeColor = Color.FromArgb(23, 45, 80);
            lblAmenities.Location = new Point(30, 360);
            lblAmenities.Name = "lblAmenities";
            lblAmenities.Size = new Size(428, 21);
            lblAmenities.TabIndex = 19;
            lblAmenities.Text = "Amenities: (Auto-fills standard luxury package if blank)";
            // 
            // txtAmenities
            // 
            txtAmenities.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmenities.Location = new Point(30, 384);
            txtAmenities.Name = "txtAmenities";
            txtAmenities.PlaceholderText = "Auto-fills standard luxury amenities if blank";
            txtAmenities.Size = new Size(760, 29);
            txtAmenities.TabIndex = 20;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(23, 45, 80);
            lblDescription.Location = new Point(30, 432);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(331, 21);
            lblDescription.TabIndex = 21;
            lblDescription.Text = "Room Description: (Auto-generated if blank)";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(30, 456);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(760, 95);
            txtDescription.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 225);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(100, 115, 135);
            btnCancel.Location = new Point(450, 580);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 46);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(23, 45, 80);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 65, 110);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(625, 580);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 46);
            btnSave.TabIndex = 24;
            btnSave.Text = "💾 Save Room";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // RoomEditorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 225, 238);
            ClientSize = new Size(820, 720);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomEditorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Room Inventory Editor";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlTip.ResumeLayout(false);
            pnlTip.PerformLayout();
            ((ISupportInitialize)nudPrice).EndInit();
            ((ISupportInitialize)nudAdults).EndInit();
            ((ISupportInitialize)nudChildren).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Panel pnlBody;
        private Panel pnlTip;
        private Label lblTip;
        private Label lblDestination;
        private ComboBox cmbDestination;
        private Label lblRoomNumber;
        private TextBox txtRoomNumber;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Label lblRoomName;
        private TextBox txtRoomName;
        private Label lblPrice;
        private NumericUpDown nudPrice;
        private Label lblAdults;
        private NumericUpDown nudAdults;
        private Label lblChildren;
        private NumericUpDown nudChildren;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblCapacityHint;
        private Label lblCapacityNote;
        private Label lblAmenities;
        private TextBox txtAmenities;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnSave;
    }
}
