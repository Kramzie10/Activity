using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetName_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            MessageBox.Show(name.Length.ToString(), "Name Length");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Upper = nameTextBox.Text;
            MessageBox.Show(Upper.ToUpper(), "UpperText");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Lower = nameTextBox.Text;
            MessageBox.Show(Lower.ToLower(), "LowerText");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string Greetings = nameTextBox.Text;
            MessageBox.Show($"Hello, {Greetings}! Welcome to the C# Programming course ", "Greetings");
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            string Replace = nameTextBox.Text;
            string Replace2 = textBox2.Text;
            MessageBox.Show(Replace.Replace("World", Replace2), "Replace");
        }

        private void EvenOdd_Click(object sender, EventArgs e)
        {
            int number = int.Parse(nameTextBox.Text);
            if (number % 2 == 0)
            {
                MessageBox.Show($"{number} is even.", "Even");
            }
            else
            {
                MessageBox.Show($"{number} is odd.", "Odd");
            }
        }
    }
}