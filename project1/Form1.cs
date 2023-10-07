namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1 = Convert.ToInt32(textBox1.Text);
            int say2 = Convert.ToInt32(textBox2.Text);


            if (comboBox2.Text == "+")
            {
                int c = say1 + say2;
                label3.Text = c.ToString();
            }
            else if (comboBox2.Text == "-")
            {
                int c = say1 - say2;
                label3.Text = c.ToString();
            }
            else if (comboBox2.Text == "*")
            {
                int c = say1 * say2;
                label3.Text = c.ToString();
            }
            else if (comboBox2.Text == "/")
            {
                int c = say1 / say2;
                label3.Text = c.ToString();
            }
            else
            {
                label3.Text = "dogru deyil";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}