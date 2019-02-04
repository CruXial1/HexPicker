using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HexPicker
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        List<string> numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> code = new List<string>();

            int index = rng.Next(numbers.Count);

            var randomHEX = numbers.Shuffle().Take(6);

            foreach (var item in randomHEX)
            {
                code.Add(item);
            }

            string output = String.Join("", code.ToArray());

            int argb = Int32.Parse(output.Replace("#", ""), System.Globalization.NumberStyles.HexNumber);
            Color myColor = Color.FromArgb(argb);

            textBox1.Text = $"#{output}";

            textBox1.ForeColor = myColor;

            textBox2.ForeColor = myColor;

            Converter.Convert(output, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Visible = false;
            textBox2.Visible = false;

            label1.Visible = false;
            label2.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
