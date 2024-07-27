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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void user_namelbl_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteposts_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to delete your posts?");
            //    try
            //    {
            ///       For deleting posts 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("DELETE FROM Posts WHERE Post_id = img1");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Post Deleted");
            //        }
            ///if img file is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Image file is corrupt! Please try again");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}
        }

        private void btnAddp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to add posts?");
            //    try
            //    {
            ///       For adding posts 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Posts (Post_Id,Full_name");
            //        SqlCommand cmd = new SqlCommand("values ( + img1 +, yolo");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Post Uploaded");
            //        }
            ///if img file is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Image file is corrupt!");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}

        }

        private void btnEditpf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to edit your profile?");
            //    try
            //    {
            ///       For editing profile
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into User (username");
            //        SqlCommand cmd = new SqlCommand("values ( + text.name +");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Profile Updated");
            //        }
            ///if username is corrupt/blank it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Username is corrupt!");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}
        }
    }
}
