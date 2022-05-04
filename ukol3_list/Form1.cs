using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukol3_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
        }
    
        public string Vypis(List<String>list)//nejspis jsem spatne pochopil zadani. Kazdopadne jsem to udelal takto..
        {
            foreach (String veta in list)
            {
                return veta.ToString();
            }
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button2.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button4.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(((Button)sender).Text, "");
            textBox2.Text = Vypis(list);
            button7.Enabled = false;
        }
    }
}
