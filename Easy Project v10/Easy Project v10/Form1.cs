using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Project_v10
{

    //------------------------------------------------------------------------
    /* This project was made by Anar Abasov
     *  Basic Calculator with GUI (Windows Forms): Expand the basic calculator project to include a graphical user interface (GUI) using Windows Forms.*/
    //------------------------------------------------------------------------

    public partial class Form1 : Form
    {
        double FirstNumber;
        string operation;
        bool isNewNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void HandleNumberButtonClick(string digit)
        {
            if (textBox1.Text == "0" || isNewNumber)
            {
                textBox1.Text = digit;
                isNewNumber = false;
            }
            else
            {
                textBox1.Text += digit;
            }
        }

        private void HandleOperatorClick(string operatorText)
        {
            if (!isNewNumber)
            {
                FirstNumber = Convert.ToDouble(textBox1.Text);
                operation = operatorText;
                isNewNumber = true;
            }
        }


        private void btnOne_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick("0");
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            HandleNumberButtonClick(".");
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            HandleOperatorClick("/");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            HandleOperatorClick("*");
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            HandleOperatorClick("-");
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            HandleOperatorClick("+");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!isNewNumber)
            {
                double secondNum = Convert.ToDouble(textBox1.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = FirstNumber + secondNum;
                        break;
                    case "-":
                        result = FirstNumber - secondNum;
                        break;
                    case "*":
                        result = FirstNumber * secondNum;
                        break;
                    case "/":
                        if (secondNum == 0)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            return;
                        }
                        result = FirstNumber / secondNum;
                        break;
                }

                textBox1.Text = result.ToString();
                isNewNumber = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        { 
            if(!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != "0")
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double currentNumber = Convert.ToDouble(textBox1.Text);
                double percentage = currentNumber / 100.0;
                textBox1.Text = percentage.ToString();
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            FirstNumber = 0;
            operation = null;
        }

        private void btnDevideByX_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(textBox1.Text);
            double devideX = 1 / currentNumber;

            textBox1.Text = devideX.ToString();
        }

        private void btnxSquare_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(textBox1.Text);
            double result = currentNumber * currentNumber;
            textBox1.Text = result.ToString();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            double currentNumber = Convert.ToDouble(textBox1.Text);
            if(currentNumber >= 0)
            {
                currentNumber = Math.Sqrt(currentNumber);
                textBox1.Text = currentNumber.ToString();
            }
            else
            {
                MessageBox.Show("Cannot calculate square root of a negative number");
            }

        }
    }
}
