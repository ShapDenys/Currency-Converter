namespace CurrencyConverter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            labelInput = new Label();
            labelOutput = new Label();
            InputTextBox = new TextBox();
            OutputTextBox = new TextBox();
            comboBoxInputCurrency = new ComboBox();
            comboBoxOutputCurrency = new ComboBox();

            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();

            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Padding = new Padding(15);
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            // 
            // labelInput
            // 
            labelInput.Text = "Input";
            labelInput.Dock = DockStyle.Fill;
            labelInput.TextAlign = ContentAlignment.MiddleCenter;
            labelInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // labelOutput
            // 
            labelOutput.Text = "Output";
            labelOutput.Dock = DockStyle.Fill;
            labelOutput.TextAlign = ContentAlignment.MiddleCenter;
            labelOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // 
            // comboBoxInputCurrency
            // 
            comboBoxInputCurrency.Dock = DockStyle.Fill;
            comboBoxInputCurrency.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // comboBoxOutputCurrency
            // 
            comboBoxOutputCurrency.Dock = DockStyle.Fill;
            comboBoxOutputCurrency.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // InputTextBox
            // 
            InputTextBox.Dock = DockStyle.Fill;
            InputTextBox.TextAlign = HorizontalAlignment.Right;
            InputTextBox.TextChanged += ConvertCurrency;

            // 
            // OutputTextBox
            // 
            OutputTextBox.Dock = DockStyle.Fill;
            OutputTextBox.ReadOnly = true;
            OutputTextBox.TextAlign = HorizontalAlignment.Right;

            // 
            // Add controls to layout
            // 
            tableLayoutPanel1.Controls.Add(labelInput, 0, 0);
            tableLayoutPanel1.Controls.Add(labelOutput, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBoxInputCurrency, 0, 1);
            tableLayoutPanel1.Controls.Add(comboBoxOutputCurrency, 1, 1);
            tableLayoutPanel1.Controls.Add(InputTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(OutputTextBox, 1, 2);

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 220);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Currency Converter";

            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelInput;
        private Label labelOutput;
        private TextBox InputTextBox;
        private TextBox OutputTextBox;
        private ComboBox comboBoxInputCurrency;
        private ComboBox comboBoxOutputCurrency;
    }
}
