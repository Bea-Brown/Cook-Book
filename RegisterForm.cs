using Microsoft.Data.SqlClient;
using System.Data;

namespace CookBook
{
    public partial class Register : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite";
        public Register()
        {
            InitializeComponent();
            Securitycbx.Items.AddRange(new string[]
{
                "What is your favorite food?",
                "What is your pet’s name?",
                "What city were you born in?",
                "What's your best friend's name growing up?",
                "Which was your favorite subject in school?"
});
            Securitycbx.SelectedIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Register_Registerbtn_Click(object sender, EventArgs e)
        {
            if (Register_Name.Text == "" || Register_Email.Text == "" || Register_Password.Text == "" || Security_Answer.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                try
                {
                    con.Open();
                    String checkemail = "SELECT * FROM users WHERE Email = '"
                        + Register_Email.Text.Trim() + "'";
                    using (SqlCommand checkEmail = new SqlCommand(checkemail, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkEmail);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show(Register_Email.Text + " is already used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (FullName, Email, Passcode, SecurityQuestion, SecurityAnswer) VALUES (@FullName, @Email, @Passcode, @SecurityQuestion, @SecurityAnswer)";
                            using (SqlCommand CMD = new SqlCommand(insertData, con))
                            {
                                CMD.Parameters.AddWithValue("@FullName", Register_Name.Text.Trim());
                                CMD.Parameters.AddWithValue("@Email", Register_Email.Text.Trim());
                                CMD.Parameters.AddWithValue("@Passcode", Register_Password.Text.Trim());
                                CMD.Parameters.AddWithValue("@SecurityQuestion", Securitycbx.SelectedItem.ToString());
                                CMD.Parameters.AddWithValue("@SecurityAnswer", Security_Answer.Text.Trim());
                                CMD.ExecuteNonQuery();

                                MessageBox.Show("Registration Completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                new LoginForm().Show();
                                this.Close();
                            }
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

        private void Register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Register_showpass.Checked)
            {
                Register_Password.PasswordChar = '\0';
            }
            else
            {
                Register_Password.PasswordChar = '*';
            }
        }

        private void Register_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Register_ShowAnswer.Checked)
            {
                Security_Answer.PasswordChar = '\0';
            }
            else
            {
                Security_Answer.PasswordChar = '*';
            }
        }
    }
}
