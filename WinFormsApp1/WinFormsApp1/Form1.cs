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

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Crear un formulario
            Form form = new Form();

            // Crear un campo de texto
            TextBox textBox = new TextBox();
            textBox.Location = new Point(10, 10);
            textBox.Size = new Size(100, 20);

            // Crear un botón
            Button button = new Button();
            button.Location = new Point(120, 10);
            button.Size = new Size(20, 20);
            button.Text = "2";

            // Agregar un evento al botón para que imprima el número 2 en el campo de texto al hacer clic
            button.Click += (sender, e) =>
            {
                textBox.Text = "2";
            };

            // Agregar el campo de texto y el botón al formulario
            form.Controls.Add(textBox);
            form.Controls.Add(button);

            // Mostrar el formulario
            form.ShowDialog();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ComprobarBTN_Click(object sender, EventArgs e)
        {

        }
    }
}