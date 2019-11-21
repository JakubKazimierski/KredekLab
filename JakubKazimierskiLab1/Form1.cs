using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubKazimierskiLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this table is author name.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is simple timer, which can change colors");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("This program is simple timer, which can change colors");
        }
    }
}
