using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
                MessageBox.Show("Ati selectat serialul You");
            if (rb2.Checked)
                MessageBox.Show("Ati selectat serialul Wednesday");
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void rb2_Click(object sender, EventArgs e)
        {

        }
    }
}
