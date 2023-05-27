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

namespace tattoo1
{
    public partial class Сustomers : Form
    {

        public Сustomers()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Сustomers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter date = new StreamWriter("base/text.txt");
            date.WriteLine(textBox1.Text, '\n');
            date.WriteLine(textBox2.Text, '\n');
            date.WriteLine(textBox3.Text, '\n');
            date.WriteLine(textBox4.Text, '\n');
            date.Close();
            if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox3.Text.Equals("")) || (textBox4.Text.Equals("")))
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Клиент зарегистрирован", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Сustomers main = new Сustomers();
                main.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomersListForm main = new CustomersListForm();
            main.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
