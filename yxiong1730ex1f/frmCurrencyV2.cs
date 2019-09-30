using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex1f
{
    public partial class frmCurrencyV2 : Form
    {
        public frmCurrencyV2()
        {
            InitializeComponent();
        }

        private void FrmCurrencyV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtRate.Text = "0.686649";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtRate.Text = "0.686649";
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnBrazil_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtRate.Text = "0.25";
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnCanada.BackgroundImage = picCanada.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtRate.Text = "0.76";
            lblCurrency.Text = btnCanada.Text + ": ";
            txtCurrency.Focus();
        }

        private void BtnMexico_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnMexico.BackgroundImage = picMexico.Image;
            txtRate.Text = "0.0512327";
            lblCurrency.Text = btnMexico.Text + ": ";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollar.Text =
                (Convert.ToDecimal(txtCurrency.Text) *
                Convert.ToDecimal(txtRate.Text)).ToString("0.00");
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text =
                (Convert.ToDecimal(txtTotalUSD.Text) + 
                Convert.ToDecimal(txtUSDollar.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtTotalUSD.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnMexico.BackgroundImage = picMexicoDim.Image;
            txtRate.Text = "0.686649";
            txtUSDollar.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
            lblEquation.ResetText();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
