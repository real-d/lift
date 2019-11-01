using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 src = new Form2();
            src.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 src = new Form3();
            src.Show();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form4 src = new Form4();
            src.Show();
        }
    }
}
