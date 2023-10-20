namespace rsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расшифрованиеТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробнееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАлгоритмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.шифрованиеТекстаToolStripMenuItem,
            this.расшифрованиеТекстаToolStripMenuItem,
            this.подробнееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.файлToolStripMenuItem.Text = "Главная";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // шифрованиеТекстаToolStripMenuItem
            // 
            this.шифрованиеТекстаToolStripMenuItem.Name = "шифрованиеТекстаToolStripMenuItem";
            this.шифрованиеТекстаToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.шифрованиеТекстаToolStripMenuItem.Text = "Шифрование текста";
            this.шифрованиеТекстаToolStripMenuItem.Click += new System.EventHandler(this.шифрованиеТекстаToolStripMenuItem_Click);
            // 
            // расшифрованиеТекстаToolStripMenuItem
            // 
            this.расшифрованиеТекстаToolStripMenuItem.Name = "расшифрованиеТекстаToolStripMenuItem";
            this.расшифрованиеТекстаToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.расшифрованиеТекстаToolStripMenuItem.Text = "Расшифрование текста";
            this.расшифрованиеТекстаToolStripMenuItem.Click += new System.EventHandler(this.дешифрованиеТекстаToolStripMenuItem_Click);
            // 
            // подробнееToolStripMenuItem
            // 
            this.подробнееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАлгоритмеToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.подробнееToolStripMenuItem.Name = "подробнееToolStripMenuItem";
            this.подробнееToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.подробнееToolStripMenuItem.Text = "Подробнее";
            // 
            // обАлгоритмеToolStripMenuItem
            // 
            this.обАлгоритмеToolStripMenuItem.Name = "обАлгоритмеToolStripMenuItem";
            this.обАлгоритмеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обАлгоритмеToolStripMenuItem.Text = "Об алгоритме";
            this.обАлгоритмеToolStripMenuItem.Click += new System.EventHandler(this.обАлгоритмеToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.руководствоToolStripMenuItem.Text = "Руководство";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вперёд";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(668, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(763, 703);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 691);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem шифрованиеТекстаToolStripMenuItem;
        private ToolStripMenuItem расшифрованиеТекстаToolStripMenuItem;
        private ToolStripMenuItem подробнееToolStripMenuItem;
        private ToolStripMenuItem обАлгоритмеToolStripMenuItem;
        private ToolStripMenuItem руководствоToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}