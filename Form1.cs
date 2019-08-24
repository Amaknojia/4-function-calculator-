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

        string input = string.Empty;     //String storing user input
        string operand1 = string.Empty;  //String storing first operand
        string operand2 = string.Empty;  //String sotring second operand
        char Operation;                  //char for operation
        double result = 0.0;             //calculated result

        private String calculatedNumber;     // Stores numbers in string form
        private Boolean dot = false;         // Flag: to control when a dot can be placed in a number
        
    
    public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LblDisplay.Focus();
        }


        private void BtnZero_Click(object sender, EventArgs e)  //adds 0 to string
        {
            this.LblDisplay.Text = "";
            input += "0";
            this.LblDisplay.Text += input;
        }

        private void BtnOne_Click(object sender, EventArgs e)   //adds 1 to string
        {
            {
                this.LblDisplay.Text = "";
                input += "1";
                this.LblDisplay.Text += input;
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)   //adds 2 to string
        {
            this.LblDisplay.Text = "";
            input += "2";
            this.LblDisplay.Text += input;
        }

        private void BtnThree_Click(object sender, EventArgs e)   //adds 3 to string
        {
            this.LblDisplay.Text = "";
            input += "3";
            this.LblDisplay.Text += input;
        }

        private void BtnFour_Click(object sender, EventArgs e)   //adds 4 to string
        {
            this.LblDisplay.Text = "";
            input += "4";
            this.LblDisplay.Text += input;
        }
        private void BtnFive_Click(object sender, EventArgs e)   //adds 5 to string
        {
            this.LblDisplay.Text = "";
            input += "5";
            this.LblDisplay.Text += input;
        }
            private void BtnSix_Click(object sender, EventArgs e)   //adds 6 to string
        {
                this.LblDisplay.Text = "";
                input += "6";
                this.LblDisplay.Text += input;
            }

        private void BtnSeven_Click(object sender, EventArgs e)   //adds 7 to string
        {
                this.LblDisplay.Text = "";
                input += "7";
                this.LblDisplay.Text += input;
            }

        private void BtnEight_Click(object sender, EventArgs e)   //adds 8 to string
        {
                this.LblDisplay.Text = "";
                input += "8";
                this.LblDisplay.Text += input;
            }

        private void BtnNine_Click(object sender, EventArgs e)   //adds 9 to string
        {
                this.LblDisplay.Text = "";
                input += "9";
                this.LblDisplay.Text += input;
            }

        private void BtnDot_Click(object sender, EventArgs e)   //adds . to string
        {
                input += ".";
            }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

                operand1 = input;
                Operation = '+';
                input = string.Empty;

            }
        private void BtnSub_Click(object sender, EventArgs e)
        {

                operand1 = input;
                Operation = '-';
                input = string.Empty;
            }


        private void BtnDiv_Click(object sender, EventArgs e)
        {


                operand1 = input;
                Operation = '/';
                input = string.Empty;


            }
        private void Multiply_Click(object sender, EventArgs e)
        {

                operand1 = input;
                Operation = '*';
                input = string.Empty;
            }

        private void BtnEqt_Click(object sender, EventArgs e)
        {
                operand2 = input;
                double num1, num2;
                double.TryParse(operand1, out num1);
                double.TryParse(operand2, out num2);

                if (Operation == '+')
                {
                    result = num1 + num2;
                LblDisplay.Text = result.ToString();
                }

                else if (Operation == '-')
                {
                    result = num1 - num2;
                LblDisplay.Text = result.ToString();
                }

                else if (Operation == '*')
                {
                    result = num1 * num2;
                LblDisplay.Text = result.ToString();
                }

                else if (Operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    LblDisplay.Text = result.ToString();
                    }

                    else
                    {
                    LblDisplay.Text = "DIV/Zero!";
                    }
                }
            }
        private void Lb1Display_TextChanged(object sender, EventArgs e)
        {

        }
    

private void BtnClear_Click(object sender, EventArgs e) //resets the string to blank
        {

                this.LblDisplay.Text = "";
                this.input = string.Empty;
                this.operand1 = string.Empty;
                this.operand2 = string.Empty;
            }

              private void BtnBack_Click(object sender, EventArgs e)
        {
            // reset dot if removed. First make sure not empty
            if (!LblDisplay.Text.Equals(""))
            {
                //if most right char is a . (dot) then reset flag
                if ((LblDisplay.Text.ToString())[LblDisplay.Text.Length - 1] == '.')
                    dot = false;
                // go ahead and remove last char
                LblDisplay.Text = calculatedNumber = LblDisplay.Text.Remove(LblDisplay.Text.Length - 1);
            }
        }

        private void LblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

      
        private void Form1_keyDown(object sender, KeyEventArgs e) //keyboard inputs for the calculator
        {
            //keyboard number input via the number pad or keyboard numbers
            if (e.KeyCode.Equals(Keys.D0) || e.KeyCode.Equals(Keys.NumPad0))
            {
                BtnZero_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D1) || e.KeyCode.Equals(Keys.NumPad1))
            {
                BtnOne_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D2) || e.KeyCode.Equals(Keys.NumPad2))
            {
                BtnTwo_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D3) || e.KeyCode.Equals(Keys.NumPad3))
            {
                BtnThree_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D4) || e.KeyCode.Equals(Keys.NumPad4))
            {
                BtnFour_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D5) || e.KeyCode.Equals(Keys.NumPad5))
            {
                BtnFive_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D6) || e.KeyCode.Equals(Keys.NumPad6))
            {
                BtnSix_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D7) || e.KeyCode.Equals(Keys.NumPad7))
            {
                BtnSeven_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D8) || e.KeyCode.Equals(Keys.NumPad8))
            {
                BtnEight_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.D9) || e.KeyCode.Equals(Keys.NumPad9))
            {
                BtnNine_Click(sender, e);
            }

            if (e.KeyCode.Equals(Keys.Add) || e.KeyCode.Equals(Keys.Add))
            {
                BtnAdd_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.Subtract) || e.KeyCode.Equals(Keys.Subtract))
            {
                BtnSub_Click(sender, e);
            }

            if (e.KeyCode.Equals(Keys.Divide) || e.KeyCode.Equals(Keys.Divide))
            {
                BtnDiv_Click(sender, e);
            }

            if (e.KeyCode.Equals(Keys.Multiply) || e.KeyCode.Equals(Keys.Multiply))
            {
                Multiply_Click(sender, e);
            }

            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Enter))
            {
                BtnEqt_Click(sender, e);
            }
            if (e.KeyCode.Equals(Keys.Back) || e.KeyCode.Equals(Keys.Back))
            {
                BtnBack_Click(sender, e);
            } 
            if (e.KeyCode.Equals(Keys.Escape) || e.KeyCode.Equals(Keys.Escape))
            {
                BtnClear_Click(sender, e);
            }
            else if (e.KeyCode.Equals(Keys.OemPeriod) || e.KeyCode.Equals(Keys.OemPeriod))
            {
                BtnDot_Click(sender, e);
            }



        }
    }
}



