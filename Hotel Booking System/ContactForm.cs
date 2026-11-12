using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class ContactForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public ContactForm()
        {
            InitializeComponent();
            cmbSubject.SelectedIndex = 0;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string message = txtMessage.Text.Trim();
            string subject = cmbSubject.SelectedItem?.ToString() ?? "General Inquiry";

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please write your message or inquiry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMessage.Focus();
                return;
            }

            MessageBox.Show(
                $"Thank you, {name}!\n\nYour message regarding \"{subject}\" has been dispatched to our concierge team.\nWe will contact you at {email} within 24 hours.",
                "Inquiry Received",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtMessage.Clear();
            cmbSubject.SelectedIndex = 0;
            this.Close();
        }
    }
}
