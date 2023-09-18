namespace Resturent_App
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            homeitem = new Label();
            homecash = new Label();
            homecategory = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            homebox2 = new TextBox();
            homebox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            homeedit = new Button();
            homedelete = new Button();
            homeadd = new Button();
            label3 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox7 = new PictureBox();
            categorylist = new Guna.UI2.WinForms.Guna2DataGridView();
            CatCode = new DataGridViewTextBoxColumn();
            cn = new DataGridViewTextBoxColumn();
            cd = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorylist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(homeitem);
            panel1.Controls.Add(homecash);
            panel1.Controls.Add(homecategory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 515);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 119);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "Users";
            label1.Click += label1_Click;
            // 
            // homeitem
            // 
            homeitem.AutoSize = true;
            homeitem.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homeitem.Location = new Point(60, 173);
            homeitem.Name = "homeitem";
            homeitem.Size = new Size(60, 25);
            homeitem.TabIndex = 4;
            homeitem.Text = "Items";
            // 
            // homecash
            // 
            homecash.AutoSize = true;
            homecash.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homecash.Location = new Point(60, 273);
            homecash.Name = "homecash";
            homecash.Size = new Size(53, 25);
            homecash.TabIndex = 6;
            homecash.Text = "Cash";
            // 
            // homecategory
            // 
            homecategory.AutoSize = true;
            homecategory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homecategory.Location = new Point(62, 224);
            homecategory.Name = "homecategory";
            homecategory.Size = new Size(103, 25);
            homecategory.TabIndex = 3;
            homecategory.Text = "Categories";
            homecategory.Click += homecategory_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 464);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 8;
            label2.Text = "Log Out";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(19, 464);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 173);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 273);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(homebox2);
            panel2.Controls.Add(homebox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(homeedit);
            panel2.Controls.Add(homedelete);
            panel2.Controls.Add(homeadd);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(188, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 487);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // homebox2
            // 
            homebox2.Location = new Point(13, 210);
            homebox2.Name = "homebox2";
            homebox2.Size = new Size(162, 23);
            homebox2.TabIndex = 17;
            homebox2.TextChanged += homebox2_TextChanged;
            // 
            // homebox1
            // 
            homebox1.Location = new Point(13, 109);
            homebox1.Name = "homebox1";
            homebox1.Size = new Size(162, 23);
            homebox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 187);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 15;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 86);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 14;
            label5.Text = "Category";
            // 
            // homeedit
            // 
            homeedit.BackColor = Color.LimeGreen;
            homeedit.Location = new Point(24, 413);
            homeedit.Name = "homeedit";
            homeedit.Size = new Size(151, 34);
            homeedit.TabIndex = 12;
            homeedit.Text = "Edit User";
            homeedit.UseVisualStyleBackColor = false;
            // 
            // homedelete
            // 
            homedelete.BackColor = Color.Salmon;
            homedelete.Location = new Point(24, 374);
            homedelete.Name = "homedelete";
            homedelete.Size = new Size(151, 33);
            homedelete.TabIndex = 11;
            homedelete.Text = "Delete User";
            homedelete.UseVisualStyleBackColor = false;
            // 
            // homeadd
            // 
            homeadd.BackColor = Color.CornflowerBlue;
            homeadd.Location = new Point(24, 336);
            homeadd.Name = "homeadd";
            homeadd.Size = new Size(151, 32);
            homeadd.TabIndex = 10;
            homeadd.Text = "Add User";
            homeadd.UseVisualStyleBackColor = false;
            homeadd.Click += homeadd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 16);
            label3.Name = "label3";
            label3.Size = new Size(147, 25);
            label3.TabIndex = 9;
            label3.Text = "Category Detail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 4);
            label6.Name = "label6";
            label6.Size = new Size(385, 20);
            label6.TabIndex = 9;
            label6.Text = "Mr.Resturnet System                        Mr.Resturnet System";
            // 
            // panel4
            // 
            panel4.BackColor = Color.GhostWhite;
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(12, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(876, 28);
            panel4.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(838, 6);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(23, 19);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // categorylist
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            categorylist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            categorylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            categorylist.ColumnHeadersHeight = 4;
            categorylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categorylist.Columns.AddRange(new DataGridViewColumn[] { CatCode, cn, cd });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            categorylist.DefaultCellStyle = dataGridViewCellStyle3;
            categorylist.GridColor = Color.FromArgb(231, 229, 255);
            categorylist.Location = new Point(402, 56);
            categorylist.Name = "categorylist";
            categorylist.RowHeadersVisible = false;
            categorylist.RowTemplate.Height = 25;
            categorylist.Size = new Size(426, 431);
            categorylist.TabIndex = 3;
            categorylist.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            categorylist.ThemeStyle.AlternatingRowsStyle.Font = null;
            categorylist.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            categorylist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            categorylist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            categorylist.ThemeStyle.BackColor = Color.White;
            categorylist.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            categorylist.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            categorylist.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            categorylist.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categorylist.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            categorylist.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categorylist.ThemeStyle.HeaderStyle.Height = 4;
            categorylist.ThemeStyle.ReadOnly = false;
            categorylist.ThemeStyle.RowsStyle.BackColor = Color.White;
            categorylist.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            categorylist.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            categorylist.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            categorylist.ThemeStyle.RowsStyle.Height = 25;
            categorylist.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            categorylist.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            categorylist.CellContentClick += categorylist_CellContentClick;
            // 
            // CatCode
            // 
            CatCode.HeaderText = "CatCode";
            CatCode.Name = "CatCode";
            // 
            // cn
            // 
            cn.HeaderText = "Cat_Name";
            cn.Name = "cn";
            // 
            // cd
            // 
            cd.HeaderText = "Cat_Desc";
            cd.Name = "cd";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumOrchid;
            ClientSize = new Size(900, 539);
            Controls.Add(categorylist);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorylist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label homecategory;
        private Label homeitem;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pictureBox5;
        private Label homecash;
        private PictureBox pictureBox6;
        private Label label2;
        private Button homeedit;
        private Button homedelete;
        private Button homeadd;
        private Label label3;
        private TextBox homebox2;
        private TextBox homebox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox7;
        private Guna.UI2.WinForms.Guna2DataGridView categorylist;
        private DataGridViewTextBoxColumn CatCode;
        private DataGridViewTextBoxColumn cn;
        private DataGridViewTextBoxColumn cd;
    }
}