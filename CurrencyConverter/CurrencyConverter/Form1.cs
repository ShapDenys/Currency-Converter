using CurrencyExchange;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private Exchange exchange;

        public Form1()
        {
            InitializeComponent();
            exchange = new Exchange();

            comboBoxInputCurrency.BindingContext = new BindingContext();
            comboBoxOutputCurrency.BindingContext = new BindingContext();

            comboBoxInputCurrency.DataSource = exchange.currencies;
            comboBoxInputCurrency.DisplayMember = "Name";
            comboBoxInputCurrency.ValueMember = "Code";

            comboBoxOutputCurrency.DataSource = exchange.currencies;
            comboBoxOutputCurrency.DisplayMember = "Name";
            comboBoxOutputCurrency.ValueMember = "Code";

        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            if (!double.TryParse(InputTextBox.Text, out double amount))
            {
                InputTextBox.BackColor = Color.Red;
                InputTextBox.ForeColor = Color.White;
                OutputTextBox.Text = "Invalid input :(";
                return;
            }

            InputTextBox.BackColor = Color.White;
            InputTextBox.ForeColor = Color.Black;
            OutputTextBox.Text = string.Empty;

            if (comboBoxInputCurrency.SelectedItem == null || comboBoxOutputCurrency.SelectedItem == null)
            {
                OutputTextBox.Text = "Select both input and output currencies :)";
                return;
            }

            try
            {
                Currency inputCurrency = (Currency)comboBoxInputCurrency.SelectedItem;
                Currency outputCurrency = (Currency)comboBoxOutputCurrency.SelectedItem;

                double amountInPLN;

                if (inputCurrency.Code == "PLN")
                {
                    amountInPLN = amount;
                }
                else
                {
                    amountInPLN = exchange.ToPLN(amount, inputCurrency) * 0.98;
                }

                double convertedAmount;

                if (outputCurrency.Code == "PLN")
                {
                    convertedAmount = amountInPLN;
                }
                else
                {
                    convertedAmount = amountInPLN / (outputCurrency.Rate * 1.02);
                }

                OutputTextBox.Text = $"{convertedAmount:F2} {outputCurrency.Code}";
            }
            catch (Exception ex)
            {
                OutputTextBox.Text = ex.Message;
            }
        }
    }
}
