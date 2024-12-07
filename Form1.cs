namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        int num1;
        int num2;
        String option;
        int result;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button3.Text;
        }

       
       

        private void button2_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + button10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textbox.Text);
            textbox.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textbox.Text);
            textbox.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textbox.Text);
            textbox.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textbox.Text);
            textbox.Clear();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textbox.Text);
            if (option == "+") 
                result = num1 + num2;

            if (option == "-") 
                    result = num1 - num2;

            if (option == "*")
                    
                        result = num1*num2;
            if (option == "/")
                result = num1/num2;


            textbox.Text = result + "";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textbox.Clear();
            result = 0;
            num2 = 0;
            num1 = 0;
        }

    }
}
