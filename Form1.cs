using System;
using System.Windows.Forms;

namespace ProjectCalculatrice
{
    public partial class Form1 : Form
    {
        Operations Options;
        float TotalValue = 0;

        public Form1()
        {
            InitializeComponent();
            Options = new Operations(); // FIX: initialization
        }
        void RemoveZeroFormScreen()
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text="";
            }
        }

        struct Operations
        {
            public float FirstNumber;
            public float SecondeNumber;
            public string Option;
            public float Result;
        }

        private float SafeParse(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : float.Parse(text);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_MouseCaptureChanged(object sender, EventArgs e) { }
        private void Form1_MouseClick(object sender, MouseEventArgs e) { }
        private void button1_MouseClick(object sender, MouseEventArgs e) { }
        private void Form1_Click(object sender, EventArgs e) { }
        private void textBoxResult_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button1.Tag.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button2.Tag.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button3.Tag.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button4.Tag.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button5.Tag.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button6.Tag.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button7.Tag.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button8.Tag.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveZeroFormScreen();
            textBox1.Text += button9.Tag.ToString();
        }

        // FIX: 0 button
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="0")
            textBox1.Text += "0";
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("No Number In Screen Of Calculator","Error");
                return;
            }
          textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
            
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Options.Option = "+";
            Options.FirstNumber = SafeParse(textBox1.Text);
            textBox1.Clear();
            textBoxResult.Clear();
        }

        private void buttonMultiblication_Click(object sender, EventArgs e)
        {
            Options.Option = "*";
            Options.FirstNumber = SafeParse(textBox1.Text);
            textBox1.Clear();
            textBoxResult.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            Options.Option = "/";
            Options.FirstNumber = SafeParse(textBox1.Text);
            textBox1.Clear();
            textBoxResult.Clear();
        }

        private void buttonAbstraction_Click(object sender, EventArgs e)
        {
            Options.Option = "-";
            Options.FirstNumber = SafeParse(textBox1.Text);
            textBox1.Clear();
            textBoxResult.Clear();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Options.SecondeNumber = SafeParse(textBox1.Text);

            switch (Options.Option)
            {
                case "+":
                    Options.Result = Options.FirstNumber + Options.SecondeNumber;
                    break;

                case "-":
                    Options.Result = Options.FirstNumber - Options.SecondeNumber;
                    break;

                case "*":
                    Options.Result = Options.FirstNumber * Options.SecondeNumber;
                    break;

                case "/":
                    Options.Result = (Options.SecondeNumber != 0)
                        ? Options.FirstNumber / Options.SecondeNumber
                        : 0;
                    break;
            }

            // FIX: replace accumulation bug (clean calculator behavior)
            TotalValue = Options.Result;

            textBox1.Text = TotalValue.ToString();

            Options.Result = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBoxResult.Clear();
            TotalValue = 0;
        }
    }
}