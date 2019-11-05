using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yxiong1730ex2e
{
        public class LogicalOperations
    {
        public static bool q01(decimal subtotal)
        {
            return subtotal >= 250 && subtotal < 500;
        }
        public static bool q02(int timeInService)
        {
            return timeInService <= 4 || timeInService >= 12;
        }
        public static bool q03(bool isVaild, int years, int counter)
        {
            return isVaild == true && counter++ < years;

        }
        public static bool q04(bool isVaild, int years, int counter)
        {
            return isVaild == true & counter++ < years;
        }
        public static bool q05(bool isVaild, int years, int counter)
        {
            return isVaild == true || counter++ < years;
        }
        public static bool q06(bool isVaild, int years, int counter)
        {
            return isVaild == true | counter++ < years;
        }
        public static bool q07(DateTime startdate, DateTime expirationdate, DateTime date, bool isVaild)
        {
            return date > startdate && date < expirationdate || isVaild == true;
        }
        public static bool q08(decimal thisYTD, decimal lastYTD, string empType, int startYear, int currentYear)
        {
            return ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear;
        }
        public static bool q09(int counter, int years)
        {
            return !(counter++ >= years);
        }
        public static bool q10(int a, int b, int c, int d)
        {
            return a > b && b < c || c < d;
        }
        public static bool q11(bool member, decimal price, float weight)
        {
            return (member == true | price > 25) | weight <= 1.0;
        }
        public static bool q12(bool member, decimal price, float weight)
        {
            return member != false | (price > 25 || weight < 1.0);
        }
        public static bool q13(string state, string item)
        {
            return state == "MN" && item == "Electronics" | item == "clothing" | item == "food";
        }
    }
}
