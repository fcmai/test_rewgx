using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormRegx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var source = "123abc...345DEf";
            Regex regx = new Regex(@"\?");//, RegexOptions.IgnoreCase);
            string content = textBox_BCMask.Text;

            content = regx.Replace(content, ".");textBox1.Text = content;
            //Match m = regx.Match(content);
//             while (m.Success)
//             {
//                 content = content.Remove(m.Index, m.Value.Length);
//                 content = content.Insert(m.Index, @".");
//                 m = regx.Match(content);
//             }
            source = content;// "12345.....12345";
           // Regex regex = new Regex("?", RegexOptions.IgnoreCase);
            Regex r = new Regex(source);// ("12345.....12345");
            Match m = r.Match(textBox_BC2Check.Text.Trim(),0); // 在字符串中匹配
            if (textBox_BCMask.Text.Length == textBox_BC2Check.Text.Length)
            {
                if (m.Success)
                {
                    MessageBox.Show("OK\n\t匹配");
                }
                else
                    MessageBox.Show("NG1\n\t就是不对付");
            }
            else
                MessageBox.Show("NG2\n\t长度不匹配");


// 
//             var words =
//                from word in "The quick brown fox jumps over the lazy dog".Split()
//                orderby word.ToUpper()
//                select word;
// 
//             var duplicates =
//                 from word in words
//                 group word.ToUpper() by word.ToUpper() into g
//                 where g.Count() > 1
//                 select new { g.Key, Count = g.Count() };
// 
//             // The Dump extension method writes out queries:
// 
//             words.Dump();
//             duplicates.Dump();

            //Regex regex = new Regex("def", RegexOptions.IgnoreCase);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//             var tmr = new DispatcherTimer { IsEnabled = true };
//             tmr.Tick += (sender, args) => label3.Text = DateTime.Now.ToString("o");
        }
    }
}
//Regex regx = new Regex(Regex regx = new Regex(