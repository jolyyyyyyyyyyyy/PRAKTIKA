﻿using System;
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
    public partial class DesignsListForm : Form
    {
        public DesignsListForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Designs main = new Designs();
            main.Show();
            this.Hide();
        }

        private void DesignsListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
