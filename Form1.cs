namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                int entero = Convert.ToInt16(enteroTXT.Text);
                ResultLB.Text = "si es un numero";
            }
            catch (Exception ex)
            {
                ResultLB.Text = "no es un numero";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "^";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            {
                enteroTXT.Text += "2";
            };


        }

        private void button14_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "8";
        }

        private void ComprobarBTN_Click(object sender, EventArgs e)
        {
            enteroTXT.Text = string.Empty;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "0";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enteroTXT.Text += "√";
        }
    }
}