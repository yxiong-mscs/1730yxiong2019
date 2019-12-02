using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex2g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //1a) 'switch' with no default
            resultSwitchTextBox.Text = Ex2gCalculations.switch01(input1aTextBox.Text);
            //1b) Seperate 'if' statements
            resultif01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);
            //1c) if elseif
            resultElseif01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);
            //1d) Nested if-else
            resultNestedifElseTextBox.Text = Ex2gCalculations.NestedIf01(input1aTextBox.Text);
            //1e) 'switch' with default
            resultswitchDefaultTextBox.Text = Ex2gCalculations.switchDefault01(input1aTextBox.Text);
            //1f) Seperate 'if' statements
            resultif02TextBox.Text = Ex2gCalculations.If02(input1aTextBox.Text);
        }
    }
}
