namespace Hotel_Booking_System
{
    partial class AuthForm
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
            lblHeaderTitle = new Label();
            btnClose = new Button();
            pnlTabs = new Panel();
            btnTabAdmin = new Button();
            btnTabRegister = new Button();
            btnTabSignIn = new Button();
            pnlSignIn = new Panel();
            lblDemoHint = new Label();
            chkShowLoginPass = new CheckBox();
            btnDoLogin = new Button();
            txtLoginPassword = new TextBox();
            lblLoginPassword = new Label();
            txtLoginEmail = new TextBox();
            lblLoginEmail = new Label();
            lblSignInSubtitle = new Label();
            lblSignInTitle = new Label();
            pnlRegister = new Panel();
            chkShowRegPass = new CheckBox();
            btnDoRegister = new Button();
            txtRegConfirmPassword = new TextBox();
            lblRegConfirm = new Label();
            txtRegPassword = new TextBox();
            lblRegPass = new Label();
            txtRegPhone = new TextBox();
            lblRegPhone = new Label();
            txtRegEmail = new TextBox();
            lblRegEmail = new Label();
            txtRegName = new TextBox();
            lblRegName = new Label();
            lblRegSubtitle = new Label();
            lblRegTitle = new Label();
            pnlAdmin = new Panel();
            lblAdminHint = new Label();
            chkShowAdminPass = new CheckBox();
            btnDoAdminLogin = new Button();
            txtAdminPass = new TextBox();
            lblAdminPass = new Label();
            txtAdminUser = new TextBox();
            lblAdminUser = new Label();
            lblAdminSubtitle = new Label();
            lblAdminTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlTabs.SuspendLayout();
            pnlSignIn.SuspendLayout();
            pnlRegister.SuspendLayout();
            pnlAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 45, 80);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(520, 55);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderTitle.ForeColor = Color.White;
            lblHeaderTitle.Location = new Point(20, 14);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(245, 25);
            lblHeaderTitle.TabIndex = 1;
            lblHeaderTitle.Text = "🏨 GrandStay Account Access";
            lblHeaderTitle.MouseDown += pnlHeader_MouseDown;
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
            btnClose.Location = new Point(475, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 38);
            btnClose.TabIndex = 0;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlTabs
            // 
            pnlTabs.BackColor = Color.White;
            pnlTabs.Controls.Add(btnTabAdmin);
            pnlTabs.Controls.Add(btnTabRegister);
            pnlTabs.Controls.Add(btnTabSignIn);
            pnlTabs.Location = new Point(25, 70);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new Size(470, 48);
            pnlTabs.TabIndex = 1;
            // 
            // btnTabAdmin
            // 
            btnTabAdmin.BackColor = Color.White;
            btnTabAdmin.Cursor = Cursors.Hand;
            btnTabAdmin.FlatAppearance.BorderSize = 0;
            btnTabAdmin.FlatStyle = FlatStyle.Flat;
            btnTabAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabAdmin.ForeColor = Color.FromArgb(70, 80, 95);
            btnTabAdmin.Location = new Point(314, 4);
            btnTabAdmin.Name = "btnTabAdmin";
            btnTabAdmin.Size = new Size(152, 40);
            btnTabAdmin.TabIndex = 2;
            btnTabAdmin.Text = "🔒 Admin Access";
            btnTabAdmin.UseVisualStyleBackColor = false;
            btnTabAdmin.Click += btnTabAdmin_Click;
            // 
            // btnTabRegister
            // 
            btnTabRegister.BackColor = Color.White;
            btnTabRegister.Cursor = Cursors.Hand;
            btnTabRegister.FlatAppearance.BorderSize = 0;
            btnTabRegister.FlatStyle = FlatStyle.Flat;
            btnTabRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabRegister.ForeColor = Color.FromArgb(70, 80, 95);
            btnTabRegister.Location = new Point(159, 4);
            btnTabRegister.Name = "btnTabRegister";
            btnTabRegister.Size = new Size(150, 40);
            btnTabRegister.TabIndex = 1;
            btnTabRegister.Text = "Register Account";
            btnTabRegister.UseVisualStyleBackColor = false;
            btnTabRegister.Click += btnTabRegister_Click;
            // 
            // btnTabSignIn
            // 
            btnTabSignIn.BackColor = Color.FromArgb(23, 45, 80);
            btnTabSignIn.Cursor = Cursors.Hand;
            btnTabSignIn.FlatAppearance.BorderSize = 0;
            btnTabSignIn.FlatStyle = FlatStyle.Flat;
            btnTabSignIn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTabSignIn.ForeColor = Color.White;
            btnTabSignIn.Location = new Point(4, 4);
            btnTabSignIn.Name = "btnTabSignIn";
            btnTabSignIn.Size = new Size(150, 40);
            btnTabSignIn.TabIndex = 0;
            btnTabSignIn.Text = "Customer Sign In";
            btnTabSignIn.UseVisualStyleBackColor = false;
            btnTabSignIn.Click += btnTabSignIn_Click;
            // 
            // pnlSignIn
            // 
            pnlSignIn.BackColor = Color.White;
            pnlSignIn.Controls.Add(lblDemoHint);
            pnlSignIn.Controls.Add(chkShowLoginPass);
            pnlSignIn.Controls.Add(btnDoLogin);
            pnlSignIn.Controls.Add(txtLoginPassword);
            pnlSignIn.Controls.Add(lblLoginPassword);
            pnlSignIn.Controls.Add(txtLoginEmail);
            pnlSignIn.Controls.Add(lblLoginEmail);
            pnlSignIn.Controls.Add(lblSignInSubtitle);
            pnlSignIn.Controls.Add(lblSignInTitle);
            pnlSignIn.Location = new Point(25, 130);
            pnlSignIn.Name = "pnlSignIn";
            pnlSignIn.Size = new Size(470, 490);
            pnlSignIn.TabIndex = 2;
            // 
            // lblDemoHint
            // 
            lblDemoHint.BackColor = Color.FromArgb(240, 245, 255);
            lblDemoHint.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDemoHint.ForeColor = Color.FromArgb(40, 70, 120);
            lblDemoHint.Location = new Point(30, 405);
            lblDemoHint.Name = "lblDemoHint";
            lblDemoHint.Padding = new Padding(8);
            lblDemoHint.Size = new Size(410, 55);
            lblDemoHint.TabIndex = 8;
            lblDemoHint.Text = "💡 Demo Customer Login:\nEmail: john@example.com  |  Password: 123456";
            // 
            // chkShowLoginPass
            // 
            chkShowLoginPass.AutoSize = true;
            chkShowLoginPass.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowLoginPass.ForeColor = Color.DimGray;
            chkShowLoginPass.Location = new Point(30, 275);
            chkShowLoginPass.Name = "chkShowLoginPass";
            chkShowLoginPass.Size = new Size(133, 23);
            chkShowLoginPass.TabIndex = 7;
            chkShowLoginPass.Text = "Show Password";
            chkShowLoginPass.UseVisualStyleBackColor = true;
            chkShowLoginPass.CheckedChanged += chkShowLoginPass_CheckedChanged;
            // 
            // btnDoLogin
            // 
            btnDoLogin.BackColor = Color.FromArgb(23, 45, 80);
            btnDoLogin.Cursor = Cursors.Hand;
            btnDoLogin.FlatAppearance.BorderSize = 0;
            btnDoLogin.FlatStyle = FlatStyle.Flat;
            btnDoLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoLogin.ForeColor = Color.White;
            btnDoLogin.Location = new Point(30, 320);
            btnDoLogin.Name = "btnDoLogin";
            btnDoLogin.Size = new Size(410, 48);
            btnDoLogin.TabIndex = 6;
            btnDoLogin.Text = "Sign In to GrandStay";
            btnDoLogin.UseVisualStyleBackColor = false;
            btnDoLogin.Click += btnDoLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPassword.Location = new Point(30, 235);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(410, 31);
            txtLoginPassword.TabIndex = 5;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginPassword.ForeColor = Color.FromArgb(23, 45, 80);
            lblLoginPassword.Location = new Point(30, 205);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(82, 21);
            lblLoginPassword.TabIndex = 4;
            lblLoginPassword.Text = "Password";
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginEmail.Location = new Point(30, 150);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.Size = new Size(410, 31);
            txtLoginEmail.TabIndex = 3;
            // 
            // lblLoginEmail
            // 
            lblLoginEmail.AutoSize = true;
            lblLoginEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginEmail.ForeColor = Color.FromArgb(23, 45, 80);
            lblLoginEmail.Location = new Point(30, 120);
            lblLoginEmail.Name = "lblLoginEmail";
            lblLoginEmail.Size = new Size(118, 21);
            lblLoginEmail.TabIndex = 2;
            lblLoginEmail.Text = "Email Address";
            // 
            // lblSignInSubtitle
            // 
            lblSignInSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignInSubtitle.ForeColor = Color.DimGray;
            lblSignInSubtitle.Location = new Point(30, 65);
            lblSignInSubtitle.Name = "lblSignInSubtitle";
            lblSignInSubtitle.Size = new Size(410, 45);
            lblSignInSubtitle.TabIndex = 1;
            lblSignInSubtitle.Text = "Log in to manage your hotel reservations and access member rates.";
            // 
            // lblSignInTitle
            // 
            lblSignInTitle.AutoSize = true;
            lblSignInTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignInTitle.ForeColor = Color.FromArgb(23, 45, 80);
            lblSignInTitle.Location = new Point(25, 25);
            lblSignInTitle.Name = "lblSignInTitle";
            lblSignInTitle.Size = new Size(191, 35);
            lblSignInTitle.TabIndex = 0;
            lblSignInTitle.Text = "Welcome Back";
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.Controls.Add(chkShowRegPass);
            pnlRegister.Controls.Add(btnDoRegister);
            pnlRegister.Controls.Add(txtRegConfirmPassword);
            pnlRegister.Controls.Add(lblRegConfirm);
            pnlRegister.Controls.Add(txtRegPassword);
            pnlRegister.Controls.Add(lblRegPass);
            pnlRegister.Controls.Add(txtRegPhone);
            pnlRegister.Controls.Add(lblRegPhone);
            pnlRegister.Controls.Add(txtRegEmail);
            pnlRegister.Controls.Add(lblRegEmail);
            pnlRegister.Controls.Add(txtRegName);
            pnlRegister.Controls.Add(lblRegName);
            pnlRegister.Controls.Add(lblRegSubtitle);
            pnlRegister.Controls.Add(lblRegTitle);
            pnlRegister.Location = new Point(25, 130);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(470, 490);
            pnlRegister.TabIndex = 3;
            pnlRegister.Visible = false;
            // 
            // chkShowRegPass
            // 
            chkShowRegPass.AutoSize = true;
            chkShowRegPass.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowRegPass.ForeColor = Color.DimGray;
            chkShowRegPass.Location = new Point(30, 375);
            chkShowRegPass.Name = "chkShowRegPass";
            chkShowRegPass.Size = new Size(133, 23);
            chkShowRegPass.TabIndex = 13;
            chkShowRegPass.Text = "Show Password";
            chkShowRegPass.UseVisualStyleBackColor = true;
            chkShowRegPass.CheckedChanged += chkShowRegPass_CheckedChanged;
            // 
            // btnDoRegister
            // 
            btnDoRegister.BackColor = Color.FromArgb(23, 45, 80);
            btnDoRegister.Cursor = Cursors.Hand;
            btnDoRegister.FlatAppearance.BorderSize = 0;
            btnDoRegister.FlatStyle = FlatStyle.Flat;
            btnDoRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoRegister.ForeColor = Color.White;
            btnDoRegister.Location = new Point(30, 415);
            btnDoRegister.Name = "btnDoRegister";
            btnDoRegister.Size = new Size(410, 48);
            btnDoRegister.TabIndex = 12;
            btnDoRegister.Text = "Create My Account";
            btnDoRegister.UseVisualStyleBackColor = false;
            btnDoRegister.Click += btnDoRegister_Click;
            // 
            // txtRegConfirmPassword
            // 
            txtRegConfirmPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegConfirmPassword.Location = new Point(245, 330);
            txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            txtRegConfirmPassword.Size = new Size(195, 29);
            txtRegConfirmPassword.TabIndex = 11;
            txtRegConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblRegConfirm
            // 
            lblRegConfirm.AutoSize = true;
            lblRegConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegConfirm.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegConfirm.Location = new Point(245, 305);
            lblRegConfirm.Name = "lblRegConfirm";
            lblRegConfirm.Size = new Size(137, 20);
            lblRegConfirm.TabIndex = 10;
            lblRegConfirm.Text = "Confirm Password";
            // 
            // txtRegPassword
            // 
            txtRegPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegPassword.Location = new Point(30, 330);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(195, 29);
            txtRegPassword.TabIndex = 9;
            txtRegPassword.UseSystemPasswordChar = true;
            // 
            // lblRegPass
            // 
            lblRegPass.AutoSize = true;
            lblRegPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegPass.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegPass.Location = new Point(30, 305);
            lblRegPass.Name = "lblRegPass";
            lblRegPass.Size = new Size(76, 20);
            lblRegPass.TabIndex = 8;
            lblRegPass.Text = "Password";
            // 
            // txtRegPhone
            // 
            txtRegPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegPhone.Location = new Point(30, 255);
            txtRegPhone.Name = "txtRegPhone";
            txtRegPhone.Size = new Size(410, 29);
            txtRegPhone.TabIndex = 7;
            // 
            // lblRegPhone
            // 
            lblRegPhone.AutoSize = true;
            lblRegPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegPhone.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegPhone.Location = new Point(30, 230);
            lblRegPhone.Name = "lblRegPhone";
            lblRegPhone.Size = new Size(115, 20);
            lblRegPhone.TabIndex = 6;
            lblRegPhone.Text = "Phone Number";
            // 
            // txtRegEmail
            // 
            txtRegEmail.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegEmail.Location = new Point(30, 185);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(410, 29);
            txtRegEmail.TabIndex = 5;
            // 
            // lblRegEmail
            // 
            lblRegEmail.AutoSize = true;
            lblRegEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegEmail.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegEmail.Location = new Point(30, 160);
            lblRegEmail.Name = "lblRegEmail";
            lblRegEmail.Size = new Size(107, 20);
            lblRegEmail.TabIndex = 4;
            lblRegEmail.Text = "Email Address";
            // 
            // txtRegName
            // 
            txtRegName.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegName.Location = new Point(30, 115);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(410, 29);
            txtRegName.TabIndex = 3;
            // 
            // lblRegName
            // 
            lblRegName.AutoSize = true;
            lblRegName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegName.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegName.Location = new Point(30, 90);
            lblRegName.Name = "lblRegName";
            lblRegName.Size = new Size(80, 20);
            lblRegName.TabIndex = 2;
            lblRegName.Text = "Full Name";
            // 
            // lblRegSubtitle
            // 
            lblRegSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegSubtitle.ForeColor = Color.DimGray;
            lblRegSubtitle.Location = new Point(30, 55);
            lblRegSubtitle.Name = "lblRegSubtitle";
            lblRegSubtitle.Size = new Size(410, 30);
            lblRegSubtitle.TabIndex = 1;
            lblRegSubtitle.Text = "Create an account for quick bookings and invoices.";
            // 
            // lblRegTitle
            // 
            lblRegTitle.AutoSize = true;
            lblRegTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegTitle.ForeColor = Color.FromArgb(23, 45, 80);
            lblRegTitle.Location = new Point(25, 20);
            lblRegTitle.Name = "lblRegTitle";
            lblRegTitle.Size = new Size(207, 32);
            lblRegTitle.TabIndex = 0;
            lblRegTitle.Text = "Create an Account";
            // 
            // pnlAdmin
            // 
            pnlAdmin.BackColor = Color.White;
            pnlAdmin.Controls.Add(lblAdminHint);
            pnlAdmin.Controls.Add(chkShowAdminPass);
            pnlAdmin.Controls.Add(btnDoAdminLogin);
            pnlAdmin.Controls.Add(txtAdminPass);
            pnlAdmin.Controls.Add(lblAdminPass);
            pnlAdmin.Controls.Add(txtAdminUser);
            pnlAdmin.Controls.Add(lblAdminUser);
            pnlAdmin.Controls.Add(lblAdminSubtitle);
            pnlAdmin.Controls.Add(lblAdminTitle);
            pnlAdmin.Location = new Point(25, 130);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(470, 490);
            pnlAdmin.TabIndex = 4;
            pnlAdmin.Visible = false;
            // 
            // lblAdminHint
            // 
            lblAdminHint.BackColor = Color.FromArgb(254, 249, 231);
            lblAdminHint.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminHint.ForeColor = Color.FromArgb(125, 102, 8);
            lblAdminHint.Location = new Point(30, 405);
            lblAdminHint.Name = "lblAdminHint";
            lblAdminHint.Padding = new Padding(8);
            lblAdminHint.Size = new Size(410, 55);
            lblAdminHint.TabIndex = 8;
            lblAdminHint.Text = "🔑 Master Admin Credentials:\nAdmin Email: admin@grandstay.com  |  Key: admin123";
            // 
            // chkShowAdminPass
            // 
            chkShowAdminPass.AutoSize = true;
            chkShowAdminPass.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowAdminPass.ForeColor = Color.DimGray;
            chkShowAdminPass.Location = new Point(30, 275);
            chkShowAdminPass.Name = "chkShowAdminPass";
            chkShowAdminPass.Size = new Size(157, 23);
            chkShowAdminPass.TabIndex = 7;
            chkShowAdminPass.Text = "Show Security Key";
            chkShowAdminPass.UseVisualStyleBackColor = true;
            chkShowAdminPass.CheckedChanged += chkShowAdminPass_CheckedChanged;
            // 
            // btnDoAdminLogin
            // 
            btnDoAdminLogin.BackColor = Color.FromArgb(23, 45, 80);
            btnDoAdminLogin.Cursor = Cursors.Hand;
            btnDoAdminLogin.FlatAppearance.BorderSize = 0;
            btnDoAdminLogin.FlatStyle = FlatStyle.Flat;
            btnDoAdminLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoAdminLogin.ForeColor = Color.White;
            btnDoAdminLogin.Location = new Point(30, 320);
            btnDoAdminLogin.Name = "btnDoAdminLogin";
            btnDoAdminLogin.Size = new Size(410, 48);
            btnDoAdminLogin.TabIndex = 6;
            btnDoAdminLogin.Text = "Authorize & Enter Dashboard";
            btnDoAdminLogin.UseVisualStyleBackColor = false;
            btnDoAdminLogin.Click += btnDoAdminLogin_Click;
            // 
            // txtAdminPass
            // 
            txtAdminPass.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminPass.Location = new Point(30, 235);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.Size = new Size(410, 31);
            txtAdminPass.TabIndex = 5;
            txtAdminPass.UseSystemPasswordChar = true;
            // 
            // lblAdminPass
            // 
            lblAdminPass.AutoSize = true;
            lblAdminPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminPass.ForeColor = Color.FromArgb(23, 45, 80);
            lblAdminPass.Location = new Point(30, 205);
            lblAdminPass.Name = "lblAdminPass";
            lblAdminPass.Size = new Size(160, 21);
            lblAdminPass.TabIndex = 4;
            lblAdminPass.Text = "Admin Security Key";
            // 
            // txtAdminUser
            // 
            txtAdminUser.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdminUser.Location = new Point(30, 150);
            txtAdminUser.Name = "txtAdminUser";
            txtAdminUser.Size = new Size(410, 31);
            txtAdminUser.TabIndex = 3;
            // 
            // lblAdminUser
            // 
            lblAdminUser.AutoSize = true;
            lblAdminUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminUser.ForeColor = Color.FromArgb(23, 45, 80);
            lblAdminUser.Location = new Point(30, 120);
            lblAdminUser.Name = "lblAdminUser";
            lblAdminUser.Size = new Size(157, 21);
            lblAdminUser.TabIndex = 2;
            lblAdminUser.Text = "Admin ID or Email";
            // 
            // lblAdminSubtitle
            // 
            lblAdminSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdminSubtitle.ForeColor = Color.FromArgb(192, 57, 43);
            lblAdminSubtitle.Location = new Point(30, 65);
            lblAdminSubtitle.Name = "lblAdminSubtitle";
            lblAdminSubtitle.Size = new Size(410, 45);
            lblAdminSubtitle.TabIndex = 1;
            lblAdminSubtitle.Text = "Restricted management portal for hotel staff, inventory, and reservation control.";
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.ForeColor = Color.FromArgb(23, 45, 80);
            lblAdminTitle.Location = new Point(25, 25);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(295, 35);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "🔒 Administration Portal";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(520, 645);
            Controls.Add(pnlSignIn);
            Controls.Add(pnlRegister);
            Controls.Add(pnlAdmin);
            Controls.Add(pnlTabs);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GrandStay Authentication";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlTabs.ResumeLayout(false);
            pnlSignIn.ResumeLayout(false);
            pnlSignIn.PerformLayout();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Button btnClose;
        private Panel pnlTabs;
        private Button btnTabSignIn;
        private Button btnTabRegister;
        private Button btnTabAdmin;
        private Panel pnlSignIn;
        private Label lblSignInTitle;
        private Label lblSignInSubtitle;
        private Label lblLoginEmail;
        private TextBox txtLoginEmail;
        private Label lblLoginPassword;
        private TextBox txtLoginPassword;
        private Button btnDoLogin;
        private CheckBox chkShowLoginPass;
        private Label lblDemoHint;
        private Panel pnlRegister;
        private Label lblRegTitle;
        private Label lblRegSubtitle;
        private Label lblRegName;
        private TextBox txtRegName;
        private Label lblRegEmail;
        private TextBox txtRegEmail;
        private Label lblRegPhone;
        private TextBox txtRegPhone;
        private Label lblRegPass;
        private TextBox txtRegPassword;
        private Label lblRegConfirm;
        private TextBox txtRegConfirmPassword;
        private Button btnDoRegister;
        private CheckBox chkShowRegPass;
        private Panel pnlAdmin;
        private Label lblAdminTitle;
        private Label lblAdminSubtitle;
        private Label lblAdminUser;
        private TextBox txtAdminUser;
        private Label lblAdminPass;
        private TextBox txtAdminPass;
        private Button btnDoAdminLogin;
        private CheckBox chkShowAdminPass;
        private Label lblAdminHint;
    }
}
