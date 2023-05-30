using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day6NUnitTest
{
    internal class Util
    {
        public static int dayOfWeek(int d, int m, int y)
        {
   
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0/ 12) % 7;
            return d0;
          
            //Console.ReadLine();
        }
        
        public static void monthlyPayment(double P, double Y ,double R)
        {

            double noOfMonths = 12 * Y;
            double ratePerMonth = R / (12 * 100);

            double monthlyPayment = (P * ratePerMonth) / (1 - (Math.Pow(1+ratePerMonth, -noOfMonths)));
            Console.WriteLine("Monthle Payments: {0}", monthlyPayment);
            Console.ReadLine();
        }

        public static string toBinary(int num)
        {
            int temp = num;
            string binary = "";
           while(temp != 0)
            {
                 binary = " " + temp % 2 + binary; 
                temp = temp / 2; 
            }

            return binary;

        }
      

    }
}
