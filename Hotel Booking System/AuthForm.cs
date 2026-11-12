using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class AuthForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public AuthForm(int initialTab = 0)
        {
            InitializeComponent();
            SelectTab(initialTab);
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

        private void SelectTab(int tabIndex)
        {
            // Reset button styles
            btnTabSignIn.BackColor = Color.White;
            btnTabSignIn.ForeColor = Color.FromArgb(70, 80, 95);

            btnTabRegister.BackColor = Color.White;
            btnTabRegister.ForeColor = Color.FromArgb(70, 80, 95);

            btnTabAdmin.BackColor = Color.White;
            btnTabAdmin.ForeColor = Color.FromArgb(70, 80, 95);

            pnlSignIn.Visible = false;
            pnlRegister.Visible = false;
            pnlAdmin.Visible = false;

            switch (tabIndex)
            {
                case 0:
                    btnTabSignIn.BackColor = Color.FromArgb(23, 45, 80);
                    btnTabSignIn.ForeColor = Color.White;
                    pnlSignIn.Visible = true;
                    txtLoginEmail.Focus();
                    break;
                case 1:
                    btnTabRegister.BackColor = Color.FromArgb(23, 45, 80);
                    btnTabRegister.ForeColor = Color.White;
                    pnlRegister.Visible = true;
                    txtRegName.Focus();
                    break;
                case 2:
                    btnTabAdmin.BackColor = Color.FromArgb(23, 45, 80);
                    btnTabAdmin.ForeColor = Color.White;
                    pnlAdmin.Visible = true;
                    txtAdminUser.Focus();
                    break;
            }
        }

        private void btnTabSignIn_Click(object sender, EventArgs e) => SelectTab(0);
        private void btnTabRegister_Click(object sender, EventArgs e) => SelectTab(1);
        private void btnTabAdmin_Click(object sender, EventArgs e) => SelectTab(2);

        private void chkShowLoginPass_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !chkShowLoginPass.Checked;
        }

        private void chkShowRegPass_CheckedChanged(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = !chkShowRegPass.Checked;
            txtRegConfirmPassword.UseSystemPasswordChar = !chkShowRegPass.Checked;
        }

        private void chkShowAdminPass_CheckedChanged(object sender, EventArgs e)
        {
            txtAdminPass.UseSystemPasswordChar = !chkShowAdminPass.Checked;
        }

        // --- Customer Login Action ---
        private void btnDoLogin_Click(object sender, EventArgs e)
        {
            string email = txtLoginEmail.Text.Trim();
            string pass = txtLoginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter both your email address and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SessionManager.Authenticate(email, pass, "Customer", out var user, out string err))
            {
                MessageBox.Show(
                    $"Welcome back to GrandStay, {user?.FullName}!\nYou are now signed in.",
                    "Sign In Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(err, "Sign In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Customer Registration Action ---
        private void btnDoRegister_Click(object sender, EventArgs e)
        {
            string name = txtRegName.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            string phone = txtRegPhone.Text.Trim();
            string pass = txtRegPassword.Text.Trim();
            string confirm = txtRegConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(pass) || pass.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegPassword.Focus();
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegConfirmPassword.Focus();
                return;
            }

            if (SessionManager.Register(name, email, phone, pass, out string err))
            {
                MessageBox.Show(
                    $"Account successfully created!\n\nWelcome to GrandStay Hotel & Resorts, {name}.",
                    "Registration Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(err, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Admin Login Action ---
        private void btnDoAdminLogin_Click(object sender, EventArgs e)
        {
            string email = txtAdminUser.Text.Trim();
            string pass = txtAdminPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter Admin credentials.", "Access Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SessionManager.Authenticate(email, pass, "Admin", out var adminUser, out string err))
            {
                MessageBox.Show(
                    $"Admin Authentication Verified.\nWelcome, {adminUser?.FullName}!",
                    "Admin Access Granted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

                // Launch Admin Dashboard immediately
                using var adminDashboard = new AdminDashboardForm();
                adminDashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show(err, "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
