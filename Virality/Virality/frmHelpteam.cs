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
    public partial class frmHelpteam : Form
    {
        public frmHelpteam()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            displaylbl.Text = txtinput.Text;

            //    try
            //    {
            ///       For sending messages.
            //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
            //        SqlCommand cmd = new SqlCommand("insert into Messages (Message_ID");
            //        SqlCommand cmd = new SqlCommand("values ( txtinput.Text");
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();

            //        da.Fill(dt);

            //        if(dt.Rows.Count > 0)
            //        {
            //            MessageBox.Show("Mesaage sent");
            //        }
            ///if message is corrupt it will show an error.
            //        else
            //        {
            //            MessageBox.Show("Message is corrupt!");
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
    }
}
