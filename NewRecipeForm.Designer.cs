namespace CookBook
{
    partial class Newrecipe
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
            Rec_Title = new RichTextBox();
            NewRec_Content = new RichTextBox();
            labeltitle = new Label();
            submit = new Button();
            back = new Button();
            SuspendLayout();
            // 
            // Rec_Title
            // 
            Rec_Title.BackColor = Color.AntiqueWhite;
            Rec_Title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rec_Title.Location = new Point(852, 153);
            Rec_Title.Name = "Rec_Title";
            Rec_Title.Size = new Size(576, 60);
            Rec_Title.TabIndex = 9;
            Rec_Title.Text = "";
            // 
            // NewRec_Content
            // 
            NewRec_Content.BackColor = Color.AntiqueWhite;
            NewRec_Content.Font = new Font("Segoe UI", 14F);
            NewRec_Content.Location = new Point(552, 234);
            NewRec_Content.Name = "NewRec_Content";
            NewRec_Content.Size = new Size(1064, 739);
            NewRec_Content.TabIndex = 10;
            NewRec_Content.Text = "";
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.BackColor = Color.Transparent;
            labeltitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitle.ForeColor = Color.FromArgb(64, 0, 0);
            labeltitle.Location = new Point(716, 153);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(130, 60);
            labeltitle.TabIndex = 12;
            labeltitle.Text = "Title:";
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(255, 192, 128);
            submit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit.Location = new Point(1144, 994);
            submit.Name = "submit";
            submit.Size = new Size(228, 59);
            submit.TabIndex = 13;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(255, 192, 128);
            back.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.Location = new Point(791, 994);
            back.Name = "back";
            back.Size = new Size(228, 59);
            back.TabIndex = 14;
            back.Text = "Back";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // Newrecipe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(back);
            Controls.Add(submit);
            Controls.Add(labeltitle);
            Controls.Add(NewRec_Content);
            Controls.Add(Rec_Title);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Newrecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Recipe";
            Load += Newrecipe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Rec_Title;
        private RichTextBox NewRec_Content;
        private Label labeltitle;
        private Button submit;
        private Button back;
    }
}