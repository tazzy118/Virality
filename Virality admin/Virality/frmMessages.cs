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
    public partial class frmMessages : Form
    {
        public frmMessages()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            output1lbl.Text = txtinput1.Text;

            //    try
            //    {
            ///       for added private messages. 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Messages (Messages_ID");
            //        SqlCommand cmd = new SqlCommand("values ( txtinput1");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Message Uploaded");
            //        }
            ///if message is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Message is corrupt! Please try again.");
            //        }

            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure, you want to report that message?");
            //    try
            //    {
            ///       For added reports 
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Messages_R (Messages_ID");
            //        SqlCommand cmd = new SqlCommand("values ( txtinput1");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Message report has been uploaded");
            //        }
            ///if message report is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Message report is corrupt! Please try again.");
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
