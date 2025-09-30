namespace CurrencyConverter
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
            InputTextBox = new TextBox();
            OutputTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            comboBoxInputCurrency = new ComboBox();
            comboBoxOutputCurrency = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(3, 183);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 0;
            InputTextBox.TextChanged += ConvertCurrency;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(401, 183);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(100, 23);
            OutputTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(OutputTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(InputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(comboBoxOutputCurrency, 1, 1);
            tableLayoutPanel1.Location = new Point(-2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(797, 450);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 5;
            label1.Text = "Input";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Output";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxInputCurrency);
            groupBox1.Location = new Point(3, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 129);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // comboBoxInputCurrency
            // 
            comboBoxInputCurrency.FormattingEnabled = true;
            comboBoxInputCurrency.Location = new Point(-3, 0);
            comboBoxInputCurrency.Name = "comboBoxInputCurrency";
            comboBoxInputCurrency.Size = new Size(121, 23);
            comboBoxInputCurrency.TabIndex = 8;
            // 
            // comboBoxOutputCurrency
            // 
            comboBoxOutputCurrency.FormattingEnabled = true;
            comboBoxOutputCurrency.Location = new Point(401, 48);
            comboBoxOutputCurrency.Name = "comboBoxOutputCurrency";
            comboBoxOutputCurrency.Size = new Size(121, 23);
            comboBoxOutputCurrency.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox InputTextBox;
        private TextBox OutputTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private ComboBox comboBoxInputCurrency;
        private ComboBox comboBoxOutputCurrency;
    }
}
