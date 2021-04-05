using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string operation = "";
        double firstNum, secondNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
               // The remove method removes a cerain character from an iterable object...first arg is the starting point, the second is the number of characters to be removed
            }
            if(txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e) ///the equals sign
            //when you click on this one, there is only the second number on the screen
        {
            secondNum = Convert.ToDouble(txtDisplay.Text);

            switch(operation)
            {
                case "+":
                    txtDisplay.Text = Convert.ToString(firstNum + secondNum);
                    break;
                case "-":
                    txtDisplay.Text = Convert.ToString(firstNum - secondNum);
                    break;
                case "*":
                    txtDisplay.Text = Convert.ToString(firstNum * secondNum);
                    break;
                case "/":
                    txtDisplay.Text = Convert.ToString(firstNum / secondNum);
                    break;
                default:
                    break;

            }
        }

        private void NumericValue(object sender, EventArgs e)
        {
            Button b = (Button)sender; ////creating an object that represents the event emitter....

            ///if the display has the number 0, empty the display as soon as you press the button
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            ///if the button is a point
            /////if the txtDisplay already contains a point, do nothing
            ////if it does not contain a point, just add a point to whatever is on the display
            if(b.Text == ".")
            {
                if(!txtDisplay.Text.Contains(".")) ///the contains method returns true when a string contains a certain substring
                {
                    ////if it does not contain a point, just add a point to whatever is on the display
                    txtDisplay.Text = txtDisplay.Text + ".";
                }
            }
            else ///when you press any of the rest of the numbers(not 0 or .), then it will add that number to what is already on the screen
            {
                txtDisplay.Text += b.Text;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            s = Convert.ToString(secondNum);
            f = Convert.ToString(firstNum);

            f = "";

            s = "";

        }

        private void Operation_Function(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            firstNum = Double.Parse(txtDisplay.Text);
            operation = b.Text;
            txtDisplay.Text = " ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {




            if(txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
