using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virality
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnSendtoHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Delete your account?");
            //    try
            //    {
            ///       For deleting profile 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE Full_name = + txtUsername + ");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("User Deleted");
            //        }
            ///if Profile is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Profile is corrupt! Please try again");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}
        }

        private void cbPrivate_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your account is Private");
        }

        private void cbPublic_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your account is Public");
        }
    }
}
