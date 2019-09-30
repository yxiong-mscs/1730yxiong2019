using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex1e
{
    public partial class AverageTestScore : Form
    {
        public AverageTestScore()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverageScore.Text =
                ((Convert.ToDecimal (txtScore1.Text) + Convert.ToDecimal(txtScore2.Text) + Convert.ToDecimal(txtScore3.Text))
                / 3).ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtScore1.Text = ("0");
            txtScore2.Text = ("0");
            txtScore3.Text = ("0");
            txtAverageScore.Text = ("");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
