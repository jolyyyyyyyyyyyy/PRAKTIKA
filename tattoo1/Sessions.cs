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
    public partial class Sessions : Form
    {
        public Sessions()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter date = new StreamWriter("base/text.txt");
            date.WriteLine(textBox1.Text, '\n');
            date.WriteLine(maskedTextBox1.Text, '\n');
            date.WriteLine(comboBox1.Text, '\n');
            date.Close();
            if ((textBox1.Text.Equals("")) || (maskedTextBox1.Text.Equals("")))
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Сеанс добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Sessions main = new Sessions();
                main.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionListForm main = new SessionListForm();
            main.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
