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
    }
}