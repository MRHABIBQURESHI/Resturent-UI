namespace Resturent_App
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            splashlogo = new PictureBox();
            splashlb1 = new Label();
            progressBar1 = new ProgressBar();
            splashpro = new Label();
            splashpro2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splashlogo).BeginInit();
            SuspendLayout();
            // 
            // splashlogo
            // 
            splashlogo.Image = (Image)resources.GetObject("splashlogo.Image");
            splashlogo.Location = new Point(306, 42);
            splashlogo.Name = "splashlogo";
            splashlogo.Size = new Size(210, 211);
            splashlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            splashlogo.TabIndex = 0;
            splashlogo.TabStop = false;
            // 
            // splashlb1
            // 
            splashlb1.AutoSize = true;
            splashlb1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            splashlb1.ForeColor = SystemColors.ControlText;
            splashlb1.Location = new Point(306, 256);
            splashlb1.Name = "splashlb1";
            splashlb1.Size = new Size(213, 45);
            splashlb1.TabIndex = 2;
            splashlb1.Text = "Mr.Resturent";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(39, 399);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(733, 28);
            progressBar1.TabIndex = 3;
            // 
            // splashpro
            // 
            splashpro.AutoSize = true;
            splashpro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            splashpro.Location = new Point(39, 375);
            splashpro.Name = "splashpro";
            splashpro.Size = new Size(70, 21);
            splashpro.TabIndex = 4;
            splashpro.Text = "Loding....";
            // 
            // splashpro2
            // 
            splashpro2.AutoSize = true;
            splashpro2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            splashpro2.Location = new Point(717, 366);
            splashpro2.Name = "splashpro2";
            splashpro2.Size = new Size(55, 30);
            splashpro2.TabIndex = 5;
            splashpro2.Text = "99%";
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(818, 450);
            Controls.Add(splashpro2);
            Controls.Add(splashpro);
            Controls.Add(progressBar1);
            Controls.Add(splashlb1);
            Controls.Add(splashlogo);
            Name = "Splash";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)splashlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox splashlogo;
        private Label splashlb1;
        private ProgressBar progressBar1;
        private Label splashpro;
        private Label splashpro2;
    }
}