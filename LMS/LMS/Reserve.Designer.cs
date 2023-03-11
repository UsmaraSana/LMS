namespace LMS
{
    partial class Reserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserve));
            this.label1 = new System.Windows.Forms.Label();
            this.navLabel = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.maxbutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Sorry, no new item to be included in the library :(\r\n";
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
            this.navLabel.TabIndex = 92;
            this.navLabel.Text = "🔙";
            this.navLabel.Click += new System.EventHandler(this.navLabel_Click);
            // 
            // request
            // 
            this.request.AutoSize = true;
            this.request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request.ForeColor = System.Drawing.Color.Teal;
            this.request.Location = new System.Drawing.Point(73, 103);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(122, 20);
            this.request.TabIndex = 95;
            this.request.Text = "Request a book";
            this.request.Click += new System.EventHandler(this.request_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(191, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 20);
            this.label.TabIndex = 96;
            this.label.Text = "instead";
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
            this.panel2.TabIndex = 97;
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
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.request);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reserve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label navLabel;
        private System.Windows.Forms.Label request;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button maxbutton;
    }
}