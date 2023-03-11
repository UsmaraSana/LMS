namespace LMS
{
    partial class Request
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request));
            this.label1 = new System.Windows.Forms.Label();
            this.navLabel = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.why = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reqButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.maxbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(531, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 89;
            this.label1.Text = "Fill the form to request a book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navLabel.Location = new System.Drawing.Point(12, 27);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(33, 27);
            this.navLabel.TabIndex = 88;
            this.navLabel.Text = "🔙";
            this.navLabel.Click += new System.EventHandler(this.navLabel_Click);
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(21, 48);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(68, 16);
            this.bookTitle.TabIndex = 90;
            this.bookTitle.Text = "Book title: ";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(21, 103);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(88, 16);
            this.authorName.TabIndex = 91;
            this.authorName.Text = "Author name: ";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(21, 166);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(68, 16);
            this.category.TabIndex = 92;
            this.category.Text = "Category: ";
            // 
            // why
            // 
            this.why.AutoSize = true;
            this.why.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.why.Location = new System.Drawing.Point(21, 229);
            this.why.Name = "why";
            this.why.Size = new System.Drawing.Size(128, 16);
            this.why.TabIndex = 93;
            this.why.Text = "Why do you need it?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.reqButton);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bookTitle);
            this.panel1.Controls.Add(this.why);
            this.panel1.Controls.Add(this.authorName);
            this.panel1.Controls.Add(this.category);
            this.panel1.Location = new System.Drawing.Point(404, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 457);
            this.panel1.TabIndex = 94;
            // 
            // reqButton
            // 
            this.reqButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.reqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reqButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.reqButton.Location = new System.Drawing.Point(182, 378);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(152, 23);
            this.reqButton.TabIndex = 98;
            this.reqButton.Text = "SEND REQUEST";
            this.reqButton.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(447, 96);
            this.richTextBox1.TabIndex = 97;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(115, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 22);
            this.textBox3.TabIndex = 96;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 22);
            this.textBox2.TabIndex = 95;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 22);
            this.textBox1.TabIndex = 94;
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
            this.panel2.Size = new System.Drawing.Size(525, 24);
            this.panel2.TabIndex = 99;
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
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Request";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label why;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button maxbutton;
    }
}