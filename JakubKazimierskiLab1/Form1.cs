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
        int micro;

        #endregion


        public Form1()
        {
            InitializeComponent();

            micro = seconds = minutes = hours = 0;
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


        #region Timer system of work

        /// <summary>
        /// Method which makes timer run on visible effect
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //method of timer work

            micro++;
            if (micro > 9)
            {
                seconds++;
                micro = 0;
            }
            if ( seconds > 59 )
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 59 )
            {

                hours++;
                minutes = 0;
            }

            HoursTable.Text = appendZero(hours);
            MinutesTable.Text = appendZero(minutes);
            SecondsTable.Text = appendZero(seconds);
            HunSecondsTable.Text = appendZeroAfter(micro);
        }

        #endregion

        #region Buttons of Timer

        /// <summary>
        /// Methods of timer start, and stop, and also running
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            //start timer
            timer1.Start();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {   //stop timer but not reset
            timer1.Stop();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            //stop timer and reset
            timer1.Stop();
            micro = seconds = minutes = hours = 0;
            HoursTable.Text = appendZero(hours);
            MinutesTable.Text = appendZero(minutes);
            SecondsTable.Text = appendZero(seconds);
            HunSecondsTable.Text = appendZeroAfter(micro);

        }
        #endregion

        #region Helper methods
        /// <summary>
        /// method to make output like 00:00:00:00 not like 0:0:0:0
        /// </summary>
        /// <param name="str">The event sender</param>
        /// <returns>The even argument</returns>
        private string appendZero(double str)
        {
            if (str <= 9)
            {
                return "0" + str;
            }
            else
            {
                return str.ToString();
            }

        }
        private string appendZeroAfter(double str)
        {
         
                return   str + "0" ;
                       
        }

        #endregion


    }
}
