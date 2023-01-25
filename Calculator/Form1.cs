namespace Calculator
{
    public partial class Form1 : Form
    {
        public class Calculator
        {
            public string number;
            public string numbertwo;
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
            bool buttonOneWasClicked = true;

            if (buttonOneWasClicked == true)
            {
                calculator.number = "1";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonTwoWasClicked = true;

            if (buttonTwoWasClicked == true)
            {
                calculator.number = "2";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonThreeWasClicked = true;

            if (buttonThreeWasClicked == true)
            {
                calculator.number = "3";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonFourWasClicked = true;

            if (buttonFourWasClicked == true)
            {
                calculator.number = "4";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonFiveWasClicked = true;

            if (buttonFiveWasClicked == true)
            {
                calculator.number = "5";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonSixWasClicked = true;

            if (buttonSixWasClicked == true)
            {
                calculator.number = "6";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonSevenWasClicked = true;

            if (buttonSevenWasClicked == true)
            {
                calculator.number = "7";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonEightWasClicked = true;

            if (buttonEightWasClicked == true)
            {
                calculator.number = "8";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonNineWasClicked = true;

            if (buttonNineWasClicked == true)
            {
                calculator.number = "9";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonZeroWasClicked = true;

            if (buttonZeroWasClicked == true)
            {
                calculator.number = "0";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonPlusWasClicked = true;

            if (buttonPlusWasClicked == true)
            {
                calculator.symbol = "+";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonMinusWasClicked = true;

            if (buttonMinusWasClicked == true)
            {
                calculator.symbol = "-";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonMultiWasClicked = true;

            if (buttonMultiWasClicked == true)
            {
                calculator.symbol = "*";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonDivid_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonDividWasClicked = true;

            if (buttonDividWasClicked == true)
            {
                calculator.symbol = "/";
                textBox1.Text = calculator.number;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            bool buttonEqualWasClicked = true;

            if (buttonEqualWasClicked == true)
            {
                calculator.symbol = "=";
                textBox1.Text = calculator.number;
            }
        }
    }
}