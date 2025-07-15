using Microsoft.Data.SqlClient;

namespace CookBook
{
    public partial class Editrecipe : Form
    {
        public event Action? RecipeUpdated;
        string connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=CookBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite";
        private int recipeId;

        public Editrecipe(int id)
        {
            InitializeComponent();
            recipeId = id;
            LoadRecipesEdit();

        }



        private void LoadRecipesEdit()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string Details = "SELECT * FROM Recipes WHERE RecipeId = @RecipeId";
                    using (SqlCommand cmd = new SqlCommand(Details, con))
                    {

                        cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Title.Text = reader["Title"].ToString();
                            Content.Text = reader["Content"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Recipe not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Recipe." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Editrecipe_Load(object sender, EventArgs e)
        {

        }
        private void back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        { }
        private void RecipeUpdate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string Update = "UPDATE Recipes SET Title = @Title, Content = @Content WHERE RecipeId = @RecipeId";
                    using (SqlCommand cmd = new SqlCommand(Update, con))
                    {
                        cmd.Parameters.Add("@Title", System.Data.SqlDbType.NVarChar, 4000).Value = Title.Text;
                        cmd.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar, 4000).Value = Content.Text;
                        cmd.Parameters.Add("@RecipeId", System.Data.SqlDbType.Int).Value = recipeId;


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recipe updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecipeUpdated?.Invoke();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Recipe Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            RecipeUpdate();
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
