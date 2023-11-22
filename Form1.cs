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
    public partial class Form1 : Form
    {
        int n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
            n1 = n2 = n3 = 0;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            n1 = 1;
            if (n1 * n2 * n3 == 1) button1.Enabled = true;
            Form2 bu1 = new Form2();
            bu1.Show();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            n3 = 1;
            if (n1 * n2 * n3 == 1) button1.Enabled = true;
            Form4 bu3 = new Form4();
            bu3.Show();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            n2 = 1;
            if(n1*n2*n3==1) button1.Enabled = true;
            Form3 bu2 = new Form3();
            bu2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 bu4 = new Form5();
            bu4.Show();
        }
    }
}
