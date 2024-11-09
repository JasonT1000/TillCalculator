using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Versioning;
using System;

[assembly: SupportedOSPlatform("windows")]


namespace TillCalculator
{
    public partial class Form1 : Form
    {
        double total = 0.00; // Money total
        int[] moneyCounts = new int[10]; // Money counts

        public Form1()
        {
            InitializeComponent();
        }

        // Updates the total with the current values stored in the
        // count array, then displays the total to the user.
        private void updateTotal()
        {
            total = 0;

            total += (moneyCounts[0] * 100); // 100 Dollar notes
            total += (moneyCounts[1] * 50); // 50 Dollar notes
            total += (moneyCounts[2] * 20); // 20 Dollar notes
            total += (moneyCounts[3] * 10); // 10 Dollar notes
            total += (moneyCounts[4] * 5); // 5 Dollar notes
            total += (moneyCounts[5] * 2); // 2 Dollar coins
            total += moneyCounts[6]; // 1 Dollar coins
            total += Math.Round((moneyCounts[7] * 0.5), 2); // 50 Cent coins
            total += Math.Round((moneyCounts[8] * 0.2), 2); // 20 Cent coins
            total += Math.Round((moneyCounts[9] * 0.1), 2); // 10 Cent coins

            labelTotal.Text = "$ " + total.ToString("F2");
        }

        // Selects all content inside a numeric input
        private void numericUpDown_SelectAllContents(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        // Validate input to stop decimals being input
        private void numericUpDownValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, e.g., backspace
            if (char.IsControl(e.KeyChar)) return;

            // Allow only digits
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Clears all input elements, variables and labels to 0
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Counts
            for (int i = 0; i < moneyCounts.Length; i++)
            {
                moneyCounts[i] = 0;
            }

            // Input Elements
            foreach (Control control in groupBox1.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                { 
                    numericUpDown.Value = 0;
                }
            }

            total = 0;
            labelTotal.Text = "$ " + total.ToString("F2");
        }

        // Gets the value from the input element we interacted with
        // then gets the index of the input element and sets the count
        // variable associated with that name, then updates and displays
        // the new total.
        private void CalculateNewTotal(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Tag != null)
            {
                int index = int.Parse(((NumericUpDown)sender).Tag.ToString());
                int count = int.Parse(((NumericUpDown)sender).Value.ToString());

                moneyCounts[index] = count;
            }

            updateTotal();
        }

        private void numericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateNewTotal(sender, e);
            }
        }
    }
}
