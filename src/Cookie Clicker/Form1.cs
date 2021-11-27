using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {

        private int counter = 0;
        private int costButton2 = 100, costButton3 = 250, costTimer1 = 2500;
        private int counterIncreaser = 1;
        private int counterIncreaserForSeconds = 0;
        private bool verifyPressedButton4 = false;
        //private System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;

            //setupTimer();
        }

        /*private void setupTimer()
        {
            timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(onTimerElapsed);
            timer.Start();
        }

        private void onTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("onTimerElapsed");
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            increaseCounter();
            this.label1.Text = string.Format("Cookies: {0}", counter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter >= costButton2)
            {
                increasingCounterIncreaser(1);
                counter = counter - costButton2;
                costButton2 = costButton2 + 100;
                this.label2.Text = "COST:" + costButton2;
                this.label3.Text = "Cookies per click: " + counterIncreaser;
                this.label1.Text = string.Format("Cookies: {0}", counter);
            }

            else
            {
                notEnoughToBuy();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (counter >= costButton3)
            {
                increasingCounterIncreaser(5);
                counter = counter - costButton3;
                costButton3 = costButton3 + 250;
                this.label4.Text = "COST: " + costButton3;
                this.label3.Text = "Cookies per click: " + counterIncreaser;
                this.label1.Text = string.Format("Cookies: {0}", counter);
            }
            else
            {
                notEnoughToBuy();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counter >= costTimer1)
            {
                counterIncreaserForSeconds = counterIncreaserForSeconds + 1;
                counter = counter - costTimer1;
                costTimer1 = costTimer1 + 2500;
                this.costTimer.Text = "COST: " + costTimer1;
                this.label7.Text = "Cookies per second: " + counterIncreaserForSeconds;
                verifyPressedButton4 = true;
            }
            else
            {
                notEnoughToBuy();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (verifyPressedButton4)
            {
                this.label1.Text = string.Format("Cookies: {0}", counter);
                counter = counter + counterIncreaserForSeconds;
            }
        }

        #region boilerplatecode

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void notEnoughToBuy()
        {
            MessageBox.Show("You don't have enough cookies", "YOU'RE BANKRUPT", MessageBoxButtons.OKCancel);
        }

        private void increaseCounter()
        {
            counter = counter + counterIncreaser;
        }

        private void increasingCounterIncreaser(int n)
        {
            counterIncreaser = counterIncreaser + n;
        }
    }
}
