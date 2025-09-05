namespace Test6
{
    public partial class Form1 : Form
    {
        string name, password;

        public Form1()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            name = name_tb.Text;
            password = password_tb.Text;

            if (name == "admin" && password == "admin123")
            {
                // Pass the name to Form2 constructor
                Form2 form2 = new Form2(name);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
