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
    public partial class frmFeedNew : Form
    {
        public frmFeedNew()
        {
            InitializeComponent();
        }

        private void btnDelimg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this!");
            //    try
            //    {
            ///       for deleting posts 
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have passed this User!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this comment");
            //    try
            //    {
            ///       for deleting comments 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("DELETE FROM Comment_R WHERE Comment_ID = txtComment1);
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Comment Deleted");
            //        }
            ///if comment is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Commment is corrupt, please try again!");
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
