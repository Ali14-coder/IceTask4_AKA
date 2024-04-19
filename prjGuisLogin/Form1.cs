namespace prjGuisLogin
{
    public partial class Form1 : Form
    {
        List<User> userList = new List<User>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            gbWelcome.Visible = false;
            gbLogin.Visible = true;
            gbRegister.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbLogin.Location = new Point(0, 0);
            gbRegister.Location = new Point(0, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDB userDB = new UserDB();

            userList = userDB.GetUser(txtNameLogin.Text);


            User Login = new User();
            Login.Name = txtNameLogin.Text;
            Login.Password = txtPassLogin.Text;
            UserDB user = new UserDB();
            bool bOutput = user.CheckUser(Login);
            if (bOutput)
            {
                MessageBox.Show("Weclome to R.D.G.U.N.D.O ");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Does not Exist ");
                txtNameLogin.Focus();
            }
        }

        private void btnResigter_Click(object sender, EventArgs e)
        {

            gbWelcome.Visible = false;
            gbLogin.Visible = false;
            gbRegister.Visible = true;

        }

        private void btnRegUser_Click(object sender, EventArgs e) // trying to get the signup button to work and store infomation in the array
        {
            UserDB Login = new User();
            string Name = txtNameReg.Text;
            string Password = txtPassRegister.Text;

            Login.AddUser(new User(Name, Password));

            gbWelcome.Visible = false;
            gbLogin.Visible = true;
            gbRegister.Visible = false;




        }
    }
}
