using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace MD5WindowsFormsApp
{
    public partial class ms5hash : Form
    {
        public ms5hash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputText = richTextBox1.Text.Split('\n');
            foreach (string item in inputText)
            {
                richTextBox2.AppendText(HashMD5(item) + "\n");
                richTextBox2.Update();
            }
        }
        public string HashMD5(string text)
        {
            string s = "";
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            for (int i = 0; i < hash.Length; i++)
            {
                s += hash[i].ToString("x2");
            }
            return s;
        }

        private void SHA256Button_Click(object sender, EventArgs e)
        {
            var inputText = richTextBox1.Text.Split('\n');
            foreach (string item in inputText)
            {
                richTextBox2.AppendText(HashSHA256(item) + "\n");
                richTextBox2.Update();
            }
        }

        public string HashSHA256(string text)
        {
            string s = "";
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
            for (int i = 0; i < hash.Length; i++)
            {
                s += hash[i].ToString("x2");
            }
            return s;
        }
    }
}
