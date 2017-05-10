using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation
{
    class TaxArithmetic
    {
        public static string Tax1Count(string complaintPrice)
        {
            double complaintPriceDigit = Convert.ToDouble(complaintPrice);
            return (complaintPriceDigit * 5 / 100).ToString();
        }
        
        public static string Tax2Count(string baseValue, string complaintPrice)
        {
            double baseValueDigit = Convert.ToDouble(baseValue);
            double complaintPriceDigit = Convert.ToDouble(complaintPrice);
            double limit1 = baseValueDigit * 100;
            double limit2 = baseValueDigit * 1000;
            double limit3 = baseValueDigit * 10000;
            double count1 = baseValueDigit * 25;
            double count2 = complaintPriceDigit * 5 / 100;
            double count3 = limit2 * 5 / 100;
            double count4 = (limit3 - limit2) * 3 / 100;
            if (complaintPriceDigit < limit1)
            {
                return (baseValueDigit * 25).ToString();
            }
            else if (complaintPriceDigit >= limit1 && complaintPriceDigit < limit2)
            {
                if (count1 > count2)
                {
                    return count1.ToString();
                }
                else
                {
                    return count2.ToString();
                }
            }
            else if (complaintPriceDigit >= limit2 && complaintPriceDigit < limit3)
            {                
                double restTax = (complaintPriceDigit - limit2) * 3 / 100;
                return (count3 + restTax).ToString();
            }
            else
            {                
                double restTax = count3 + count4;
                double currentTax = complaintPriceDigit * 1 / 100;
                if (restTax > currentTax)
                {
                    return restTax.ToString();
                }
                else
                {
                    return currentTax.ToString();
                }
            }
        }

        public static string Tax3Count(string baseValue, string complaintPrice)
        {
            //try
            //{
                double baseValueDigit = Convert.ToDouble(baseValue);
                double complaintPriceDigit = Convert.ToDouble(complaintPrice);
                double limit1 = baseValueDigit * 100;
                double limit2 = baseValueDigit * 300;
                if (complaintPriceDigit < limit1)
                {
                    return (baseValueDigit * 2).ToString();
                }
                else if (complaintPriceDigit >= limit1 && complaintPriceDigit < limit2)
                {
                    return (baseValueDigit * 5).ToString();
                }
                else
                {
                    return (baseValueDigit * 7).ToString();
                }
            }
            //catch (FormatException Ex)
            //{
                
            //}
        //}
    }
}