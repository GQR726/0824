using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0824
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = (string)textBox1.Text;
            string t2 = (string)textBox2.Text;
            MessageBox.Show("Good Morning "+t1+"!! Your age is "+t2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3 .Text == "fine")
            {
                MessageBox.Show("Life is great!");
            }
            else
            {
                MessageBox.Show("Everything's gonna be alright.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = (int)numericUpDown1.Value;
            int n2 = (int)numericUpDown2.Value;
            if(n1>=n2)
            {
                string n3 = string.Format(Convert.ToString(n1));
                MessageBox.Show(n3);
            }
            else
            {
                string n4 = string.Format(Convert.ToString(n2));
                MessageBox.Show(n4);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10 " +
                "9 " +
                "8 " +
                "7 " +
                "6 " +
                "5 " +
                "4 " +
                "3 " +
                "2 " +
                "1");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
