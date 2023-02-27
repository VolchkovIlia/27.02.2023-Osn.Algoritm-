using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._02._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.BackColor= Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Green;
        }
    }
}
