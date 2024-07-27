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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this account!");
            //    try
            //    {
            //        For deleting user
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("DELETE FROM User WHERE Username = user_namelbl");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Account Deleted");
            //        }
            ///if user file is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("User is corrupt!");
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show("" + ex);
            //    }
            //}
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
