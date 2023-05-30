using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tattoo1
{
    public partial class CustomersListForm : Form
    {
        public CustomersListForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("base/text.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Сustomers main = new Сustomers();
            main.Show();
            this.Hide();
        }

        private void CustomersListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
