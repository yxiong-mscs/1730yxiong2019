using System;
using System.Windows.Forms;

namespace yxiong1730ex1d
{
    public partial class TextChanged : Form
    {
        public TextChanged()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AustraliaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text =
                (Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)).ToString("0.00");
        }

        private void CanadianTextChanged(object sender, EventArgs e)
        {
            txtUSDCanadian.Text =
                (Convert.ToDecimal(txtAmountCanadian.Text) * Convert.ToDecimal(txtRateCanadian.Text)).ToString("0.00");
        }

        private void MexicoTextChanged(object sender, EventArgs e)
        {
            txtUSDMexico.Text =
                (Convert.ToDecimal(txtAmountMexico.Text) * Convert.ToDecimal(txtRateMexico.Text)).ToString("0.00");
        }

        private void BrazilianTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazilian.Text =
                (Convert.ToDecimal(txtAmountBrazilian.Text) * Convert.ToDecimal(txtRateBrazilian.Text)).ToString("0.00");
        }

        private void USDTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtUSDBrazilian.Text) + Convert.ToDecimal(txtUSDCanadian.Text) + Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDMexico.Text)).ToString("0.00");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmountBrazilian.Text = "0.00";
            txtRateBrazilian.Text = "0.25";
            txtAmountCanadian.Text = "0.00";
            txtRateCanadian.Text = "0.76";
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.686649";
            txtAmountMexico.Text = "0.00";
            txtRateMexico.Text = "0.0512327";
        }
    }
}
