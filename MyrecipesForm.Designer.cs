namespace CookBook
{
    partial class Myrecipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myrecipes));
            label1 = new Label();
            Back = new Button();
            View = new Button();
            NewRecipe = new Button();
            Recipelist = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Freestyle Script", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(629, 170);
            label1.TabIndex = 0;
            label1.Text = "Chef's Recipes";
            // 
            // Back
            // 
            Back.BackColor = Color.FromArgb(255, 192, 128);
            Back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(12, 501);
            Back.Name = "Back";
            Back.Size = new Size(228, 59);
            Back.TabIndex = 2;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // View
            // 
            View.BackColor = Color.Transparent;
            View.BackgroundImage = (Image)resources.GetObject("View.BackgroundImage");
            View.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            View.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            View.Location = new Point(1137, 910);
            View.Name = "View";
            View.Size = new Size(256, 75);
            View.TabIndex = 8;
            View.Text = "View";
            View.UseVisualStyleBackColor = false;
            View.Click += View_Click;
            // 
            // NewRecipe
            // 
            NewRecipe.BackColor = Color.Transparent;
            NewRecipe.BackgroundImage = (Image)resources.GetObject("NewRecipe.BackgroundImage");
            NewRecipe.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            NewRecipe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewRecipe.Location = new Point(699, 910);
            NewRecipe.Name = "NewRecipe";
            NewRecipe.Size = new Size(256, 75);
            NewRecipe.TabIndex = 9;
            NewRecipe.Text = "New Recipe";
            NewRecipe.UseVisualStyleBackColor = false;
            NewRecipe.Click += NewRecipe_Click;
            // 
            // Recipelist
            // 
            Recipelist.BackColor = Color.Tan;
            Recipelist.DataSource = Recipelist.CustomTabOffsets;
            Recipelist.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            Recipelist.FormattingEnabled = true;
            Recipelist.ItemHeight = 48;
            Recipelist.Location = new Point(279, 201);
            Recipelist.Name = "Recipelist";
            Recipelist.Size = new Size(1525, 628);
            Recipelist.TabIndex = 10;
            Recipelist.SelectedIndexChanged += Recipelist_SelectedIndexChanged;
            // 
            // Myrecipes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.board;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(Recipelist);
            Controls.Add(NewRecipe);
            Controls.Add(View);
            Controls.Add(Back);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Myrecipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chef's Recipes";
            Load += Myrecipes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Back;
        private Button View;
        private Button NewRecipe;
        private ListBox Recipelist;
    }
}