using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculationMachine
{
    public partial class Form1 : Form
    {
        bool isComma = false;
        int pharantheses = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxScreen.Text))
            {
                string currentText = textBoxScreen.Text;

                if (currentText == "0")
                {
                    textBoxScreen.Text = "0";
                }
                else
                {
                    textBoxScreen.Text = currentText + "0";
                }
            }
            else
            {
                textBoxScreen.Text = "0";
            }


            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0") 
            {
                textBoxScreen.Text = "1";
            }
            else
            {
                textBoxScreen.Text = currentText + "1";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "2";
            }
            else
            {
                textBoxScreen.Text = currentText + "2";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "3";
            }
            else
            {
                textBoxScreen.Text = currentText + "3";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "4";
            }
            else
            {
                textBoxScreen.Text = currentText + "4";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "5";
            }
            else
            {
                textBoxScreen.Text = currentText + "5";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "6";
            }
            else
            {
                textBoxScreen.Text = currentText + "6";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "7";
            }
            else
            {
                textBoxScreen.Text = currentText + "7";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "8";
            }
            else
            {
                textBoxScreen.Text = currentText + "8";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            string currentText = textBoxScreen.Text;

            if (currentText == "0")
            {
                textBoxScreen.Text = "9";
            }
            else
            {
                textBoxScreen.Text = currentText + "9";
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonErase_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text.Length > 0)
            {
                textBoxScreen.Text = textBoxScreen.Text.Remove(textBoxScreen.Text.Length - 1);
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxScreen.Text = "";
            isComma = false;
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {
                textBoxScreen.Text = "0.";
                isComma = true;
            }
            else
            {
                if (text[text.Length - 1] != '*' && text[text.Length - 1] != '/' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && text[text.Length - 1] != '.' && isComma==false && text[text.Length - 1] != '(' && text[text.Length - 1] != ')')
                {
                    textBoxScreen.Text += ".";
                    isComma = true;
                }
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {

            }
            else if (text[text.Length - 1] != '*' && text[text.Length - 1] != '/' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && text[text.Length - 1] != '.' && text[text.Length - 1] != '(')
            {
                textBoxScreen.Text += "*";
                isComma = false;
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {
                
            }
            else if (text[text.Length - 1] != '*' && text[text.Length - 1] != '/' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && text[text.Length - 1] != '.')
            {
                textBoxScreen.Text += "-";
                isComma = false;
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {

            }
            else if (text[text.Length - 1] != '*' && text[text.Length - 1] != '/' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && text[text.Length - 1] != '.')
            {
                textBoxScreen.Text += "/";
                isComma = false;
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {

            }
            else if (text[text.Length - 1] != '*' && text[text.Length - 1] != '/' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && text[text.Length - 1] != '.' && text[text.Length - 1] != '(')
            {
                textBoxScreen.Text += "+";
                isComma = false;
            }

            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }



        private void buttonParanthesisOpen_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {
                textBoxScreen.Text = "(";
            }
            else if (text[text.Length - 1] != '.' && text[text.Length - 1] != ')' && text[text.Length - 1] != '0' && text[text.Length - 1] != '1' && text[text.Length - 1] != '2' && text[text.Length - 1] != '3' && text[text.Length - 1] != '4' && text[text.Length - 1] != '5' && text[text.Length - 1] != '6' && text[text.Length - 1] != '7' && text[text.Length - 1] != '8' && text[text.Length - 1] != '9')
            {
                textBoxScreen.Text += "(";
                pharantheses++;
                isComma = false;
            }

            
            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }

        private void buttonPharanthesisClose_Click(object sender, EventArgs e)
        {
            string text = textBoxScreen.Text;

            if (string.IsNullOrEmpty(text))
            {
                
            }
            else if (text[text.Length - 1] != '.' && text[text.Length - 1] != '(' && text[text.Length - 1] != '/' && text[text.Length - 1] != '*' && text[text.Length - 1] != '-' && text[text.Length - 1] != '+' && pharantheses>0)
            {
                textBoxScreen.Text += ")";
                pharantheses--;
                isComma = false;
            }

            
            textBoxScreen.Select(textBoxScreen.Text.Length, 0);
            textBoxScreen.ScrollToCaret();
        }        
        
        private void buttonResult_Click(object sender, EventArgs e)
        {
            string expression = textBoxScreen.Text;

            List<char> operators = ExtractOperators(expression);
            List<string> terms = ExtractTerms(expression);

            double result = EvaluateExpression(operators, terms);

            textBoxScreen.Text = result.ToString();
        }

        static List<char> ExtractOperators(string expression)
        {
            List<char> operators = new List<char>();
            char[] operatorChars = { '+', '-', '*', '/' };

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (Array.Exists(operatorChars, op => op == currentChar))
                {
                    if (currentChar == '-' && i > 0 && expression[i - 1] == '(')
                    {
                        continue;
                    }
                    operators.Add(currentChar);
                }
            }

            return operators;
        }

        static List<string> ExtractTerms(string expression)
        {
            List<string> terms = new List<string>();
            char[] operatorChars = { '+', '-', '*', '/' };
            int startIndex = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (Array.Exists(operatorChars, op => op == currentChar))
                {
                    if (currentChar == '-' && i > 0 && expression[i - 1] == '(')
                    {
                        continue;
                    }

                    string term = expression.Substring(startIndex, i - startIndex).Trim();
                    if (!string.IsNullOrEmpty(term))
                    {
                        terms.Add(term);
                    }

                    startIndex = i + 1;
                }
            }

            string lastTerm = expression.Substring(startIndex).Trim();
            if (!string.IsNullOrEmpty(lastTerm))
            {
                terms.Add(lastTerm);
            }

            return terms;
        }


        static double EvaluateExpression(List<char> operators, List<string> terms)
        {
            for (int i = 0; i < terms.Count; i++)
            {
                if (terms[i].Contains("("))
                {
                    terms[i] = terms[i].Replace("(", "").Replace(")", "");
                }
            }

            for (int i = operators.Count - 1; i >= 0; i--)
            {
                if (operators[i] == '*' || operators[i] == '/')
                {
                    double left = Convert.ToDouble(terms[i]);
                    double right = Convert.ToDouble(terms[i + 1]);
                    double result;

                    if (operators[i] == '*')
                    {
                        result = left * right;
                    }
                    else
                    {
                        result = left / right;
                    }

                    terms[i] = result.ToString();
                    terms.RemoveAt(i + 1);
                    operators.RemoveAt(i);

                    Console.WriteLine(result);
                    Console.WriteLine(string.Join(", ", terms));
                    Console.WriteLine(string.Join(", ", operators));
                }
            }

            for (int i = operators.Count - 1; i >= 0; i--)
            {
                double left = Convert.ToDouble(terms[i]);
                double right = Convert.ToDouble(terms[i + 1]);
                double result;

                if (operators[i] == '+')
                {
                    result = left + right;
                }
                else
                {
                    result = left - right;
                }

                terms[i] = result.ToString();
                terms.RemoveAt(i + 1);
                operators.RemoveAt(i);

                Console.WriteLine(result);
                Console.WriteLine(string.Join(", ", terms));
                Console.WriteLine(string.Join(", ", operators));
            }

            return Convert.ToDouble(terms[0]);
        }
    }
}
