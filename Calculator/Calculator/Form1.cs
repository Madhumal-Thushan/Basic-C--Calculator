using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        String oparationperformed = "";
        bool isoparationperformed = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoparationperformed))
            textBox1.Clear();

            isoparationperformed = false; 
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
            {

                textBox1.Text = textBox1.Text + button.Text;
            } 
        }

        private void operater_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                button20.PerformClick();
                oparationperformed = button.Text;
                resultvalue = Double.Parse(textBox1.Text);
                label1.Text = resultvalue + "" + oparationperformed;
                isoparationperformed = true;


            }
            else
            {


                oparationperformed = button.Text;
                resultvalue = Double.Parse(textBox1.Text);
                label1.Text = resultvalue + "" + oparationperformed;
                isoparationperformed = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
          
    }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultvalue = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch(oparationperformed)
            {
                case "+":
                    textBox1.Text = (resultvalue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultvalue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultvalue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultvalue / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            resultvalue = Double.Parse(textBox1.Text);
            label1.Text = "";
        }
    }
    }
