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
    public partial class Calculator : Form
    {
        decimal input = 0;
        decimal result = 0;
        bool isDecimalPointUsed = false;
        string lastOperator = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void InputReset()
        {
            input = 0;
            isDecimalPointUsed = false;
            labelInput.Text = "0";
        }

        private void ResultReset()
        {
            labelResult.Text = "";
            result = 0;
            lastOperator = "";
        }

        private void buttonOprataion_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            try
            {


                switch (number.Text)
                {
                    case "+/-":
                        labelInput.Text = (decimal.Parse(labelInput.Text) * -1).ToString();
                        break;
                    case ".":
                        if (!isDecimalPointUsed)
                        {
                            labelInput.Text += ".";
                            isDecimalPointUsed = true;
                        }
                        break;

                    case "+":
                        CalculateResult();
                        lastOperator = "+";
                        labelResult.Text = result + " +";
                        InputReset();
                        break;
                    case "-":
                        CalculateResult();
                        lastOperator = "-";
                        labelResult.Text = result + " -";
                        InputReset();
                        break;
                    case "x":
                        CalculateResult();
                        lastOperator = "x";
                        labelResult.Text = result + " x";
                        InputReset();
                        break;
                    case "/":
                        CalculateResult();
                        lastOperator = "/";
                        labelResult.Text = result + " /";
                        InputReset();
                        break;
                    case "√x":
                        if (decimal.Parse(labelInput.Text) < 0) { throw new InvalidOperationException(); };
                        CalculateResult();
                        lastOperator = "";
                        labelResult.Text = "√(" + result + ") = " + (decimal)Math.Sqrt((double)result);
                        InputReset();
                        break;
                    case "^2":
                        CalculateResult();
                        lastOperator = "";
                        labelResult.Text = result + "^2 = " + (decimal)Math.Pow((double)result, 2);
                        InputReset();
                        break;
                    case "1/x":
                        CalculateResult();
                        lastOperator = "";
                        labelResult.Text = "1/" + result + " = " + (1 / result);
                        InputReset();
                        break;
                    case "%":
                        throw new NotImplementedException();
                    case "=":
                        CalculateResult();
                        lastOperator = "";
                        labelResult.Text = "= " + result;
                        InputReset();
                        break;
                    default:
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                labelResult.Text = "Error: Cannot devide by zero!";
            }
            catch (InvalidOperationException)
            {
                labelResult.Text = "Error: Invalid input or operation!";
            }
            catch (NotImplementedException)
            {
                labelResult.Text = "Error: Feature not implemented!";
            }
            catch (Exception)
            {
                labelResult.Text = "Unknow error!";
            }
        }

        private void CalculateResult()
        {
            input = decimal.Parse(labelInput.Text);
            switch (lastOperator)
            {
                case "":
                    result = input;
                    break;
                case "+":
                    result += input;
                    break;
                case "-":
                    result -= input;
                    break;
                case "x":
                    result *= input;
                    break;
                case "/":
                    result /= input;
                    break;
                default:
                    break;
            }
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            InputReset();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            InputReset();
            ResultReset();
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (labelInput.Text.Length > 1)
            {
                labelInput.Text = labelInput.Text.Remove(labelInput.Text.Length - 1);
            }
            else
            {
                labelInput.Text = "0";
            }
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            if (labelInput.Text == "0")
            {
                labelInput.Text = number.Text;
            }
            else
            {
                labelInput.Text += number.Text;
            }
        }
    }
}
