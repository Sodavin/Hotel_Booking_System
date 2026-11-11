namespace Hotel_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbDestination.Items.Clear();
            cmbDestination.Items.Add("Phnom Penh");
            cmbDestination.Items.Add("Siem Reap");
            cmbDestination.Items.Add("Sihanoukville");
            cmbDestination.Items.Add("Kampot");
            cmbDestination.Items.Add("Battambang");
            cmbDestination.Items.Add("Kep");

            cmbDestination.Text = "Select Location";
            // Prevent check-in from selecting past dates
            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckIn.Value = DateTime.Today;

            // Set initial check-out minimum to tomorrow
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);
            dtpCheckOut.Value = DateTime.Today.AddDays(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.LightGray;
        }

        private void pictureBox_min_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.BackColor = Color.Transparent;
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

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            // Ensure check-out minimum date is at least the day after check-in
            dtpCheckOut.MinDate = dtpCheckIn.Value.AddDays(1);

            // If the current check-out date is now older than the new check-in date,
            // automatically push check-out forward by 1 day
            if (dtpCheckOut.Value < dtpCheckIn.Value)
            {
                dtpCheckOut.Value = dtpCheckIn.Value.AddDays(1);
            }
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //ApplyRoundedCorners(panel1, 50);

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.LightGray, 1))
            {
                // Draw the border rectangle along the exact edges of the panel
                e.Graphics.DrawRectangle(borderPen, 0, 0, pnlTrigger.Width - 1, pnlTrigger.Height - 1);
            }
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
            ApplyRoundedCorners(pnlPopup, 20);

        }

        private int rooms = 1;
        private int adults = 1;
        private int children = 0;

        // Toggle popup visibility when clicking the trigger container, arrow, or text labels
        private void pnlTrigger_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = !pnlPopup.Visible;
        }

        private void picArrow_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = !pnlPopup.Visible;
        }

        private void lblTriggerAdults_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = !pnlPopup.Visible;
        }

        private void lblTriggerRoom_Click(object sender, EventArgs e)
        {
            pnlPopup.Visible = !pnlPopup.Visible;
        }

        // Room Steppers
        private void picPlusRoom_Click(object sender, EventArgs e)
        {
            rooms++;
            UpdateCounts();
        }

        private void picMinusRoom_Click(object sender, EventArgs e)
        {
            if (rooms > 1)
            {
                rooms--;
                UpdateCounts();
            }
        }

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
            // Update numbers inside the popup dropdown rows
            lblRoomCount.Text = rooms.ToString();
            lblAdultCount.Text = adults.ToString();
            lblChildCount.Text = children.ToString();

            // Line 1: Format adults and conditional children text
            string adultText = adults == 1 ? "1 adult" : $"{adults} adults";
            string childText = "";

            if (children > 0)
            {
                childText = children == 1 ? ",1 child" : $",{children} children";
            }

            label5.Text = adultText + childText;

            // Line 2: Format room text
            string roomText = rooms == 1 ? "1 room" : $"{rooms} rooms";
            label6.Text = roomText;
        }

    }
}
