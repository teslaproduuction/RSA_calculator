namespace rsa
{
    public partial class Form1 : Form
    {
        int i;
        List<Image> new_imageList = new List<Image>();
        List<Image> new_imageList1 = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Ó·¿Î„ÓËÚÏÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
        }
        private void ÛÍÓ‚Ó‰ÒÚ‚ÓToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Size = new System.Drawing.Size(1, 1);
            this.Width = 700;
            this.Height = 500;
            pictureBox2.Visible = false;
            pictureBox1.Size = new System.Drawing.Size(640, 480);
            pictureBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
        }
        private void ¯ËÙÓ‚‡ÌËÂ“ÂÍÒÚ‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 MyForm3 = new Form3();
            MyForm3.ShowDialog();
        }
        private void ‰Â¯ËÙÓ‚‡ÌËÂ“ÂÍÒÚ‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 MyForm4 = new Form4();
            MyForm4.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (i < new_imageList.Count-1)
            {
                i++;
                pictureBox1.Image = new_imageList[i];
               if (i == new_imageList.Count-1)
                    button1.Enabled = false;
            }
            button2.Enabled = true;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] img1 = { "0.PNG" };
            foreach (string imgName1 in img1)
            {
                new_imageList1.Add(Image.FromFile(imgName1));
            }
            pictureBox2.Image = new_imageList1[0];

            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            string[] img = { "1.PNG", "2.PNG", "3.PNG", "4.PNG", "5.PNG", "6.PNG", "7.PNG", "8.PNG", "9.PNG" };
            foreach (string imgName in img)
            {
                new_imageList.Add(Image.FromFile(imgName));
            }
            pictureBox1.Image = new_imageList[0];
            i = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                pictureBox1.Image = new_imageList[i];
                if (i == 0)
                    button2.Enabled = false;
            }
            button1.Enabled=true;
        }
        private void Ù‡ÈÎToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 779;
            this.Height = 730;
            pictureBox1.Size = new System.Drawing.Size(1, 1);
            pictureBox2.Visible = true;
            pictureBox2.Size = new System.Drawing.Size(763, 703);
            pictureBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
    }
}


