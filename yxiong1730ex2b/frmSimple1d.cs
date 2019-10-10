using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex2b
{
    public partial class frmSimple1d : Form
    {
        public frmSimple1d()
        {
            InitializeComponent();
        }
        private void Calculate(object sender, EventArgs e)
        {
            decimal amountbrazilian = Convert.ToDecimal(txtAmountBrazilian.Text);
            decimal ratebrazilian = 0.686649m;
            decimal usdbrazilian = amountbrazilian * ratebrazilian;
            txtUSDBrazilian.Text = usdbrazilian.ToString("0.00");

            decimal amountcanadian = Convert.ToDecimal(txtAmountCanadian.Text);
            decimal ratecanadian = 0.686649m;
            decimal usdcanadian = amountcanadian * ratecanadian;
            txtUSDCanadian.Text = usdcanadian.ToString("0.00");

            decimal amountaustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateaustralia = 0.686649m;
            decimal usdaustralia = amountaustralia * rateaustralia;
            txtUSDAustralia.Text = usdaustralia.ToString("0.00");

            decimal amountmexico = Convert.ToDecimal(txtAmountMexico.Text);
            decimal ratemexico = 0.0512327m;
            decimal usdmexico = amountmexico * ratemexico;
            txtUSDMexico.Text = usdmexico.ToString("0.00");

            decimal totalusd = usdaustralia + usdbrazilian + usdcanadian + usdmexico;
            txtTotalUSD.Text = totalusd.ToString("0.00");
        }
    }
}
