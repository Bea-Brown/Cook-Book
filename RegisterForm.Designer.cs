namespace CookBook
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            Register_Registerbtn = new Button();
            Register_Cancelbtn = new Button();
            labelemail = new Label();
            labelname = new Label();
            labelpass = new Label();
            Register_showpass = new CheckBox();
            Register_Name = new TextBox();
            Register_Email = new TextBox();
            Register_Password = new TextBox();
            label1 = new Label();
            Securitycbx = new ComboBox();
            label2 = new Label();
            Security_Answer = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Register_ShowAnswer = new CheckBox();
            SuspendLayout();
            // 
            // Register_Registerbtn
            // 
            Register_Registerbtn.BackColor = Color.FromArgb(255, 192, 128);
            Register_Registerbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register_Registerbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_Registerbtn.Location = new Point(938, 803);
            Register_Registerbtn.Name = "Register_Registerbtn";
            Register_Registerbtn.Size = new Size(228, 59);
            Register_Registerbtn.TabIndex = 1;
            Register_Registerbtn.Text = "Register";
            Register_Registerbtn.UseVisualStyleBackColor = false;
            Register_Registerbtn.Click += Register_Registerbtn_Click;
            // 
            // Register_Cancelbtn
            // 
            Register_Cancelbtn.BackColor = Color.FromArgb(255, 192, 128);
            Register_Cancelbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Register_Cancelbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register_Cancelbtn.Location = new Point(938, 900);
            Register_Cancelbtn.Name = "Register_Cancelbtn";
            Register_Cancelbtn.Size = new Size(228, 59);
            Register_Cancelbtn.TabIndex = 2;
            Register_Cancelbtn.Text = "Cancel";
            Register_Cancelbtn.UseVisualStyleBackColor = false;
            Register_Cancelbtn.Click += Cancel_Click;
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.BackColor = Color.Bisque;
            labelemail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelemail.ForeColor = SystemColors.ActiveCaptionText;
            labelemail.Location = new Point(794, 388);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(121, 48);
            labelemail.TabIndex = 12;
            labelemail.Text = "Email:";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.BackColor = Color.Bisque;
            labelname.FlatStyle = FlatStyle.Flat;
            labelname.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelname.ForeColor = SystemColors.ActiveCaptionText;
            labelname.Location = new Point(786, 298);
            labelname.Name = "labelname";
            labelname.Size = new Size(129, 48);
            labelname.TabIndex = 13;
            labelname.Text = "Name:";
            labelname.Click += label1_Click;
            // 
            // labelpass
            // 
            labelpass.AutoSize = true;
            labelpass.BackColor = Color.Bisque;
            labelpass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelpass.ForeColor = SystemColors.ActiveCaptionText;
            labelpass.Location = new Point(726, 476);
            labelpass.Name = "labelpass";
            labelpass.Size = new Size(189, 48);
            labelpass.TabIndex = 14;
            labelpass.Text = "Password:";
            // 
            // Register_showpass
            // 
            Register_showpass.AutoSize = true;
            Register_showpass.BackColor = Color.Transparent;
            Register_showpass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Register_showpass.ForeColor = SystemColors.ActiveCaptionText;
            Register_showpass.Location = new Point(921, 530);
            Register_showpass.Name = "Register_showpass";
            Register_showpass.Size = new Size(169, 29);
            Register_showpass.TabIndex = 16;
            Register_showpass.Text = "Show Password";
            Register_showpass.UseVisualStyleBackColor = false;
            Register_showpass.CheckedChanged += Register_showpass_CheckedChanged;
            // 
            // Register_Name
            // 
            Register_Name.Font = new Font("Segoe UI", 12F);
            Register_Name.Location = new Point(921, 296);
            Register_Name.Multiline = true;
            Register_Name.Name = "Register_Name";
            Register_Name.Size = new Size(352, 50);
            Register_Name.TabIndex = 17;
            Register_Name.TabStop = false;
            // 
            // Register_Email
            // 
            Register_Email.Font = new Font("Segoe UI", 12F);
            Register_Email.Location = new Point(921, 386);
            Register_Email.Multiline = true;
            Register_Email.Name = "Register_Email";
            Register_Email.Size = new Size(352, 50);
            Register_Email.TabIndex = 18;
            Register_Email.TabStop = false;
            Register_Email.TextChanged += Register_Email_TextChanged;
            // 
            // Register_Password
            // 
            Register_Password.Font = new Font("Segoe UI", 12F);
            Register_Password.Location = new Point(921, 474);
            Register_Password.Multiline = true;
            Register_Password.Name = "Register_Password";
            Register_Password.PasswordChar = '*';
            Register_Password.Size = new Size(352, 50);
            Register_Password.TabIndex = 19;
            Register_Password.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(623, 575);
            label1.Name = "label1";
            label1.Size = new Size(292, 45);
            label1.TabIndex = 20;
            label1.Text = "Security Question:";
            label1.Click += label1_Click_1;
            // 
            // Securitycbx
            // 
            Securitycbx.FlatStyle = FlatStyle.Flat;
            Securitycbx.Font = new Font("Segoe UI", 10F);
            Securitycbx.FormattingEnabled = true;
            Securitycbx.IntegralHeight = false;
            Securitycbx.ItemHeight = 28;
            Securitycbx.Location = new Point(921, 587);
            Securitycbx.Name = "Securitycbx";
            Securitycbx.Size = new Size(352, 36);
            Securitycbx.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(644, 666);
            label2.Name = "label2";
            label2.Size = new Size(271, 45);
            label2.TabIndex = 22;
            label2.Text = "Security Answer:";
            // 
            // Security_Answer
            // 
            Security_Answer.Font = new Font("Segoe UI", 12F);
            Security_Answer.Location = new Point(921, 661);
            Security_Answer.Multiline = true;
            Security_Answer.Name = "Security_Answer";
            Security_Answer.PasswordChar = '*';
            Security_Answer.Size = new Size(352, 50);
            Security_Answer.TabIndex = 23;
            Security_Answer.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(726, 178);
            label3.Name = "label3";
            label3.Size = new Size(633, 75);
            label3.TabIndex = 24;
            label3.Text = "To register, please enter name, email and password.\r\nSelect your position.\r\nSelect a security question and provide an answer to ensure password recovery.";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Freestyle Script", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(486, -18);
            label4.Name = "label4";
            label4.Size = new Size(429, 170);
            label4.TabIndex = 25;
            label4.Text = "Welcome!";
            // 
            // Register_ShowAnswer
            // 
            Register_ShowAnswer.AutoSize = true;
            Register_ShowAnswer.BackColor = Color.Transparent;
            Register_ShowAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Register_ShowAnswer.ForeColor = SystemColors.ActiveCaptionText;
            Register_ShowAnswer.Location = new Point(921, 729);
            Register_ShowAnswer.Name = "Register_ShowAnswer";
            Register_ShowAnswer.Size = new Size(152, 29);
            Register_ShowAnswer.TabIndex = 26;
            Register_ShowAnswer.Text = "Show Answer";
            Register_ShowAnswer.UseVisualStyleBackColor = false;
            Register_ShowAnswer.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2083, 1106);
            Controls.Add(Register_ShowAnswer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Security_Answer);
            Controls.Add(label2);
            Controls.Add(Securitycbx);
            Controls.Add(label1);
            Controls.Add(Register_Password);
            Controls.Add(Register_Email);
            Controls.Add(Register_Name);
            Controls.Add(Register_showpass);
            Controls.Add(labelpass);
            Controls.Add(labelname);
            Controls.Add(labelemail);
            Controls.Add(Register_Cancelbtn);
            Controls.Add(Register_Registerbtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Register_Registerbtn;
        private Button Register_Cancelbtn;
        private Label labelemail;
        private Label labelname;
        private Label labelpass;
        private CheckBox Register_showpass;
        private TextBox Register_Name;
        private TextBox Register_Email;
        private TextBox Register_Password;
        private Label label1;
        private ComboBox Securitycbx;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox Security_Answer;
        private CheckBox Register_ShowAnswer;
    }
}