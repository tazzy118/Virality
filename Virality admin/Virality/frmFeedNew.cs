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

        private void button1_Click(object sender, EventArgs e)
        {
            commentlbl.Text = txtCom.Text;

            //    try
            //    {
            ///       for added comments
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Comments (Comment_Id");
            //        SqlCommand cmd = new SqlCommand("values ( txtCom.Text");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Comment Uploaded");
            //        }
            ///if comment is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Comment error, please try again.");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}

        }

        private void commentlbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have reported this image.");
            //    try
            //    {
            ///       for reported images
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Img_Check (Post_Id");
            //        SqlCommand cmd = new SqlCommand("values (img1");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Post is reported");
            //        }
            ///if reported img file is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Post is corrupt! Please try again.");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
