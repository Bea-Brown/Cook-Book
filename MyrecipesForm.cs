using Microsoft.Data.SqlClient;
using System.Data;

namespace CookBook
{
    public partial class Myrecipes : Form
    {

        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CookBook;Trusted_Connection=True;";

        public Myrecipes()
        {
            InitializeComponent();
            LoadRecipes();

        }



        public void LoadRecipes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string RecShow = "SELECT RecipeId, Title FROM Recipes";
                    SqlDataAdapter adapter = new SqlDataAdapter(RecShow, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    Recipelist.DataSource = table;
                    Recipelist.DisplayMember = "Title";
                    Recipelist.ValueMember = "RecipeId";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loadind Recipes" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshRecipelist()
        {
            LoadRecipes();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewRecipe_Click(object sender, EventArgs e)
        {
            new Newrecipe().Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LoginForm Lform = new LoginForm();
            Lform.Show();
            this.Close();
        }

        private void Recipelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            try
            {
                if (Recipelist.SelectedValue != null)
                {
                    if (int.TryParse(Recipelist.SelectedValue.ToString(), out int selectedRecipeId))
                    {

                        Recipepage recipeDetailForm = new Recipepage(selectedRecipeId);
                        recipeDetailForm.RecipeDeleted += LoadRecipes;

                        recipeDetailForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Recipe Id Format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select a recipe to view.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void Myrecipes_Load(object sender, EventArgs e)
        {

        }
    }
}




