using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Первый_проект__калькулятор_
{
    public partial class Form1 : Form

    {
        double num1, num2, result;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "-";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox2.Text);

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "×":
                    result = num1 * num2;
                    break;
                case "÷":
                    result = num1 / num2;
                    break;
            }

            textBox3.Text = result.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "×";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "÷";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            operation = "+";
        }

    }

}


