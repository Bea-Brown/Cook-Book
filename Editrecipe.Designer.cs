
namespace CookBook
{
    partial class Editrecipe
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
            labeltitle = new Label();
            Content = new RichTextBox();
            update = new Button();
            Title = new RichTextBox();
            back = new Button();
            SuspendLayout();
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.BackColor = Color.Transparent;
            labeltitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitle.ForeColor = Color.FromArgb(64, 0, 0);
            labeltitle.Location = new Point(675, 153);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(130, 60);
            labeltitle.TabIndex = 13;
            labeltitle.Text = "Title:";
            // 
            // Content
            // 
            Content.BackColor = Color.AntiqueWhite;
            Content.Font = new Font("Segoe UI", 14F);
            Content.Location = new Point(552, 234);
            Content.Name = "Content";
            Content.Size = new Size(1064, 739);
            Content.TabIndex = 14;
            Content.Text = "";
            Content.TextChanged += Content_TextChanged;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(255, 192, 128);
            update.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(1144, 994);
            update.Name = "update";
            update.Size = new Size(228, 59);
            update.TabIndex = 16;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // Title
            // 
            Title.BackColor = Color.AntiqueWhite;
            Title.Font = new Font("Segoe UI", 16F);
            Title.Location = new Point(852, 153);
            Title.Name = "Title";
            Title.Size = new Size(576, 60);
            Title.TabIndex = 17;
            Title.Text = "";
            Title.TextChanged += Title_TextChanged;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 128);
            back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(774, 994);
            back.Name = "back";
            back.Size = new Size(228, 59);
            back.TabIndex = 18;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click_1;
            // 
            // Editrecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(back);
            Controls.Add(Title);
            Controls.Add(update);
            Controls.Add(Content);
            Controls.Add(labeltitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Editrecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Recipe";
            Load += Editrecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Label labeltitle;
        private RichTextBox Content;
        private Button update;
        private RichTextBox Title;
        private Button back;
    }
}