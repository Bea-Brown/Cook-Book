

namespace CookBook
{
    partial class Recipepage
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
            back = new Button();
            Delete = new Button();
            edit = new Button();
            labeltitle = new Label();
            tbxdetails = new RichTextBox();
            SuspendLayout();
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 128);
            back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(12, 488);
            back.Name = "back";
            back.Size = new Size(228, 59);
            back.TabIndex = 3;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(255, 192, 128);
            Delete.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(1843, 488);
            Delete.Name = "Delete";
            Delete.Size = new Size(228, 59);
            Delete.TabIndex = 4;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // edit
            // 
            edit.BackColor = Color.FromArgb(255, 192, 128);
            edit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            edit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit.Location = new Point(1843, 599);
            edit.Name = "edit";
            edit.Size = new Size(228, 59);
            edit.TabIndex = 5;
            edit.Text = "Edit";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // labeltitle
            // 
            labeltitle.BackColor = Color.Transparent;
            labeltitle.Font = new Font("Freestyle Script", 72F, FontStyle.Bold);
            labeltitle.ForeColor = Color.FromArgb(64, 0, 0);
            labeltitle.Location = new Point(519, 38);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(1087, 164);
            labeltitle.TabIndex = 7;
            labeltitle.TextAlign = ContentAlignment.TopCenter;
            labeltitle.Click += labeltitle_Click;
            // 
            // tbxdetails
            // 
            tbxdetails.BackColor = Color.AntiqueWhite;
            tbxdetails.Font = new Font("Segoe UI", 14F);
            tbxdetails.Location = new Point(290, 215);
            tbxdetails.Name = "tbxdetails";
            tbxdetails.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            tbxdetails.Size = new Size(1525, 865);
            tbxdetails.TabIndex = 11;
            tbxdetails.Text = "";
            tbxdetails.TextChanged += tbxdetails_TextChanged;
            // 
            // Recipepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(tbxdetails);
            Controls.Add(labeltitle);
            Controls.Add(edit);
            Controls.Add(Delete);
            Controls.Add(back);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Recipepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe";
            Load += Form6_Load;
            ResumeLayout(false);
        }




        #endregion
        private Button back;
        private Button Delete;
        private Button edit;
        private Label labeltitle;
        private RichTextBox tbxdetails;
    }
}