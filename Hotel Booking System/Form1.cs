using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Maximized;

            cmbDestination.Items.Clear();
            cmbDestination.Items.Add("Phnom Penh");
            cmbDestination.Items.Add("Siem Reap");
            cmbDestination.Items.Add("Sihanoukville");
            cmbDestination.Items.Add("Kampot");
            cmbDestination.Items.Add("Battambang");
            cmbDestination.Items.Add("Kep");

            cmbDestination.Text = "Select Location";

            // Configure custom calendar (starts with no dates selected)
            customCalendar.DatesChanged += (s, e) => UpdateDateDisplay();
            customCalendar.CloseRequested += (s, e) => customCalendar.Visible = false;
            UpdateDateDisplay();
            UpdateCounts();

            // Subscribe to session authentication changes
            SessionManager.OnSessionChanged += UpdateUserSessionUI;
            UpdateUserSessionUI();

            this.Resize += (s, e) => PerformResponsiveLayout();
            this.Click += (s, e) => ClosePopups();
            pictureBox1.Click += (s, e) => ClosePopups();
            panel3.Click += (s, e) => ClosePopups();
            panel2.Click += (s, e) => ClosePopups();

            PerformResponsiveLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PerformResponsiveLayout();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_min_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pic)
            {
                pic.BackColor = Color.LightGray;
            }
        }

        private void pictureBox_min_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pic)
            {
                pic.BackColor = Color.Transparent;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDestination_Enter(object sender, EventArgs e)
        {
            if (cmbDestination.Text == "Select Location")
            {
                cmbDestination.Text = "";
            }
        }

        private void cmbDestination_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbDestination.Text))
            {
                cmbDestination.Text = "Select Location";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(panel2, 20);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(panel3, 20);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateDateDisplay()
        {
            if (customCalendar == null || lblDateDisplay == null || lblStayDuration == null) return;

            DateTime? inDate  = customCalendar.TotalNights > 0 ? customCalendar.CheckInDate  : (DateTime?)null;
            DateTime? outDate = customCalendar.TotalNights > 0 ? customCalendar.CheckOutDate : (DateTime?)null;

            if (inDate.HasValue && outDate.HasValue)
            {
                lblDateDisplay.Text  = $"{inDate.Value:ddd, MMM dd} → {outDate.Value:ddd, MMM dd}";
                int nights = customCalendar.TotalNights;
                string nightText = nights == 1 ? "1 night" : $"{nights} nights";
                string dayText   = (nights + 1) == 1 ? "1 day" : $"{nights + 1} days";
                lblStayDuration.Text = $"🌙 {nightText} stay ({dayText})";
            }
            else if (inDate.HasValue)
            {
                lblDateDisplay.Text  = $"{inDate.Value:ddd, MMM dd} → Select check-out";
                lblStayDuration.Text = "🌙 Pick a check-out date";
            }
            else
            {
                lblDateDisplay.Text  = "Select check-in date";
                lblStayDuration.Text = "🌙 Pick your dates";
            }
        }

        private void pnlDateCard_Click(object sender, EventArgs e)
        {
            if (pnlPopup != null) pnlPopup.Visible = false;
            if (customCalendar == null) return;

            customCalendar.Visible = !customCalendar.Visible;
            if (customCalendar.Visible)
            {
                UpdateCalendarPosition();
                customCalendar.BringToFront();
            }
        }

        private void pnlGuestCard_Click(object sender, EventArgs e)
        {
            if (customCalendar != null) customCalendar.Visible = false;
            if (pnlPopup == null) return;

            pnlPopup.Visible = !pnlPopup.Visible;
            if (pnlPopup.Visible)
            {
                UpdatePopupPosition();
                pnlPopup.BringToFront();
            }
        }

        private void ClosePopups()
        {
            if (pnlPopup != null && pnlPopup.Visible)
            {
                pnlPopup.Visible = false;
            }
            if (customCalendar != null && customCalendar.Visible)
            {
                customCalendar.Visible = false;
            }
        }

        private void UpdateCalendarPosition()
        {
            if (panel2 != null && pnlDateCard != null && customCalendar != null)
            {
                customCalendar.Left = panel2.Left + pnlDateCard.Left;
                customCalendar.Top = panel2.Bottom + 4;
                customCalendar.BringToFront();
            }
        }

        private void UpdatePopupPosition()
        {
            if (panel2 != null && pnlGuestCard != null && pnlPopup != null)
            {
                pnlPopup.Left = panel2.Left + pnlGuestCard.Left;
                pnlPopup.Top = panel2.Bottom + 4;
                pnlPopup.BringToFront();
            }
        }

        private void pnlDestCard_Paint(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(pnlDestCard, 14);
        }

        private void pnlDateCard_Paint(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(pnlDateCard, 14);
        }

        private void pnlGuestCard_Paint(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(pnlGuestCard, 14);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var roomsForm = new RoomsForm();
            roomsForm.ShowDialog(this);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            ApplyRoundedCorners(pnlPopup, 16);
        }

        private void btnGuestsDone_Click(object sender, EventArgs e)
        {
            if (pnlPopup != null)
            {
                pnlPopup.Visible = false;
            }
        }

        private int adults = 1;
        private int children = 0;

        // Adult Steppers
        private void picPlusAdult_Click(object sender, EventArgs e)
        {
            adults++;
            UpdateCounts();
        }

        private void picMinusAdult_Click(object sender, EventArgs e)
        {
            if (adults > 1)
            {
                adults--;
                UpdateCounts();
            }
        }

        // Children Steppers
        private void picPlusChild_Click(object sender, EventArgs e)
        {
            children++;
            UpdateCounts();
        }

        private void picMinusChild_Click(object sender, EventArgs e)
        {
            if (children > 0)
            {
                children--;
                UpdateCounts();
            }
        }

        // Refresh UI Labels and Top Trigger Display
        private void UpdateCounts()
        {
            if (lblAdultCount != null) lblAdultCount.Text = adults.ToString();
            if (lblChildCount != null) lblChildCount.Text = children.ToString();

            string adultText = adults == 1 ? "1 Adult" : $"{adults} Adults";
            string childText = children == 0 ? "" : (children == 1 ? ", 1 Child" : $", {children} Children");
            if (label5 != null) label5.Text = adultText + childText;

            int totalGuests = adults + children;
            if (lblGuestSub != null)
            {
                lblGuestSub.Text = children > 0 ? $"{totalGuests} Guests total" : "All ages (18+ / 0-17)";
            }
        }

        #region Navigation & Authentication Event Handlers

        private void UpdateUserSessionUI()
        {
            if (SessionManager.IsLoggedIn)
            {
                btnSignIn.Visible = false;
                pnlUserSession.Visible = true;
                lblUserGreeting.Text = $"Hi, {SessionManager.CurrentUserName}";

                if (SessionManager.CurrentUserRole == "Admin")
                {
                    btnAdminPortal.Visible = true;
                    btnAdminPortal.Text = "📊 Open Dashboard";
                }
                else
                {
                    btnAdminPortal.Visible = false;
                }
            }
            else
            {
                btnAdminPortal.Text = "🔒 Admin Portal";
                btnAdminPortal.Visible = true;
                btnSignIn.Visible = true;
                pnlUserSession.Visible = false;
            }

            CenterNavbarControls();
        }

        private void PerformResponsiveLayout()
        {
            if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0) return;

            this.SuspendLayout();

            // 1. Maintain clean placement for top title bar controls
            int topBtnY = 3;
            pictureBox_close.Location = new Point(this.ClientSize.Width - 46, topBtnY);
            pictureBox_max.Location = new Point(this.ClientSize.Width - 90, topBtnY);
            pictureBox_min.Location = new Point(this.ClientSize.Width - 134, topBtnY);

            // 2. Adjust Navbar panel1 width and vertically center navigation items
            panel1.Location = new Point(0, 43);
            panel1.Width = this.ClientSize.Width;
            panel1.Height = 74;
            CenterNavbarControls();

            // 3. Center Search Container (panel2) horizontally
            int searchTop = panel1.Bottom + 22;
            panel2.Top = searchTop;
            panel2.Size = new Size(1475, 146);
            if (this.ClientSize.Width >= panel2.Width + 40)
            {
                panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            }
            else
            {
                panel2.Left = Math.Max(10, (this.ClientSize.Width - panel2.Width) / 2);
            }
            ApplyRoundedCorners(panel2, 20);

            // 4. Update dropdown / calendar position if open
            if (pnlPopup != null && pnlPopup.Visible) UpdatePopupPosition();
            if (customCalendar != null && customCalendar.Visible) UpdateCalendarPosition();

            // 5. Main content area: pictureBox1 (Hero Visual) & panel3 (Room Cards Container)
            int contentTop = panel2.Bottom + 22;
            int contentHeight = Math.Max(260, this.ClientSize.Height - contentTop - 25);
            int marginX = 30;
            int gap = 20;
            int availableWidth = this.ClientSize.Width - (marginX * 2);

            if (availableWidth > 650)
            {
                // Responsive side-by-side layout
                int picWidth = Math.Clamp((int)(availableWidth * 0.42), 420, 840);
                int panel3Width = availableWidth - picWidth - gap;

                pictureBox1.Location = new Point(marginX, contentTop);
                pictureBox1.Size = new Size(picWidth, contentHeight);
                pictureBox1.Visible = true;

                panel3.Location = new Point(pictureBox1.Right + gap, contentTop);
                panel3.Size = new Size(panel3Width, contentHeight);
            }
            else
            {
                // Narrow screen fallback
                panel3.Location = new Point(marginX, contentTop);
                panel3.Size = new Size(availableWidth, contentHeight);
            }

            ApplyRoundedCorners(panel3, 20);

            this.ResumeLayout();
        }

        private void CenterNavbarControls()
        {
            if (panel1 == null) return;
            int h = panel1.ClientSize.Height;

            if (pictureBox6 != null)
            {
                pictureBox6.Top = Math.Max(0, (h - pictureBox6.Height) / 2);
            }

            if (flpNavLeft != null)
            {
                flpNavLeft.Top = Math.Max(0, (h - flpNavLeft.Height) / 2);
            }

            if (flpNavRight != null)
            {
                flpNavRight.Top = Math.Max(0, (h - flpNavRight.Height) / 2);
                flpNavRight.Left = Math.Max(flpNavLeft != null ? flpNavLeft.Right + 15 : 0, panel1.ClientSize.Width - flpNavRight.Width - 25);
            }
        }

        private void btnNavHome_Click(object sender, EventArgs e)
        {
            cmbDestination.Focus();
        }

        private void btnNavRooms_Click(object sender, EventArgs e)
        {
            using var roomsForm = new RoomsForm();
            roomsForm.ShowDialog(this);
        }

        private void btnNavMyBookings_Click(object sender, EventArgs e)
        {
            using var bookingsForm = new MyBookingsForm();
            bookingsForm.ShowDialog(this);
        }

        private void btnNavAbout_Click(object sender, EventArgs e)
        {
            using var aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void btnNavContact_Click(object sender, EventArgs e)
        {
            using var contactForm = new ContactForm();
            contactForm.ShowDialog(this);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using var authForm = new AuthForm(initialTab: 0);
            authForm.ShowDialog(this);
        }

        private void btnAdminPortal_Click(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn && SessionManager.CurrentUserRole == "Admin")
            {
                using var adminDashboard = new AdminDashboardForm();
                adminDashboard.ShowDialog(this);
            }
            else
            {
                using var authForm = new AuthForm(initialTab: 2);
                authForm.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to sign out?",
                "Sign Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();
            }
        }

        #endregion

    }
}
