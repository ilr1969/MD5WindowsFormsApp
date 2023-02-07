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
                richTextBox2.AppendText(Hash(item) + "\n");
                richTextBox2.Update();
            }
        }
        public string Hash(string text)
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
    }
}
