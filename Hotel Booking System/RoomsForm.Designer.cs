namespace Hotel_Booking_System
{
    partial class RoomsForm
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
            pnlFilterBar = new Panel();
            lblResultCount = new Label();
            cmbTypeFilter = new ComboBox();
            lblTypeFilter = new Label();
            cmbLocationFilter = new ComboBox();
            lblLocFilter = new Label();
            flpRoomsContainer = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlFilterBar.SuspendLayout();
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
            pnlHeader.Size = new Size(1100, 55);
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
            lblTitle.TabIndex = 1;
            lblTitle.Text = "🏨 GrandStay — Rooms & Luxury Suites";
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
            btnClose.Location = new Point(1055, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlFilterBar
            // 
            pnlFilterBar.BackColor = Color.White;
            pnlFilterBar.Controls.Add(lblResultCount);
            pnlFilterBar.Controls.Add(cmbTypeFilter);
            pnlFilterBar.Controls.Add(lblTypeFilter);
            pnlFilterBar.Controls.Add(cmbLocationFilter);
            pnlFilterBar.Controls.Add(lblLocFilter);
            pnlFilterBar.Dock = DockStyle.Top;
            pnlFilterBar.Location = new Point(0, 55);
            pnlFilterBar.Name = "pnlFilterBar";
            pnlFilterBar.Size = new Size(1100, 65);
            pnlFilterBar.TabIndex = 1;
            // 
            // lblLocFilter
            // 
            lblLocFilter.AutoSize = true;
            lblLocFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocFilter.ForeColor = Color.FromArgb(23, 45, 80);
            lblLocFilter.Location = new Point(25, 20);
            lblLocFilter.Name = "lblLocFilter";
            lblLocFilter.TabIndex = 0;
            lblLocFilter.Text = "Destination:";
            // 
            // cmbLocationFilter
            // 
            cmbLocationFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocationFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbLocationFilter.FormattingEnabled = true;
            cmbLocationFilter.Items.AddRange(new object[] {
            "All Locations",
            "Phnom Penh",
            "Siem Reap",
            "Sihanoukville",
            "Kampot",
            "Battambang",
            "Kep"});
            cmbLocationFilter.Location = new Point(130, 16);
            cmbLocationFilter.Name = "cmbLocationFilter";
            cmbLocationFilter.Size = new Size(195, 29);
            cmbLocationFilter.TabIndex = 1;
            cmbLocationFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblTypeFilter
            // 
            lblTypeFilter.AutoSize = true;
            lblTypeFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTypeFilter.ForeColor = Color.FromArgb(23, 45, 80);
            lblTypeFilter.Location = new Point(352, 20);
            lblTypeFilter.Name = "lblTypeFilter";
            lblTypeFilter.TabIndex = 2;
            lblTypeFilter.Text = "Room Type:";
            // 
            // cmbTypeFilter
            // 
            cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTypeFilter.FormattingEnabled = true;
            cmbTypeFilter.Items.AddRange(new object[] {
            "All Types",
            "Suite",
            "Presidential",
            "Deluxe",
            "Standard"});
            cmbTypeFilter.Location = new Point(462, 16);
            cmbTypeFilter.Name = "cmbTypeFilter";
            cmbTypeFilter.Size = new Size(195, 29);
            cmbTypeFilter.TabIndex = 3;
            cmbTypeFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // lblResultCount
            // 
            lblResultCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResultCount.AutoSize = true;
            lblResultCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultCount.ForeColor = Color.FromArgb(23, 45, 80);
            lblResultCount.Location = new Point(690, 20);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.TabIndex = 4;
            lblResultCount.Text = "Showing 6 accommodations";
            // 
            // flpRoomsContainer
            // 
            flpRoomsContainer.AutoScroll = true;
            flpRoomsContainer.BackColor = Color.FromArgb(245, 247, 250);
            flpRoomsContainer.Dock = DockStyle.Fill;
            flpRoomsContainer.Location = new Point(0, 120);
            flpRoomsContainer.Name = "flpRoomsContainer";
            flpRoomsContainer.Padding = new Padding(20, 15, 20, 15);
            flpRoomsContainer.Size = new Size(1100, 580);
            flpRoomsContainer.TabIndex = 2;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1100, 700);
            Controls.Add(flpRoomsContainer);
            Controls.Add(pnlFilterBar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GrandStay Rooms & Suites";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilterBar.ResumeLayout(false);
            pnlFilterBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Panel pnlFilterBar;
        private Label lblLocFilter;
        private ComboBox cmbLocationFilter;
        private Label lblTypeFilter;
        private ComboBox cmbTypeFilter;
        private Label lblResultCount;
        private FlowLayoutPanel flpRoomsContainer;
    }
}
