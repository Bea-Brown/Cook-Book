
namespace CookBook
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Login_Loginbtn = new Button();
            Login_Registerbtn = new Button();
            LabelEmail = new Label();
            LabelPass = new Label();
            pictureBox1 = new PictureBox();
            Login_Email = new TextBox();
            Login_Password = new TextBox();
            Login_Showpass = new CheckBox();
            LoginlinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login_Loginbtn
            // 
            Login_Loginbtn.BackColor = Color.FromArgb(255, 192, 128);
            Login_Loginbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Login_Loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Loginbtn.Location = new Point(805, 873);
            Login_Loginbtn.Name = "Login_Loginbtn";
            Login_Loginbtn.Size = new Size(228, 59);
            Login_Loginbtn.TabIndex = 0;
            Login_Loginbtn.Text = "Login";
            Login_Loginbtn.UseVisualStyleBackColor = false;
            Login_Loginbtn.Click += Login_Click;
            // 
            // Login_Registerbtn
            // 
            Login_Registerbtn.BackColor = Color.FromArgb(255, 192, 128);
            Login_Registerbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Login_Registerbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Registerbtn.Location = new Point(1064, 873);
            Login_Registerbtn.Name = "Login_Registerbtn";
            Login_Registerbtn.Size = new Size(228, 59);
            Login_Registerbtn.TabIndex = 7;
            Login_Registerbtn.Text = "Register";
            Login_Registerbtn.UseVisualStyleBackColor = false;
            Login_Registerbtn.Click += RegisterButton_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.BackColor = Color.Transparent;
            LabelEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEmail.ForeColor = SystemColors.ButtonHighlight;
            LabelEmail.Location = new Point(836, 496);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(121, 48);
            LabelEmail.TabIndex = 10;
            LabelEmail.Text = "Email:";
            LabelEmail.Click += LabelEmail_Click;
            // 
            // LabelPass
            // 
            LabelPass.AutoSize = true;
            LabelPass.BackColor = Color.Transparent;
            LabelPass.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPass.ForeColor = SystemColors.ButtonHighlight;
            LabelPass.Location = new Point(768, 595);
            LabelPass.Name = "LabelPass";
            LabelPass.Size = new Size(189, 48);
            LabelPass.TabIndex = 11;
            LabelPass.Text = "Password:";
            LabelPass.Click += LabelPass_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(887, 159);
            pictureBox1.Margin = new Padding(3, 3, 0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // Login_Email
            // 
            Login_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Email.Location = new Point(953, 496);
            Login_Email.Multiline = true;
            Login_Email.Name = "Login_Email";
            Login_Email.Size = new Size(352, 50);
            Login_Email.TabIndex = 13;
            Login_Email.TabStop = false;
            Login_Email.TextChanged += Emailtxt_TextChanged;
            // 
            // Login_Password
            // 
            Login_Password.Font = new Font("Segoe UI", 12F);
            Login_Password.Location = new Point(953, 595);
            Login_Password.Multiline = true;
            Login_Password.Name = "Login_Password";
            Login_Password.PasswordChar = '*';
            Login_Password.Size = new Size(352, 50);
            Login_Password.TabIndex = 14;
            Login_Password.TabStop = false;
            Login_Password.TextChanged += Passwordtxt_TextChanged;
            // 
            // Login_Showpass
            // 
            Login_Showpass.AutoSize = true;
            Login_Showpass.BackColor = Color.Transparent;
            Login_Showpass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Login_Showpass.ForeColor = SystemColors.ButtonFace;
            Login_Showpass.Location = new Point(1123, 651);
            Login_Showpass.Name = "Login_Showpass";
            Login_Showpass.Size = new Size(169, 29);
            Login_Showpass.TabIndex = 15;
            Login_Showpass.Text = "Show Password";
            Login_Showpass.UseVisualStyleBackColor = false;
            Login_Showpass.CheckedChanged += Login_Showpass_CheckedChanged;
            // 
            // LoginlinkLabel
            // 
            LoginlinkLabel.AutoSize = true;
            LoginlinkLabel.BackColor = Color.Transparent;
            LoginlinkLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginlinkLabel.ForeColor = Color.Black;
            LoginlinkLabel.LinkColor = Color.White;
            LoginlinkLabel.Location = new Point(964, 652);
            LoginlinkLabel.Name = "LoginlinkLabel";
            LoginlinkLabel.Size = new Size(153, 25);
            LoginlinkLabel.TabIndex = 16;
            LoginlinkLabel.TabStop = true;
            LoginlinkLabel.Text = "Forgot Password";
            LoginlinkLabel.LinkClicked += Lo_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.Untitled_design;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2083, 1106);
            Controls.Add(LoginlinkLabel);
            Controls.Add(Login_Showpass);
            Controls.Add(Login_Password);
            Controls.Add(Login_Email);
            Controls.Add(LabelPass);
            Controls.Add(LabelEmail);
            Controls.Add(Login_Registerbtn);
            Controls.Add(Login_Loginbtn);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chef's CookBook Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LabelPass_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button Login_Loginbtn;
        private Button Login_Registerbtn;
        private Label LabelEmail;
        private Label LabelPass;
        private PictureBox pictureBox1;
        private TextBox Login_Email;
        private TextBox Login_Password;
        private CheckBox Login_Showpass;
        private LinkLabel LoginlinkLabel;
    }
}
