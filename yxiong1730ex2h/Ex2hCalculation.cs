using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yxiong1730ex2h
{
    public class Ex2hCalculation
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            return result;
        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strdateA, string strdateB)
        {
            string result = "Invalid input";
            TimeSpan date;
            try
            {
                DateTime dateA = DateTime.Parse(strdateA); 
                DateTime dateB = DateTime.Parse(strdateB);
                date = dateA.Subtract(dateB);
                result = date.TotalDays.ToString() + " days";
            }
            catch { }
            return result;
        }

        public static string DateCalc10(string strdateA, string strdateB)
        {
            string result = "Invalid input";
            TimeSpan date;
            try
            {
                DateTime dateA = DateTime.Parse(strdateA);
                DateTime dateB = DateTime.Parse(strdateB);
                date = dateA.Subtract(dateB);
                if (dateA <= dateB)
                {
                    result = "On Time";
                }
                else
                {
                    result = date.TotalDays.ToString() + " days past due";
                }
            }
            catch { }
            return result;
        }

        public static string StringCalc01(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
            }
            else return "Invalid input";
            return s;

        }
        public static string StringCalc02(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
            }
            else return "Invalid input";
            return s;
        }
        public static string StringCalc03(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Substring(2, 4).ToUpper();
            }
            else return "Invalid input";
            return s;
        }
        public static string StringCalc04(string s)
        {
            s = s.Trim();
            char pad = '*';
            if (s.Length > 1)
            {
                s = s.PadLeft(10, pad);
            }
            else return "Invalid input";
            return s;
        }
        public static string StringCalc05(string s)
        {
            s = s.Trim();
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace("-", "");
                s = s.Replace(" ", "");
            return s;
        }
        public static string StringCalc06(string s)
        {
            s = s.Trim();
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace("-", "");
            s = s.Replace(" ", "");
            if (s.Length == 7)
            {
                s = s.Insert(3, ".");
            }
            else if (s.Length == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
            }
            else return "Invalid input";
            return s;
        }
        public static string StringCalc07(string s)
        {
            s = s.Trim();
            s = s.Substring(4, 7).ToLower();
            string strP = "pioneer";
            if (s.Contains(strP))
            {
                s = "Found";
            }
            else return "Not Found";
            return s;
        }
        public static string StringCalc08(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.IndexOf(",").ToString();
                s = s.Substring(13);
            }
            else return "Invaild Input";
            return s;
        }
        public static string StringCalc09(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.LastIndexOf(" ").ToString();
                s = s.Substring(13);
            }
            else return "Invaild Input";
            return s;
        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder sb = new StringBuilder(100);

            return ""; 
        }
    }
}