namespace CookBook
{
    partial class PasswordRecovery
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
            label4 = new Label();
            Pass_Answer = new TextBox();
            pass_email = new TextBox();
            NewPass = new TextBox();
            Pass_showpass = new CheckBox();
            Pass_ShowAnswer = new CheckBox();
            verifytxt = new Button();
            Pass_Reset = new Button();
            labelemail = new Label();
            lbl = new Label();
            label2 = new Label();
            label5 = new Label();
            pass_backbtn = new Button();
            securitylbl = new Label();
            Security_cbx = new ComboBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Freestyle Script", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(477, 9);
            label4.Name = "label4";
            label4.Size = new Size(677, 170);
            label4.TabIndex = 26;
            label4.Text = "Reset Password";
            label4.Click += label4_Click;
            // 
            // Pass_Answer
            // 
            Pass_Answer.Font = new Font("Segoe UI", 12F);
            Pass_Answer.Location = new Point(921, 464);
            Pass_Answer.Multiline = true;
            Pass_Answer.Name = "Pass_Answer";
            Pass_Answer.PasswordChar = '*';
            Pass_Answer.Size = new Size(352, 50);
            Pass_Answer.TabIndex = 27;
            Pass_Answer.TabStop = false;
            // 
            // pass_email
            // 
            pass_email.Font = new Font("Segoe UI", 12F);
            pass_email.Location = new Point(921, 296);
            pass_email.Multiline = true;
            pass_email.Name = "pass_email";
            pass_email.Size = new Size(352, 50);
            pass_email.TabIndex = 28;
            pass_email.TabStop = false;
            // 
            // NewPass
            // 
            NewPass.Font = new Font("Segoe UI", 12F);
            NewPass.Location = new Point(921, 694);
            NewPass.Multiline = true;
            NewPass.Name = "NewPass";
            NewPass.PasswordChar = '*';
            NewPass.Size = new Size(352, 50);
            NewPass.TabIndex = 29;
            NewPass.TabStop = false;
            // 
            // Pass_showpass
            // 
            Pass_showpass.AutoSize = true;
            Pass_showpass.BackColor = Color.Transparent;
            Pass_showpass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Pass_showpass.ForeColor = SystemColors.ActiveCaptionText;
            Pass_showpass.Location = new Point(921, 761);
            Pass_showpass.Name = "Pass_showpass";
            Pass_showpass.Size = new Size(169, 29);
            Pass_showpass.TabIndex = 30;
            Pass_showpass.Text = "Show Password";
            Pass_showpass.UseVisualStyleBackColor = false;
            Pass_showpass.CheckedChanged += Pass_showpass_CheckedChanged;
            // 
            // Pass_ShowAnswer
            // 
            Pass_ShowAnswer.AutoSize = true;
            Pass_ShowAnswer.BackColor = Color.Transparent;
            Pass_ShowAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Pass_ShowAnswer.ForeColor = SystemColors.ActiveCaptionText;
            Pass_ShowAnswer.Location = new Point(921, 520);
            Pass_ShowAnswer.Name = "Pass_ShowAnswer";
            Pass_ShowAnswer.Size = new Size(152, 29);
            Pass_ShowAnswer.TabIndex = 31;
            Pass_ShowAnswer.Text = "Show Answer";
            Pass_ShowAnswer.UseVisualStyleBackColor = false;
            Pass_ShowAnswer.CheckedChanged += Pass_ShowAnswer_CheckedChanged;
            // 
            // verifytxt
            // 
            verifytxt.BackColor = Color.FromArgb(255, 192, 128);
            verifytxt.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            verifytxt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifytxt.Location = new Point(975, 592);
            verifytxt.Name = "verifytxt";
            verifytxt.Size = new Size(152, 46);
            verifytxt.TabIndex = 32;
            verifytxt.Text = "Verify";
            verifytxt.UseVisualStyleBackColor = false;
            verifytxt.Click += verifytxt_Click;
            // 
            // Pass_Reset
            // 
            Pass_Reset.BackColor = Color.FromArgb(255, 192, 128);
            Pass_Reset.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            Pass_Reset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pass_Reset.Location = new Point(946, 827);
            Pass_Reset.Name = "Pass_Reset";
            Pass_Reset.Size = new Size(228, 59);
            Pass_Reset.TabIndex = 33;
            Pass_Reset.Text = "Reset Password";
            Pass_Reset.UseVisualStyleBackColor = false;
            Pass_Reset.Click += Pass_Reset_Click;
            // 
            // labelemail
            // 
            labelemail.AutoSize = true;
            labelemail.BackColor = Color.Bisque;
            labelemail.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelemail.ForeColor = SystemColors.ActiveCaptionText;
            labelemail.Location = new Point(786, 298);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(121, 48);
            labelemail.TabIndex = 34;
            labelemail.Text = "Email:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Bisque;
            lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ActiveCaptionText;
            lbl.Location = new Point(615, 384);
            lbl.Name = "lbl";
            lbl.Size = new Size(292, 45);
            lbl.TabIndex = 35;
            lbl.Text = "Security Question:";
            lbl.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(636, 469);
            label2.Name = "label2";
            label2.Size = new Size(271, 45);
            label2.TabIndex = 36;
            label2.Text = "Security Answer:";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Bisque;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(632, 694);
            label5.Name = "label5";
            label5.Size = new Size(275, 48);
            label5.TabIndex = 38;
            label5.Text = "New Password:";
            // 
            // pass_backbtn
            // 
            pass_backbtn.BackColor = Color.FromArgb(255, 192, 128);
            pass_backbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 128);
            pass_backbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pass_backbtn.Location = new Point(946, 918);
            pass_backbtn.Name = "pass_backbtn";
            pass_backbtn.Size = new Size(228, 59);
            pass_backbtn.TabIndex = 39;
            pass_backbtn.Text = "Back";
            pass_backbtn.UseVisualStyleBackColor = false;
            pass_backbtn.Click += pass_backbtn_Click;
            // 
            // securitylbl
            // 
            securitylbl.AutoSize = true;
            securitylbl.BackColor = Color.Bisque;
            securitylbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            securitylbl.ForeColor = SystemColors.ActiveCaptionText;
            securitylbl.Location = new Point(921, 384);
            securitylbl.Name = "securitylbl";
            securitylbl.Size = new Size(0, 45);
            securitylbl.TabIndex = 41;
            // 
            // Security_cbx
            // 
            Security_cbx.FlatStyle = FlatStyle.Flat;
            Security_cbx.Font = new Font("Segoe UI", 10F);
            Security_cbx.FormattingEnabled = true;
            Security_cbx.IntegralHeight = false;
            Security_cbx.ItemHeight = 28;
            Security_cbx.Location = new Point(921, 396);
            Security_cbx.Name = "Security_cbx";
            Security_cbx.Size = new Size(352, 36);
            Security_cbx.TabIndex = 42;
            // 
            // PasswordRecovery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = Properties.Resources.boardin;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(2083, 1106);
            Controls.Add(Security_cbx);
            Controls.Add(securitylbl);
            Controls.Add(pass_backbtn);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lbl);
            Controls.Add(labelemail);
            Controls.Add(Pass_Reset);
            Controls.Add(verifytxt);
            Controls.Add(Pass_ShowAnswer);
            Controls.Add(Pass_showpass);
            Controls.Add(NewPass);
            Controls.Add(pass_email);
            Controls.Add(Pass_Answer);
            Controls.Add(label4);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PasswordRecovery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox Pass_Answer;
        private TextBox pass_email;
        private TextBox NewPass;
        private CheckBox Pass_showpass;
        private CheckBox Pass_ShowAnswer;
        private Button verifytxt;
        private Button Pass_Reset;
        private Label labelemail;
        private Label lbl;
        private Label label2;
        private Label label5;
        private Button pass_backbtn;
        private Label securitylbl;
        private ComboBox Security_cbx;
    }
}