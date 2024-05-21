using System;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            Form13 Form13 = new Form13();
            Form13.ShowDialog();
        }
    }
}
