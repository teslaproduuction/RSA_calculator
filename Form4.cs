using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace rsa
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string m;
        public BigInteger e = new BigInteger();
        private string RSA_Dedoce(List<string> input, BigInteger d, BigInteger n)
        {
            string result = "";
            BigInteger bi;

            foreach (string item in input)
            {
                bi = (BigInteger.Parse(item));
                bi = BigInteger.ModPow(bi, d, n);
                Int64 b = (Int64)bi;
                result += Convert.ToChar(b).ToString();
                
            }

            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            StreamReader sr = new StreamReader(filename);
            var list = File.ReadAllLines(filename);
            richTextBox1.Text = list[0];
            textBox1.Text = list[list.Length-3];
            textBox2.Text = list[list.Length-2];
            textBox5.Text = list[list.Length - 1];
            sr.Close();
        }
        public static BigInteger Eiler(BigInteger a)
        {
            BigInteger result = a;
            for (int i = 2; i * i <= a; ++i)
                if (a % i == 0)
                {
                    while (a % i == 0)
                        a /= i;
                    result -= result / i;
                }
            if (a > 1)
                result -= result / a;
            return result;

        }
        public BigInteger Evklid(BigInteger n, BigInteger m)
        {
            BigInteger r, q, a = n;
            int i = 2;
            List<BigInteger> b = new List<BigInteger>() { 0, 1 };
            while (m != 0)
            {
                r = n % m;
                q = n / m;
                b.Add(b[i - 2] - q * b[i - 1]);
                i++;
                n = m;
                m = r;

            }
            if (b[i - 2] < 0) b[i - 2] += a;
            return b[i - 2];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            m = richTextBox1.Text;
            string[] words = m.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            this.e = BigInteger.Parse(textBox1.Text);
            BigInteger n = BigInteger.Parse(textBox2.Text);
            BigInteger d = BigInteger.Parse(textBox5.Text);
            foreach (string word in words)
            {
                list.Add(word);
            }
            string result = RSA_Dedoce(list, d, n);
            richTextBox2.Text = result;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(richTextBox2.Text);
            sw.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
