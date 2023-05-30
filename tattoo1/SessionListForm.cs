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
    public partial class SessionListForm : Form
    {
        public SessionListForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("base/text.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sessions main = new Sessions();
            main.Show();
            this.Hide();
        }

        private void SessionListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
