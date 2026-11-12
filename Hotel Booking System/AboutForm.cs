using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Hotel_Booking_System
{
    public partial class AboutForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public AboutForm()
        {
            InitializeComponent();
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

        private void btnExploreRooms_Click(object sender, EventArgs e)
        {
            this.Close();
            using var roomsForm = new RoomsForm();
            roomsForm.ShowDialog();
        }

        private void ApplyRoundedCorners(Panel panel, int radius)
        {
            using GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void pnlCard1_Paint(object sender, PaintEventArgs e) => ApplyRoundedCorners(pnlCard1, 15);
        private void pnlCard2_Paint(object sender, PaintEventArgs e) => ApplyRoundedCorners(pnlCard2, 15);
        private void pnlCard3_Paint(object sender, PaintEventArgs e) => ApplyRoundedCorners(pnlCard3, 15);
    }
}
