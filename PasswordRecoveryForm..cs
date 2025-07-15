using Microsoft.Data.SqlClient;

namespace CookBook
{
    public partial class PasswordRecovery : Form
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite";
        string e_mail;

        public PasswordRecovery()
        {
            InitializeComponent();
            NewPass.Enabled = false;
            Pass_Reset.Enabled = false;
            Security_cbx.Items.AddRange(new string[]
{
                "What is your favorite food?",
                "What is your pet’s name?",
                "What city were you born in?",
                "What's your best friend's name growing up?",
                "Which was your favorite subject in school?"
});
            Security_cbx.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pass_ShowAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (Pass_ShowAnswer.Checked)
            {
                Pass_Answer.PasswordChar = '\0';
            }
            else
            {
                Pass_Answer.PasswordChar = '*';
            }
        }

        private void Pass_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Pass_showpass.Checked)
            {
                NewPass.PasswordChar = '\0';
            }
            else
            {
                NewPass.PasswordChar = '*';
            }
        }

        private void verifytxt_Click(object sender, EventArgs e)
        {
            e_mail = pass_email.Text.Trim();
            string selectedQuestion = Security_cbx.Text.Trim();
            string securityAnswer = Pass_Answer.Text.Trim();

            if (pass_email.Text == "" || Pass_Answer.Text == "" || Security_cbx.Text == "")
            {
                MessageBox.Show("Please enter fields required for verification.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string verify = "SELECT SecurityQuestion, SecurityAnswer FROM Users WHERE Email = @email";

                    using (SqlCommand cmd = new SqlCommand(verify, con))
                    {
                        cmd.Parameters.AddWithValue("@email", e_mail);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedQuestion = reader.GetString(0).Trim();
                                string storedAnswer = reader.GetString(1).Trim();

                                if (selectedQuestion.Equals(storedQuestion, StringComparison.OrdinalIgnoreCase) &&
                                securityAnswer.Equals(storedAnswer, StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Verification successful! You can now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    NewPass.Enabled = true;
                                    Pass_Reset.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect security question or answer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    Pass_Answer.Clear();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Pass_Reset_Click(object sender, EventArgs e)
        {
            string newPassword = NewPass.Text.Trim();
            if (newPassword.Length == 0)
            {
                MessageBox.Show("Please enter a new password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            string NewPassCode = newPassword;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string Updates = "UPDATE Users SET PassCode=@password WHERE Email=@email";

                    using (SqlCommand cmd = new SqlCommand(Updates, con))
                    {
                        cmd.Parameters.AddWithValue("@password", NewPassCode);
                        cmd.Parameters.AddWithValue("@email", e_mail);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new LoginForm().Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong. Please try again. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pass_backbtn_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
