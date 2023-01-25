namespace Calculator
{
    public partial class Form1 : Form
    {
        public class Calculator
        {
            public double firstNumber;
            public double secondNumber;
            public string symbol;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            
            calculator.firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            calculator.symbol = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            calculator.firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            calculator.symbol = "-";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            calculator.firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            calculator.symbol = "*";
        }

        private void buttonDivid_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();

            calculator.firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            calculator.symbol = "/";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
    }
}