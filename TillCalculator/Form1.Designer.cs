namespace TillCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label9 = new Label();
            numericUpDownTenCent = new NumericUpDown();
            label10 = new Label();
            numericUpDownTwentyCent = new NumericUpDown();
            label5 = new Label();
            numericUpDownFiftyCent = new NumericUpDown();
            label6 = new Label();
            numericUpDownOneDollar = new NumericUpDown();
            label7 = new Label();
            numericUpDownTwoDollar = new NumericUpDown();
            label8 = new Label();
            numericUpDownFiveDollar = new NumericUpDown();
            label3 = new Label();
            numericUpDownTenDollar = new NumericUpDown();
            label4 = new Label();
            numericUpDownTwentyDollar = new NumericUpDown();
            label2 = new Label();
            numericUpDownFiftyDollar = new NumericUpDown();
            label1 = new Label();
            numericUpDownHundredDollar = new NumericUpDown();
            buttonClear = new Button();
            labelTotal = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwentyCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiftyCent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOneDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwoDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiveDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwentyDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiftyDollar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHundredDollar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numericUpDownTenCent);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(numericUpDownTwentyCent);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDownFiftyCent);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownOneDollar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDownTwoDollar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numericUpDownFiveDollar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDownTenDollar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownTwentyDollar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDownFiftyDollar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDownHundredDollar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 298);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Number of Notes / Coins";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(402, 247);
            label9.Name = "label9";
            label9.Size = new Size(103, 25);
            label9.TabIndex = 19;
            label9.Text = "¢ 10 Cents:";
            // 
            // numericUpDownTenCent
            // 
            numericUpDownTenCent.Font = new Font("Segoe UI", 12F);
            numericUpDownTenCent.Location = new Point(523, 242);
            numericUpDownTenCent.Name = "numericUpDownTenCent";
            numericUpDownTenCent.Size = new Size(141, 34);
            numericUpDownTenCent.TabIndex = 18;
            numericUpDownTenCent.TextAlign = HorizontalAlignment.Right;
            numericUpDownTenCent.Enter += numericUpDown_Enter;
            numericUpDownTenCent.KeyUp += numericUpDownTenCent_KeyUp;
            numericUpDownTenCent.Leave += numericUpDownTenCent_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(86, 247);
            label10.Name = "label10";
            label10.Size = new Size(103, 25);
            label10.TabIndex = 17;
            label10.Text = "¢ 20 Cents:";
            // 
            // numericUpDownTwentyCent
            // 
            numericUpDownTwentyCent.Font = new Font("Segoe UI", 12F);
            numericUpDownTwentyCent.Location = new Point(207, 242);
            numericUpDownTwentyCent.Name = "numericUpDownTwentyCent";
            numericUpDownTwentyCent.Size = new Size(141, 34);
            numericUpDownTwentyCent.TabIndex = 16;
            numericUpDownTwentyCent.TextAlign = HorizontalAlignment.Right;
            numericUpDownTwentyCent.Enter += numericUpDown_Enter;
            numericUpDownTwentyCent.KeyUp += numericUpDownTwentyCent_KeyUp;
            numericUpDownTwentyCent.Leave += numericUpDownTwentyCent_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(402, 196);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 15;
            label5.Text = "¢ 50 Cents:";
            // 
            // numericUpDownFiftyCent
            // 
            numericUpDownFiftyCent.Font = new Font("Segoe UI", 12F);
            numericUpDownFiftyCent.Location = new Point(523, 191);
            numericUpDownFiftyCent.Name = "numericUpDownFiftyCent";
            numericUpDownFiftyCent.Size = new Size(141, 34);
            numericUpDownFiftyCent.TabIndex = 14;
            numericUpDownFiftyCent.TextAlign = HorizontalAlignment.Right;
            numericUpDownFiftyCent.Enter += numericUpDown_Enter;
            numericUpDownFiftyCent.KeyUp += numericUpDownFiftyCent_KeyUp;
            numericUpDownFiftyCent.Leave += numericUpDownFiftyCent_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(86, 196);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 13;
            label6.Text = "$ 1 Coins:";
            // 
            // numericUpDownOneDollar
            // 
            numericUpDownOneDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownOneDollar.Location = new Point(207, 191);
            numericUpDownOneDollar.Name = "numericUpDownOneDollar";
            numericUpDownOneDollar.Size = new Size(141, 34);
            numericUpDownOneDollar.TabIndex = 12;
            numericUpDownOneDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownOneDollar.Enter += numericUpDown_Enter;
            numericUpDownOneDollar.KeyUp += numericUpDownOneDollar_KeyUp;
            numericUpDownOneDollar.Leave += numericUpDownOneDollar_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(402, 145);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 11;
            label7.Text = "$ 2 Coins:";
            // 
            // numericUpDownTwoDollar
            // 
            numericUpDownTwoDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownTwoDollar.Location = new Point(523, 140);
            numericUpDownTwoDollar.Name = "numericUpDownTwoDollar";
            numericUpDownTwoDollar.Size = new Size(141, 34);
            numericUpDownTwoDollar.TabIndex = 10;
            numericUpDownTwoDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownTwoDollar.Enter += numericUpDown_Enter;
            numericUpDownTwoDollar.KeyUp += numericUpDownTwoDollar_KeyUp;
            numericUpDownTwoDollar.Leave += numericUpDownTwoDollar_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(86, 145);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 9;
            label8.Text = "$ 5 Notes:";
            // 
            // numericUpDownFiveDollar
            // 
            numericUpDownFiveDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownFiveDollar.Location = new Point(207, 140);
            numericUpDownFiveDollar.Name = "numericUpDownFiveDollar";
            numericUpDownFiveDollar.Size = new Size(141, 34);
            numericUpDownFiveDollar.TabIndex = 8;
            numericUpDownFiveDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownFiveDollar.Enter += numericUpDown_Enter;
            numericUpDownFiveDollar.KeyUp += numericUpDownFiveDollar_KeyUp;
            numericUpDownFiveDollar.Leave += numericUpDownFiveDollar_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(402, 93);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 7;
            label3.Text = "$ 10 Notes:";
            // 
            // numericUpDownTenDollar
            // 
            numericUpDownTenDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownTenDollar.Location = new Point(523, 88);
            numericUpDownTenDollar.Name = "numericUpDownTenDollar";
            numericUpDownTenDollar.Size = new Size(141, 34);
            numericUpDownTenDollar.TabIndex = 6;
            numericUpDownTenDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownTenDollar.Enter += numericUpDown_Enter;
            numericUpDownTenDollar.KeyUp += numericUpDownTenDollar_KeyUp;
            numericUpDownTenDollar.Leave += numericUpDownTenDollar_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(86, 93);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 5;
            label4.Text = "$ 20 Notes:";
            // 
            // numericUpDownTwentyDollar
            // 
            numericUpDownTwentyDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownTwentyDollar.Location = new Point(207, 88);
            numericUpDownTwentyDollar.Name = "numericUpDownTwentyDollar";
            numericUpDownTwentyDollar.Size = new Size(141, 34);
            numericUpDownTwentyDollar.TabIndex = 4;
            numericUpDownTwentyDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownTwentyDollar.Enter += numericUpDown_Enter;
            numericUpDownTwentyDollar.KeyUp += numericUpDownTwentyDollar_KeyUp;
            numericUpDownTwentyDollar.Leave += numericUpDownTwentyDollar_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(402, 42);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 3;
            label2.Text = "$ 50 Notes:";
            // 
            // numericUpDownFiftyDollar
            // 
            numericUpDownFiftyDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownFiftyDollar.Location = new Point(523, 37);
            numericUpDownFiftyDollar.Name = "numericUpDownFiftyDollar";
            numericUpDownFiftyDollar.Size = new Size(141, 34);
            numericUpDownFiftyDollar.TabIndex = 2;
            numericUpDownFiftyDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownFiftyDollar.Enter += numericUpDown_Enter;
            numericUpDownFiftyDollar.KeyUp += numericUpDownFiftyDollar_KeyUp;
            numericUpDownFiftyDollar.Leave += numericUpDownFiftyDollar_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(86, 42);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 1;
            label1.Text = "$ 100 Notes:";
            // 
            // numericUpDownHundredDollar
            // 
            numericUpDownHundredDollar.Font = new Font("Segoe UI", 12F);
            numericUpDownHundredDollar.Location = new Point(207, 37);
            numericUpDownHundredDollar.Name = "numericUpDownHundredDollar";
            numericUpDownHundredDollar.Size = new Size(141, 34);
            numericUpDownHundredDollar.TabIndex = 0;
            numericUpDownHundredDollar.TextAlign = HorizontalAlignment.Right;
            numericUpDownHundredDollar.Enter += numericUpDown_Enter;
            numericUpDownHundredDollar.KeyUp += numericUpDownHundredDollar_KeyUp;
            numericUpDownHundredDollar.Leave += numericUpDownHundredDollar_Leave;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 12F);
            buttonClear.Location = new Point(332, 347);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(92, 47);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 16F);
            labelTotal.Location = new Point(608, 357);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(32, 37);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotal);
            Controls.Add(buttonClear);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwentyCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiftyCent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOneDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwoDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiveDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTenDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTwentyDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiftyDollar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHundredDollar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numericUpDownHundredDollar;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownFiftyDollar;
        private Label label5;
        private NumericUpDown numericUpDownFiftyCent;
        private Label label6;
        private NumericUpDown numericUpDownOneDollar;
        private Label label7;
        private NumericUpDown numericUpDownTwoDollar;
        private Label label8;
        private NumericUpDown numericUpDownFiveDollar;
        private Label label3;
        private NumericUpDown numericUpDownTenDollar;
        private Label label4;
        private NumericUpDown numericUpDownTwentyDollar;
        private Label label9;
        private NumericUpDown numericUpDownTenCent;
        private Label label10;
        private NumericUpDown numericUpDownTwentyCent;
        private Button buttonClear;
        private Label labelTotal;
    }
}
