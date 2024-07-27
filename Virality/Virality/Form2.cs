using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

namespace Virality
{
    public partial class frmMain : Form
    {
        //[D11Import("Gd32.d11", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn

        //    (
        //    int nleftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
            
        //    );
        
        public frmMain()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnFeed.Height;
            pnlNav.Top = btnFeed.Top;
            pnlNav.Left = btnFeed.Left;
            btnFeed.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Reported Images";
            this.pnlFormLoader.Controls.Clear();
            frmFeedNew frmFeedNew_vrb = new frmFeedNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnFeed.Height;
            pnlNav.Top = btnFeed.Top;
            pnlNav.Left = btnFeed.Left;
            btnFeed.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Image Check";
            this.pnlFormLoader.Controls.Clear();
            frmFeedNew frmFeedNew_vrb = new frmFeedNew() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMessages.Height;
            pnlNav.Top = btnMessages.Top;
            btnMessages.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Reported Messages";
            this.pnlFormLoader.Controls.Clear();
            frmMessages frmFeedNew_vrb = new frmMessages() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHelp.Height;
            pnlNav.Top = btnHelp.Top;
            btnHelp.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "User Help";
            this.pnlFormLoader.Controls.Clear();
            frmHelpteam frmFeedNew_vrb = new frmHelpteam() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "User Reports";
            this.pnlFormLoader.Controls.Clear();
            frmSettings frmFeedNew_vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }

        private void btnFeed_Leave(object sender, EventArgs e)
        {
            btnFeed.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMessages_Leave(object sender, EventArgs e)
        {
            btnMessages.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHelp_Leave(object sender, EventArgs e)
        {
            btnHelp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetting_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Profile";
            this.pnlFormLoader.Controls.Clear();
            frmProfile frmFeedNew_vrb = new frmProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFeedNew_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmFeedNew_vrb);
            frmFeedNew_vrb.Show();
        }
    }
}
