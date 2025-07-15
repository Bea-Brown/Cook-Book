using Microsoft.Data.SqlClient;

namespace CookBook
{
    public partial class Newrecipe : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite";
        public Newrecipe()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Myrecipes Myrecform = new Myrecipes();
            Myrecform.Show();
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Rec_Title.Text == "" || NewRec_Content.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                try
                {

                    con.Open();

                    string insertRecipe = "INSERT INTO recipes (Title, Content) VALUES (@Title, @Content)";
                    using (SqlCommand CMD = new SqlCommand(insertRecipe, con))
                    {
                        CMD.Parameters.AddWithValue("@Title", Rec_Title.Text.Trim());
                        CMD.Parameters.AddWithValue("@Content", NewRec_Content.Text.Trim());
                        CMD.ExecuteNonQuery();

                        MessageBox.Show("Recipe submitted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Myrecipes Myrecform = new Myrecipes();
                        Myrecform.Show();
                        this.Close();
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

        private void Newrecipe_Load(object sender, EventArgs e)
        {

        }
    }
}
