namespace Virality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                new frmMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username/Password is incorrect please try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

            }
        }
        ///Admin enetrs their details
        //if(txtUsername.Text=="")
        //{
        //    MessageBox.Show("Enter the username");
        //}
        //else if (txtPassword.Text=="")
        //{
        //    MessageBox.Show("Enter the password");
        //}
        ///the system will then serach for the username and password of the admin, to check if inputted correctly.
        //else
        //{
        //    try
        //    {
        //        SqlConnection con = new SqlConnection("C:\Users\tasni\OneDrive\Documents\SQL Work\virality.db");
        //        SqlCommand cmd = new SqlCommand("select  * from Admin where Ausername = @Ausername and Apasswords = @Apasswords", con);
        //        cmd.Parameters.AddWitValue("@Ausername", txtUsername.Text);
        //        cmd.Parameters.AddWitValue("@Apasswords", txtPassword.Text);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();

        //        da.Fill(dt);

        //        if(dt.Rows.Count > 0)
        //        {
        //            MessageBox.Show("Login Successful");
        //        }
        ///if user eneters the details wrong an rror mesage pops up.
        //        else
        //        {
        //            MessageBox.Show("Username or Password is incorrect!");
        //        }

        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("" + ex);
        //    }
        //}
        private void clearlbl_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotp_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please type your email so we can send you an OTP to create a new password");
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            new frmSignup().Show();
            this.Hide();
        }
    }
}