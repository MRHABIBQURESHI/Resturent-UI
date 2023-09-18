namespace Resturent_App
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loginuser = new TextBox();
            loginpass = new TextBox();
            loginbutton = new Button();
            loginforget = new Label();
            loginlogo = new Label();
            usernamelogin = new Label();
            passlogin = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(727, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // loginuser
            // 
            loginuser.Location = new Point(191, 188);
            loginuser.Name = "loginuser";
            loginuser.Size = new Size(423, 23);
            loginuser.TabIndex = 2;
            // 
            // loginpass
            // 
            loginpass.Location = new Point(191, 276);
            loginpass.Name = "loginpass";
            loginpass.Size = new Size(423, 23);
            loginpass.TabIndex = 3;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(546, 336);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(101, 35);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Log in";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // loginforget
            // 
            loginforget.AutoSize = true;
            loginforget.ForeColor = Color.Blue;
            loginforget.Location = new Point(191, 320);
            loginforget.Name = "loginforget";
            loginforget.Size = new Size(91, 15);
            loginforget.TabIndex = 5;
            loginforget.Text = "ForgetPassword";
            // 
            // loginlogo
            // 
            loginlogo.AutoSize = true;
            loginlogo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginlogo.Location = new Point(9, 7);
            loginlogo.Name = "loginlogo";
            loginlogo.Size = new Size(196, 40);
            loginlogo.TabIndex = 6;
            loginlogo.Text = "Mr.Resturent";
            // 
            // usernamelogin
            // 
            usernamelogin.AutoSize = true;
            usernamelogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernamelogin.Location = new Point(191, 155);
            usernamelogin.Name = "usernamelogin";
            usernamelogin.Size = new Size(109, 30);
            usernamelogin.TabIndex = 7;
            usernamelogin.Text = "Username";
            // 
            // passlogin
            // 
            passlogin.AutoSize = true;
            passlogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            passlogin.Location = new Point(191, 243);
            passlogin.Name = "passlogin";
            passlogin.Size = new Size(103, 30);
            passlogin.TabIndex = 8;
            passlogin.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Location = new Point(-6, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 82);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(loginlogo);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-5, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 82);
            panel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(passlogin);
            Controls.Add(usernamelogin);
            Controls.Add(loginforget);
            Controls.Add(loginbutton);
            Controls.Add(loginpass);
            Controls.Add(loginuser);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox loginuser;
        private TextBox loginpass;
        private Button loginbutton;
        private Label loginforget;
        private Label loginlogo;
        private Label usernamelogin;
        private Label passlogin;
        private Panel panel1;
        private Panel panel2;
    }
}