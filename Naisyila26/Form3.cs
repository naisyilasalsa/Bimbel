﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naisyila26
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.ShowDialog();
        }
    }
}
