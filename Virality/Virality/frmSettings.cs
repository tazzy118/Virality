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

        private void btnDeleteposts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have deleted the user");
            //    try
            //    {
            //        For deleting account
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

        private void btnPasspf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Passed check");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have warned the user");
        }
    }
}
