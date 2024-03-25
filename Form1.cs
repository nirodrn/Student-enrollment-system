namespace SESys
{
    public partial class Form1 : Form
    {

        private int loginAttempts = 3;
        public Form1()
        {
            InitializeComponent();
            tbxpass.PasswordChar = '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbxuser.Text;
            string password = tbxpass.Text;

            // Replace "admin" and "1234" with your actual admin username and password
            if (IsAdmin(username, password))
            {
                home homeForm = new home();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                // Invalid login attempt
                loginAttempts--;
                if (loginAttempts > 0)
                {
                    MessageBox.Show("Invalid username or password. You have " + loginAttempts + " attempts left.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Maximum login attempts reached. Application will now close.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private bool IsAdmin(string username, string password)
        {

            return (username == "admin" && password == "admin");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool showPassword = false;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            tbxpass.PasswordChar = showPassword ? '\0' : '*';
        }

    }
}