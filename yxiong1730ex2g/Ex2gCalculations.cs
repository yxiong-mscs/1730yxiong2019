using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yxiong1730ex2g
{
    class Ex2gCalculations
    {
        public static string switch01(string customerType)
        {
            //1a) 'switch' with no default
            decimal discountpercent = -1m;
            
            switch (customerType) {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If01(string customerType)
        {
            //1b) Seperate 'if' statements
            decimal discountpercent = -1m;

            if (customerType == "R")
                discountpercent = .1m;
            if (customerType == "C")
                discountpercent = .2m;

            return discountpercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            //1c) if elseif
            decimal discountpercent = -1m;

            if (customerType == "R")
                discountpercent = .1m;
            else if (customerType == "C")
                discountpercent = .2m;

            return discountpercent.ToString("0.0");
        }
        public static string NestedIf01(string customerType)
        {
            //1d) Nested if-else
            decimal discountpercent = -1m;

            if (customerType == "R")
            {
                discountpercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountpercent = .2m;
                }
            }

            return discountpercent.ToString("0.0");
        }
        public static string switchDefault01(string customerType)
        {
            //1e) 'switch' with default
            decimal discountpercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;
                default:
                    discountpercent = .0m;
                    break;
            }
            return discountpercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            //1f) Seperate 'if' statements
            decimal discountpercent = -1m;

            if (customerType == "R")
                discountpercent = .1m;
            if (customerType == "C")
                discountpercent = .2m;
            if (customerType != "R")
                discountpercent = .0m;
            if (customerType != "C")
                discountpercent = .0m;

            return discountpercent.ToString("0.0");
        }
    }
}
