namespace Forms_I_307_2
{
    partial class frmCalculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnComma = new Button();
            btnPercent = new Button();
            btnEquals = new Button();
            btnMultiply = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 24);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Number_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 181);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Number_Click;
            // 
            // button3
            // 
            button3.Location = new Point(124, 181);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Number_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 125);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Number_Click;
            // 
            // button5
            // 
            button5.Location = new Point(68, 125);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Number_Click;
            // 
            // button6
            // 
            button6.Location = new Point(124, 125);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Number_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 69);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Number_Click;
            // 
            // button8
            // 
            button8.Location = new Point(68, 69);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Number_Click;
            // 
            // button9
            // 
            button9.Location = new Point(124, 69);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Number_Click;
            // 
            // button10
            // 
            button10.Location = new Point(68, 237);
            button10.Name = "button10";
            button10.Size = new Size(50, 50);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Number_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(180, 125);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(50, 50);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(179, 237);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(180, 292);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnComma
            // 
            btnComma.Location = new Point(124, 237);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(50, 50);
            btnComma.TabIndex = 15;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btnPercent
            // 
            btnPercent.Location = new Point(12, 237);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(50, 50);
            btnPercent.TabIndex = 16;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(12, 293);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(162, 50);
            btnEquals.TabIndex = 17;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(179, 181);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(50, 50);
            btnMultiply.TabIndex = 18;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(179, 69);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(50, 50);
            btnClear.TabIndex = 19;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 354);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btnEquals);
            Controls.Add(btnPercent);
            Controls.Add(btnComma);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnComma;
        private Button btnPercent;
        private Button btnEquals;
        private Button btnMultiply;
        private Button btnClear;
    }
}