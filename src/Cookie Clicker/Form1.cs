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
        private GameViewModel viewModel;

        public Form1()
        {
            InitializeComponent();

            this.viewModel = new GameViewModel();

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewModel.increaseCounter();
            this.label1.Text = string.Format("Cookies: {0}", viewModel.CurrentCounter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (viewModel.CurrentCounter >= viewModel.ClickFirstUpgradeCost)
            {
                viewModel.increasingCounterIncreaser(GameViewModel.firstUpgradeIncreasingValue);
                viewModel.CurrentCounter = viewModel.CurrentCounter - viewModel.ClickFirstUpgradeCost;
                viewModel.ClickFirstUpgradeCost = viewModel.ClickFirstUpgradeCost + GameViewModel.firstUpgradeCostValue;
                this.label2.Text = "COST:" + viewModel.ClickFirstUpgradeCost;
                this.label3.Text = "Cookies per click: " + viewModel.CounterIncreaser;
                this.label1.Text = string.Format("Cookies: {0}", viewModel.CurrentCounter);
            }

            else
            {
                notEnoughToBuy();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (viewModel.CurrentCounter >= viewModel.ClickSecondUpgradeCost)
            {
                viewModel.increasingCounterIncreaser(GameViewModel.secondUpgradeIncreasingValue);
                viewModel.CurrentCounter = viewModel.CurrentCounter - viewModel.ClickSecondUpgradeCost;
                viewModel.ClickSecondUpgradeCost = viewModel.ClickSecondUpgradeCost + GameViewModel.secondUpgradeCostValue;
                this.label4.Text = "COST: " + viewModel.ClickSecondUpgradeCost;
                this.label3.Text = "Cookies per click: " + viewModel.CounterIncreaser;
                this.label1.Text = string.Format("Cookies: {0}", viewModel.CurrentCounter);
            }
            else
            {
                notEnoughToBuy();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (viewModel.CurrentCounter >= viewModel.TimerUpgradeCost)
            {
                viewModel.TimerCounterIncreaser = viewModel.TimerCounterIncreaser + GameViewModel.TimerCounterIncreaserValue;
                viewModel.CurrentCounter = viewModel.CurrentCounter - viewModel.TimerUpgradeCost;
                viewModel.TimerUpgradeCost = viewModel.TimerUpgradeCost + GameViewModel.upgradeTimerCostValue;
                this.costTimer.Text = "COST: " + viewModel.TimerUpgradeCost;
                this.label7.Text = "Cookies per second: " + viewModel.TimerCounterIncreaser;
                viewModel.IsTimerEnabled = true;
            }
            else
            {
                notEnoughToBuy();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (viewModel.IsTimerEnabled)
            {
                this.label1.Text = string.Format("Cookies: {0}", viewModel.CurrentCounter);
                viewModel.CurrentCounter += viewModel.TimerCounterIncreaser;
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
    }
}
