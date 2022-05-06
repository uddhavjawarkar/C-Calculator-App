namespace MyCalculator
{
    public partial class Calculatorform : Form
    {
        string op;
        string num1;
        bool k = false;
        public Calculatorform()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = textBox1.Text;
            textBox1.Text = "+";


        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
            {
                textBox1.Text = "";
                k = false;
            }
            textBox1.Text = textBox1.Text + "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || k == true)
                {
                    textBox1.Text = "";
                    k = false;
                }
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = textBox1.Text;
            textBox1.Text = "-";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = textBox1.Text;
            textBox1.Text = "*";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = textBox1.Text;
            textBox1.Text = "/";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    {
                        double s = double.Parse(num1) + double.Parse(textBox1.Text);
                        textBox1.Text = s.ToString();
                        k = true;
                        break;
                    }
                case "-":
                    {
                        double s = double.Parse(num1) - double.Parse(textBox1.Text);
                        textBox1.Text = s.ToString();
                        k = true;
                        break;
                    }
                case "*":
                    {
                        double s = double.Parse(num1) * double.Parse(textBox1.Text);
                        textBox1.Text = s.ToString();
                        k = true;
                        break;
                    }
                case "/":
                    {
                        double s = double.Parse(num1) / double.Parse(textBox1.Text);
                        textBox1.Text = s.ToString();
                        k = true;
                        break;
                    }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
            double s = 0;

        }
    }
}