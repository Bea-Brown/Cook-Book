using Microsoft.Data.SqlClient;

namespace CookBook
{
    public partial class Recipepage : Form
    {
        public event Action? RecipeDeleted;
        public event Action? RecipeUpdated;
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CookBook;Trusted_Connection=True;";
        private int recipeId;

        public Recipepage(int recipeId)
        {
            InitializeComponent();
            this.recipeId = recipeId;
            LoadRecipesDetails();

        }

        private void LoadRecipesDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string Details = "SELECT * FROM Recipes WHERE RecipeId = @RecipeId";
                    using (SqlCommand cmd = new SqlCommand(Details, con))
                    {
                        cmd.Parameters.Add("@RecipeId", System.Data.SqlDbType.Int).Value = recipeId;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                labeltitle.Text = reader["Title"].ToString();
                                tbxdetails.Text = reader["Content"].ToString();



                            }

                            else
                            {
                                MessageBox.Show("Recipe not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Recipe Details " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void RecipeDelete()
        {
            var confirm = MessageBox.Show("Recipes are deleted permanently. Would you like to delete the recipe?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string Delete = "DELETE FROM Recipes WHERE RecipeId =  @RecipeId";
                        using (SqlCommand cmd = new SqlCommand(Delete, con))
                        {
                            cmd.Parameters.AddWithValue("@RecipeId", recipeId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Recipe deleted succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecipeDeleted?.Invoke();
                    new Myrecipes().Show();
                    this.Close();


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting recipe." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            RecipeDelete();
        }


        private void back_Click(object sender, EventArgs e)
        {

            new Myrecipes().Show();
            this.Close();
        }

        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {
            Editrecipe editrecipe = new Editrecipe(recipeId);
            editrecipe.RecipeUpdated += LoadRecipesDetails;
            editrecipe.ShowDialog();
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxdetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
