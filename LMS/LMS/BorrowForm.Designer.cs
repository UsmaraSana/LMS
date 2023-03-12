namespace LMS
{
    partial class BorrowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reqButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.navLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.maxbutton = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Label();
            this.authorName = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePickerBorrow = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.dateTimePickerReturn);
            this.panel1.Controls.Add(this.dateTimePickerBorrow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.reqButton);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bookTitle);
            this.panel1.Controls.Add(this.authorName);
            this.panel1.Controls.Add(this.category);
            this.panel1.Location = new System.Drawing.Point(398, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 428);
            this.panel1.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Borrow Date:";
            // 
            // reqButton
            // 
            this.reqButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.reqButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.reqButton.Location = new System.Drawing.Point(172, 343);
            this.reqButton.Name = "reqButton";
            this.reqButton.Size = new System.Drawing.Size(201, 23);
            this.reqButton.TabIndex = 98;
            this.reqButton.Text = "BORROW";
            this.reqButton.UseVisualStyleBackColor = false;
            this.reqButton.Click += new System.EventHandler(this.reqButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(528, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 96;
            this.label1.Text = "Fill the form to borrow a book";
            // 
            // navLabel
            // 
            this.navLabel.AutoSize = true;
            this.navLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navLabel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navLabel.Location = new System.Drawing.Point(12, 35);
            this.navLabel.Name = "navLabel";
            this.navLabel.Size = new System.Drawing.Size(33, 27);
            this.navLabel.TabIndex = 95;
            this.navLabel.Text = "🔙";
            this.navLabel.Click += new System.EventHandler(this.navLabel_Click);
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
            this.panel2.TabIndex = 100;
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
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(21, 145);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(68, 16);
            this.category.TabIndex = 92;
            this.category.Text = "Category: ";
            // 
            // authorName
            // 
            this.authorName.AutoSize = true;
            this.authorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.Location = new System.Drawing.Point(21, 82);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(88, 16);
            this.authorName.TabIndex = 91;
            this.authorName.Text = "Author name: ";
            // 
            // bookTitle
            // 
            this.bookTitle.AutoSize = true;
            this.bookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitle.Location = new System.Drawing.Point(21, 27);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(68, 16);
            this.bookTitle.TabIndex = 90;
            this.bookTitle.Text = "Book title: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(115, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 22);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "C++ Programming";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(115, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 22);
            this.textBox2.TabIndex = 95;
            this.textBox2.Text = "DS Malik";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(115, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 22);
            this.textBox3.TabIndex = 96;
            this.textBox3.Text = "Comp. Science";
            // 
            // dateTimePickerBorrow
            // 
            this.dateTimePickerBorrow.Location = new System.Drawing.Point(115, 204);
            this.dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            this.dateTimePickerBorrow.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBorrow.TabIndex = 101;
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Location = new System.Drawing.Point(115, 260);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturn.TabIndex = 102;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BorrowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BorrowForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reqButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.Label authorName;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button maxbutton;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
    }
}