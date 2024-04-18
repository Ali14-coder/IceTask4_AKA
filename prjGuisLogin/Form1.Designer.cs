namespace prjGuisLogin
{
    partial class Form1
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
            gbWelcome = new GroupBox();
            panel1 = new Panel();
            btnResigter = new Button();
            btnWelcome = new Button();
            gbLogin = new GroupBox();
            btnLogin = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtPassLogin = new TextBox();
            txtNameLogin = new TextBox();
            gbRegister = new GroupBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            txtPassRegister = new TextBox();
            txtNameReg = new TextBox();
            btnRegUser = new Button();
            gbWelcome.SuspendLayout();
            panel1.SuspendLayout();
            gbLogin.SuspendLayout();
            panel2.SuspendLayout();
            gbRegister.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // gbWelcome
            // 
            gbWelcome.Controls.Add(panel1);
            gbWelcome.Location = new Point(12, 12);
            gbWelcome.Name = "gbWelcome";
            gbWelcome.Size = new Size(332, 222);
            gbWelcome.TabIndex = 0;
            gbWelcome.TabStop = false;
            gbWelcome.Text = "Welcome";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnResigter);
            panel1.Controls.Add(btnWelcome);
            panel1.Location = new Point(60, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // btnResigter
            // 
            btnResigter.Location = new Point(51, 56);
            btnResigter.Name = "btnResigter";
            btnResigter.Size = new Size(94, 23);
            btnResigter.TabIndex = 1;
            btnResigter.Text = "Sign Up";
            btnResigter.UseVisualStyleBackColor = true;
            btnResigter.Click += btnResigter_Click;
            // 
            // btnWelcome
            // 
            btnWelcome.Location = new Point(51, 20);
            btnWelcome.Name = "btnWelcome";
            btnWelcome.Size = new Size(94, 23);
            btnWelcome.TabIndex = 0;
            btnWelcome.Text = "Sign In";
            btnWelcome.UseVisualStyleBackColor = true;
            btnWelcome.Click += btnWelcome_Click;
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(panel2);
            gbLogin.Location = new Point(375, 12);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(332, 222);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            gbLogin.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(132, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassLogin);
            panel2.Controls.Add(txtNameLogin);
            panel2.Location = new Point(60, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // txtPassLogin
            // 
            txtPassLogin.Location = new Point(72, 48);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(100, 23);
            txtPassLogin.TabIndex = 1;
            // 
            // txtNameLogin
            // 
            txtNameLogin.Location = new Point(72, 19);
            txtNameLogin.Name = "txtNameLogin";
            txtNameLogin.Size = new Size(100, 23);
            txtNameLogin.TabIndex = 0;
            // 
            // gbRegister
            // 
            gbRegister.Controls.Add(btnRegUser);
            gbRegister.Controls.Add(panel3);
            gbRegister.Location = new Point(12, 241);
            gbRegister.Name = "gbRegister";
            gbRegister.Size = new Size(332, 222);
            gbRegister.TabIndex = 4;
            gbRegister.TabStop = false;
            gbRegister.Text = "Register";
            gbRegister.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtPassRegister);
            panel3.Controls.Add(txtNameReg);
            panel3.Location = new Point(60, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 20);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // txtPassRegister
            // 
            txtPassRegister.Location = new Point(72, 48);
            txtPassRegister.Name = "txtPassRegister";
            txtPassRegister.Size = new Size(100, 23);
            txtPassRegister.TabIndex = 1;
            // 
            // txtNameReg
            // 
            txtNameReg.Location = new Point(72, 19);
            txtNameReg.Name = "txtNameReg";
            txtNameReg.Size = new Size(100, 23);
            txtNameReg.TabIndex = 0;
            // 
            // btnRegUser
            // 
            btnRegUser.Location = new Point(107, 173);
            btnRegUser.Name = "btnRegUser";
            btnRegUser.Size = new Size(98, 23);
            btnRegUser.TabIndex = 2;
            btnRegUser.Text = "Sign Up";
            btnRegUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 475);
            Controls.Add(gbRegister);
            Controls.Add(gbLogin);
            Controls.Add(gbWelcome);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbWelcome.ResumeLayout(false);
            panel1.ResumeLayout(false);
            gbLogin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gbRegister.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbWelcome;
        private Panel panel1;
        private Button btnWelcome;
        private GroupBox gbLogin;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox txtPassLogin;
        private TextBox txtNameLogin;
        private Button btnLogin;
        private GroupBox gbRegister;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private TextBox txtPassRegister;
        private TextBox txtNameReg;
        private Button btnResigter;
        private Button btnRegUser;
    }
}
