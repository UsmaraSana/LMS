﻿namespace LMS
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhNo = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPW = new System.Windows.Forms.TextBox();
            this.labellastname = new System.Windows.Forms.Label();
            this.labelphno = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelpw = new System.Windows.Forms.Label();
            this.labelcnpw = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttoncreateacc = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.maxbutton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(585, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create your account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1366, 768);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstname.Location = new System.Drawing.Point(516, 125);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(69, 16);
            this.labelfirstname.TabIndex = 2;
            this.labelfirstname.Text = "First name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFirstName.Location = new System.Drawing.Point(519, 144);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(369, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLastName.Location = new System.Drawing.Point(519, 190);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(369, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxPhNo
            // 
            this.textBoxPhNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPhNo.Location = new System.Drawing.Point(519, 236);
            this.textBoxPhNo.Name = "textBoxPhNo";
            this.textBoxPhNo.Size = new System.Drawing.Size(369, 20);
            this.textBoxPhNo.TabIndex = 5;
            this.textBoxPhNo.Text = "03xxxxxxxxx";
            this.textBoxPhNo.TextChanged += new System.EventHandler(this.textBoxPhNo_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEmail.Location = new System.Drawing.Point(519, 282);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(369, 20);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Text = "example@gmail.com";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(519, 328);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(369, 20);
            this.textBoxPW.TabIndex = 7;
            // 
            // textBoxConfirmPW
            // 
            this.textBoxConfirmPW.Location = new System.Drawing.Point(519, 374);
            this.textBoxConfirmPW.Name = "textBoxConfirmPW";
            this.textBoxConfirmPW.PasswordChar = '*';
            this.textBoxConfirmPW.Size = new System.Drawing.Size(369, 20);
            this.textBoxConfirmPW.TabIndex = 8;
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastname.Location = new System.Drawing.Point(516, 171);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(69, 16);
            this.labellastname.TabIndex = 10;
            this.labellastname.Text = "Last name";
            // 
            // labelphno
            // 
            this.labelphno.AutoSize = true;
            this.labelphno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphno.Location = new System.Drawing.Point(516, 217);
            this.labelphno.Name = "labelphno";
            this.labelphno.Size = new System.Drawing.Size(97, 16);
            this.labelphno.TabIndex = 11;
            this.labelphno.Text = "Phone Number";
            this.labelphno.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(516, 263);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(41, 16);
            this.labelemail.TabIndex = 12;
            this.labelemail.Text = "Email";
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpw.Location = new System.Drawing.Point(516, 309);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(67, 16);
            this.labelpw.TabIndex = 13;
            this.labelpw.Text = "Password";
            this.labelpw.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelcnpw
            // 
            this.labelcnpw.AutoSize = true;
            this.labelcnpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcnpw.Location = new System.Drawing.Point(516, 355);
            this.labelcnpw.Name = "labelcnpw";
            this.labelcnpw.Size = new System.Drawing.Size(114, 16);
            this.labelcnpw.TabIndex = 14;
            this.labelcnpw.Text = "Confirm password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(644, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Already have an account?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 400);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "agree terms and conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttoncreateacc
            // 
            this.buttoncreateacc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttoncreateacc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncreateacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncreateacc.Location = new System.Drawing.Point(519, 448);
            this.buttoncreateacc.Name = "buttoncreateacc";
            this.buttoncreateacc.Size = new System.Drawing.Size(369, 23);
            this.buttoncreateacc.TabIndex = 17;
            this.buttoncreateacc.Text = "CREATE ACCOUNT";
            this.buttoncreateacc.UseVisualStyleBackColor = false;
            this.buttoncreateacc.Click += new System.EventHandler(this.buttoncreateacc_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.Location = new System.Drawing.Point(519, 546);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(369, 23);
            this.buttonlogin.TabIndex = 18;
            this.buttonlogin.Text = "LOG IN";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "_____________________________________________________________";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.minbutton);
            this.panel2.Controls.Add(this.closebutton);
            this.panel2.Controls.Add(this.maxbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 24);
            this.panel2.TabIndex = 20;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(34, 6);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(42, 16);
            this.home.TabIndex = 22;
            this.home.Text = "LIBRO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // minbutton
            // 
            this.minbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minbutton.BackgroundImage")));
            this.minbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minbutton.Location = new System.Drawing.Point(1292, 2);
            this.minbutton.Name = "minbutton";
            this.minbutton.Size = new System.Drawing.Size(20, 20);
            this.minbutton.TabIndex = 22;
            this.minbutton.UseVisualStyleBackColor = true;
            this.minbutton.Click += new System.EventHandler(this.minbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.Location = new System.Drawing.Point(1344, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(20, 20);
            this.closebutton.TabIndex = 21;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // maxbutton
            // 
            this.maxbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maxbutton.BackgroundImage")));
            this.maxbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxbutton.Location = new System.Drawing.Point(1318, 2);
            this.maxbutton.Name = "maxbutton";
            this.maxbutton.Size = new System.Drawing.Size(20, 20);
            this.maxbutton.TabIndex = 22;
            this.maxbutton.UseVisualStyleBackColor = true;
            this.maxbutton.Click += new System.EventHandler(this.maxbutton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(556, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 80);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttoncreateacc);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelcnpw);
            this.Controls.Add(this.labelpw);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelphno);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.textBoxConfirmPW);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhNo);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelfirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SignUp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhNo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxConfirmPW;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labelphno;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.Label labelcnpw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttoncreateacc;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button maxbutton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button button1;
    }
}

