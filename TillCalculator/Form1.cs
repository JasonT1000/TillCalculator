using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TillCalculator
{
    public partial class Form1 : Form
    {
        double total = 0.00;
        // Counts
        int onehundredDollarCount = 0;
        int fiftyDollarCount = 0;
        int twentyDollarCount = 0;
        int tenDollarCount = 0;
        int fiveDollarCount = 0;
        int oneDollarCount = 0;
        int twoDollarCount = 0;
        int fiftyCentCount = 0;
        int twentyCentCount = 0;
        int tenCentCount = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updateTotal()
        {
            total = 0;
            total += (onehundredDollarCount * 100);
            total += (fiftyDollarCount * 50);
            total += (twentyDollarCount * 20);
            total += (tenDollarCount * 10);
            total += (fiveDollarCount * 5);
            total += oneDollarCount;
            total += (twoDollarCount * 2);
            total += Math.Round((fiftyCentCount * 0.5), 1);
            total += Math.Round((twentyCentCount * 0.2), 1);
            total += Math.Round((tenCentCount * 0.1), 1);

            labelTotal.Text = total.ToString("F1");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Counts
            onehundredDollarCount = 0;
            fiftyDollarCount = 0;
            twentyDollarCount = 0;
            tenDollarCount = 0;
            fiveDollarCount = 0;
            oneDollarCount = 0;
            twoDollarCount = 0;
            fiftyCentCount = 0;
            twentyCentCount = 0;
            tenCentCount = 0;

            // Inputs
            numericUpDownHundredDollar.Value = 0;
            numericUpDownFiftyDollar.Value = 0;
            numericUpDownTwentyDollar.Value = 0;
            numericUpDownTenDollar.Value = 0;
            numericUpDownFiveDollar.Value = 0;
            numericUpDownTwoDollar.Value = 0;
            numericUpDownOneDollar.Value = 0;
            numericUpDownFiftyCent.Value = 0;
            numericUpDownTwentyCent.Value = 0;
            numericUpDownTenCent.Value = 0;

            total = 0;
            labelTotal.Text = total.ToString();
        }
        // ------------------------------ 100 DOLLARS ----------------------------
        private void numericUpDownHundredDollar_Leave(object sender, EventArgs e)
        {
            onehundredDollarCount = int.Parse(numericUpDownHundredDollar.Value.ToString());
            updateTotal();
        }
        private void numericUpDownHundredDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                onehundredDollarCount = int.Parse(numericUpDownHundredDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDown_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        // ------------------------------ 50 DOLLARS ----------------------------
        private void numericUpDownFiftyDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fiftyDollarCount = int.Parse(numericUpDownFiftyDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownFiftyDollar_Leave(object sender, EventArgs e)
        {
            fiftyDollarCount = int.Parse(numericUpDownFiftyDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 20 DOLLARS ----------------------------
        private void numericUpDownTwentyDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                twentyDollarCount = int.Parse(numericUpDownTwentyDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownTwentyDollar_Leave(object sender, EventArgs e)
        {
            twentyDollarCount = int.Parse(numericUpDownTwentyDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 10 DOLLARS ----------------------------
        private void numericUpDownTenDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tenDollarCount = int.Parse(numericUpDownTenDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownTenDollar_Leave(object sender, EventArgs e)
        {
            tenDollarCount = int.Parse(numericUpDownTenDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 5 DOLLARS ----------------------------
        private void numericUpDownFiveDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fiveDollarCount = int.Parse(numericUpDownFiveDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownFiveDollar_Leave(object sender, EventArgs e)
        {
            fiveDollarCount = int.Parse(numericUpDownFiveDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 2 DOLLARS ----------------------------
        private void numericUpDownTwoDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                twoDollarCount = int.Parse(numericUpDownTwoDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownTwoDollar_Leave(object sender, EventArgs e)
        {
            twoDollarCount = int.Parse(numericUpDownTwoDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 1 DOLLARS ----------------------------
        private void numericUpDownOneDollar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                oneDollarCount = int.Parse(numericUpDownOneDollar.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownOneDollar_Leave(object sender, EventArgs e)
        {
            oneDollarCount = int.Parse(numericUpDownOneDollar.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 50 CENTS ----------------------------
        private void numericUpDownFiftyCent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fiftyCentCount = int.Parse(numericUpDownFiftyCent.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownFiftyCent_Leave(object sender, EventArgs e)
        {
            fiftyCentCount = int.Parse(numericUpDownFiftyCent.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 20 CENTS ----------------------------
        private void numericUpDownTwentyCent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                twentyCentCount = int.Parse(numericUpDownTwentyCent.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownTwentyCent_Leave(object sender, EventArgs e)
        {
            twentyCentCount = int.Parse(numericUpDownTwentyCent.Value.ToString());
            updateTotal();
        }

        // ------------------------------ 10 CENTS ----------------------------
        private void numericUpDownTenCent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tenCentCount = int.Parse(numericUpDownTenCent.Value.ToString());
                updateTotal();
            }
        }

        private void numericUpDownTenCent_Leave(object sender, EventArgs e)
        {
            tenCentCount = int.Parse(numericUpDownTenCent.Value.ToString());
            updateTotal();
        }
    }
}
