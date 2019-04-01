/*
 * Grading ID: M5477
 * Lab: 8
 * Due Date: Mar 31 2019
 * Course Section: 01
 * Description: Example of using pre/post conditions in methods.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Lab8 : Form
    {
        public Lab8()
        {
            InitializeComponent();
        }

        // Runs when the calculate button is clicked
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double future, // The future amount of money we want
                apy;       // The annual interest rate
            int years;     // Number of years we'll wait to cash out

            if (double.TryParse(futureInput.Text, out future) && 
                double.TryParse(apyInput.Text, out apy) && 
                int.TryParse(yearInput.Text, out years))
            {
                presentReport.Text = CalculatePresentValue(future, apy, years).ToString("C");
            }
        }

        /* 
         * Precondition: Future value, interest rate, years allocated
         * Postcondition: Returns the investment needed to reach goal
         */
        private double CalculatePresentValue(double future, double apy, int years)
        {
            return future / Math.Pow((1 + apy), years);
        }
    }
}
