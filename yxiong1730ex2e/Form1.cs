using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yxiong1730ex2e
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            //#01
            result01TextBox.Text = "";
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            //#02
            result02TextBox.Text = "";
            int timeInService = Convert.ToInt32(input02TextBox.Text);
            //result02TextBox.Text = (timeInService <= 4 || timeInService >= 12).ToString();
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            //#03
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            bool isVaild = Convert.ToBoolean(input03TextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);
            //#03
            int counter = Convert.ToInt32(input03bTextBox.Text);
            //result03TextBox.Text = (isVaild == true && counter++ < years).ToString();
            result03TextBox.Text = (LogicalOperations.q03(isVaild, years, counter)).ToString();
            result03bTextBox.Text = counter.ToString();
            //#04
            result04TextBox.Text = "";
            result04bTextBox.Text = "";
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result04TextBox.Text = (isVaild == true & counter++ < years).ToString();
            result04TextBox.Text = (LogicalOperations.q04(isVaild, years, counter)).ToString();
            result04bTextBox.Text = counter.ToString();
            //#05
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result05TextBox.Text = (isVaild == true || counter++ < years).ToString();
            result05TextBox.Text = (LogicalOperations.q05(isVaild, years, counter)).ToString();
            result05bTextBox.Text = counter.ToString();
            //#06
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            counter = Convert.ToInt32(input03bTextBox.Text);
            //result06TextBox.Text = (isVaild == true | counter++ < years).ToString();
            result06TextBox.Text = (
                LogicalOperations.q06(isVaild, years, counter)
                ).ToString();
            result06bTextBox.Text = counter.ToString();
            //#07
            result07TextBox.Text = "";
            DateTime startdate = Convert.ToDateTime(input07TextBox.Text);
            DateTime expirationdate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isVaild = Convert.ToBoolean(input07dTextBox.Text);
            //result07TextBox.Text = (date > startdate && date < expirationdate || isVaild == true).ToString();
            result07TextBox.Text = (
                LogicalOperations.q07(startdate, expirationdate, date, isVaild)
                ).ToString();
            //#08
            result08TextBox.Text = "";
            decimal thisYTD = Convert.ToDecimal(input08TextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            //result08TextBox.Text = (
            //    ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
            //    ).ToString();
            result08TextBox.Text = (
                LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)
                ).ToString();
            //#09
            result09TextBox.Text = "";
            counter = Convert.ToInt32(input09TextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            //result09TextBox.Text = (!(counter++ >= years)).ToString();
            result09TextBox.Text = (LogicalOperations.q09(counter, years)).ToString();
            result09bTextBox.Text = counter.ToString();
            result09bTextBox.Text = counter.ToString();
            //#10
            int a = Convert.ToInt32(input10TextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            //result10TextBox.Text = (a > b && b < c || c < d).ToString();
            result10TextBox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();
            //#11
            bool member = Convert.ToBoolean(input11TextBox.Text);
            decimal price = Convert.ToDecimal(input11bTextBox.Text);
            float weight = Convert.ToSingle(input11cTextBox.Text);
            result11TextBox.Text = (LogicalOperations.q11(member, price, weight)).ToString();
            //#12
            member = Convert.ToBoolean(input12TextBox.Text);
            price = Convert.ToDecimal(input12bTextBox.Text);
            weight = Convert.ToSingle(input12cTextBox.Text);
            result12TextBox.Text = (LogicalOperations.q12(member, price, weight)).ToString();
            //#13
            string state = Convert.ToString(input13TextBox.Text);
            string item = Convert.ToString(input13bTextBox.Text);
            result13TextBox.Text = (LogicalOperations.q13(state, item)).ToString();

        }
    }
}
