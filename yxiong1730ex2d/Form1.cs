using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex2d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5aInput.Text = "2";
            textBox5bInput.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8aInput.Text = "1";
            textBox8bInput.Text = "2";
            textBox9Input.Text = "500";
            textBox10aInput.Text = "2";
            textBox10bInput.Text = "3";
        }

        private void BtnFail_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5aInput.Text = "2";
            textBox5bInput.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8aInput.Text = "1";
            textBox8bInput.Text = "1";
            textBox9Input.Text = "499";
            textBox10aInput.Text = "4";
            textBox10bInput.Text = "3";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultB.Text = "Pass";
            textBox2ResultB.Text = "Pass";
            textBox3ResultB.Text = "Pass";
            textBox4ResultB.Text = "Pass";
            textBox5ResultB.Text = "Pass";
            textBox6ResultB.Text = "Pass";
            textBox7ResultB.Text = "Pass";
            textBox8ResultB.Text = "Pass";
            textBox9ResultB.Text = "Pass";
            textBox10ResultB.Text = "Pass";

            if (textBox1Input.Text == "Frank") textBox1ResultA.Text = "Pass";
            if (textBox1Input.Text != "Frank") textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "") textBox2ResultA.Text = "Pass";
            if (textBox2Input.Text != "") textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Pass";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            if (textBox4Input.Text == "false") textBox4ResultA.Text = "Pass";
            if (textBox4Input.Text != "false") textBox4ResultB.Text = "Fail";

            decimal val5a = Convert.ToDecimal(textBox5aInput.Text);
            decimal val5b = Convert.ToDecimal(textBox5bInput.Text);
            if (val5a == val5b) textBox5ResultA.Text = "Pass";
            if (val5a != val5b) textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text != "Jones") textBox6ResultA.Text = "Pass";
            if (textBox6Input.Text == "Jones") textBox6ResultB.Text = "Fail";

            if (textBox7Input.Text == "1") textBox7ResultA.Text = "Pass";
            if (textBox7Input.Text != "1") textBox7ResultB.Text = "Fail";

            decimal val8a = Convert.ToDecimal(textBox8aInput.Text);
            decimal val8b = Convert.ToDecimal(textBox8bInput.Text);
            if (val8a < val8b) textBox8ResultA.Text = "Pass";
            if (val8a >= val8b) textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 == 500m) textBox9ResultA.Text = "Pass";
            if (val9 != 500m) textBox9ResultB.Text = "Fail";

            decimal val10a = Convert.ToDecimal(textBox10aInput.Text);
            decimal val10b = Convert.ToDecimal(textBox10bInput.Text);
            if (val10a <= val10b) textBox10ResultA.Text = "Pass";
            if (val10a > val10b) textBox10ResultB.Text = "Fail";
        }
    }
}
