namespace tattoo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else if (textBox1.Text != "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text == "admin" && textBox2.Text != "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (textBox1.Text != "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}