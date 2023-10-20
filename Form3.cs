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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       public BigInteger FunE = new BigInteger();
        public BigInteger p, q, n = new BigInteger();
       public BigInteger d = new BigInteger();
        public BigInteger e = new BigInteger();
        string m;


        // Проверка на простоту чисел методом Миллера-Рабина
        public static bool Prov(BigInteger n, int k)
        {
            if (n == 2 || n == 3)
                return true;
            if (n < 2 || n % 2 == 0)
                return false;
            BigInteger d = n - 1;
            int s = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }
            Random rand = new Random();
            for (int i = 0; i < k; i++)
            {
                BigInteger a = 0;
                while (a < 2 || a >= n - 2)
                    a = rand.Next() % (n - 1) + 1;
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;
                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }
            return true;
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
            m = "";
            if (Prov(p, 100) & Prov(q, 100))
            {
                while (!sr.EndOfStream)
                {
                    m += sr.ReadLine();
                }
            }
            richTextBox1.Text = m;
            sr.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(richTextBox2.Text);
            sw.WriteLine(this.e);
            sw.WriteLine(n);
            sw.WriteLine(d);
            sw.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public List<string> RSA_Endoce(string s, BigInteger e, BigInteger n) //Шифрование
        {
            List<string> result = new List<string>();
            BigInteger bi;
            for (int i = 0; i < s.Length; i++)
            {
                bi = new BigInteger(s[i]);
                bi = BigInteger.ModPow(bi, e, n);
                result.Add(bi.ToString());
                if (i != s.Length)
                    result.Add(" ");
            }
            return result;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public BigInteger Euler(BigInteger p, BigInteger q)
        {
            BigInteger result = 0;
            if ((p == q) || (p == 2) || (q == 2))
                result = p * p - p;
            else
                result = (p - 1) * (q - 1);
            return result;
        }
        public BigInteger getRandom(int length) //Генерация открытого ключа (e), length - длина ключа
        {
            BigInteger bi;
           Random random = new Random();
            byte[] data = new byte[length];
            random.NextBytes(data);
            bi = new BigInteger(data);
            bi = BigInteger.Abs(bi);
            if (bi < n)
                return bi;
            else
                return getRandom(length);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            richTextBox2.Text = "";
            if (textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show("Не введены число/числа");
                return;
            }
            p = BigInteger.Parse(textBox1.Text);
            q = BigInteger.Parse(textBox2.Text);
            if (Prov(p, 100)) { }
            else
            {
                MessageBox.Show("Число p не простое, берем значение по умолчанию = 101");
                p = 101;
                textBox1.Text = "101";
            }
            if (Prov(q, 100)) { }
            else{
                MessageBox.Show("Число q не простое, берем значение по умолчанию = 103");
                q = 103;
                textBox2.Text = "103";
            }
            FunE = Euler(p, q);
            n = p * q;
            while (true)
            {
                this.e = getRandom(n.GetByteCount());
                if (BigInteger.GreatestCommonDivisor((FunE), this.e) == 1)
                    break;

            }
            // Поиск закрытого ключа
            d = Evklid((FunE),this.e);
            richTextBox3.Text = "Открытый ключ: " + this.e + " " + n + "\r\n" + "Закрытый ключ: " + d + " " + n;
            m = richTextBox1.Text;
            
            List<string> result = RSA_Endoce(m, this.e, n); //Вызов функции шифрования
            foreach (string s in result)
            richTextBox2.Text += s;

        }
    }
}
