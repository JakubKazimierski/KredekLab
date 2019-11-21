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
        /// <summary>
        /// Simple timer
        /// </summary>

        #region Variables of time

        int seconds;
        int minutes;
        int hours;

        #endregion


        public Form1()
        {
            InitializeComponent();
        }


        #region Info Mehods

        /// <summary>
        /// Methods which output is message dialog with info aboout program
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void label1_Click(object sender, EventArgs e)
        {
            //message about author
            MessageBox.Show("In this table is author name.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //message about program
            MessageBox.Show("This program is simple timer, which can change colors");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {   //message about program
            MessageBox.Show("This program is simple timer, which can change colors");
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
