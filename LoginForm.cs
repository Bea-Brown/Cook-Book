using Microsoft.Data.SqlClient;
using System.Data;

namespace CookBook
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Login_Email.Text == "" && Login_Password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {

                    con.Open();
                    String selectemail = " SELECT  *  FROM users WHERE  Email=@email AND PassCode=@passcode";
                    using (SqlCommand cmd = new SqlCommand(selectemail, con))
                    {
                        cmd.Parameters.AddWithValue("@email", Login_Email.Text);
                        cmd.Parameters.AddWithValue("@passcode", Login_Password.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);


                        if (table.Rows.Count >= 1)
                        {


                            Myrecipes MyRecform = new Myrecipes();
                            MyRecform.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show(" The email or password you entered is incorrect, try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Login_Email.Clear();
                            Login_Password.Clear();
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Please, try again." + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PasswordRecovery().Show();
            this.Hide();
        }

        private void Login_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Login_Showpass.Checked)
            {
                Login_Password.PasswordChar = '\0';
            }
            else
            {
                Login_Password.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
