using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6NUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the NUnit Test Programs");
            Console.WriteLine("please choose any program");
            Console.WriteLine("1.Note Denomination\n" +
                "2.Day of week\n" +
                "3.Temerature Calculation\n" +
                "4.Monthly Payment\n" +
                "5.Binary Number\n" +
                "6.Swap Nibbles");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("please enter total amout of currency");
                        VendingMachine.NoteDenomination();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the day in the date:");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the month in the date:");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the year in the date:");
                        int y = Convert.ToInt32(Console.ReadLine());
                       // Util.dayOfWeek(d, m, y);
                        Console.WriteLine("day of the week is: {0}", Util.dayOfWeek(d, m, y));
                        break;
                    }
                case 3:
                    {
                        double c, f;
                        Console.WriteLine("please enter temperature in celsius and you will get out put in fahrenheit");
                        c = Convert.ToDouble(Console.ReadLine());
                        f = 32 + 1.8 * c;
                        Console.WriteLine("temperature in fahrenheit is: {0}", f);
                        Console.WriteLine("please enter temperature in fahrenheit and you will get out put in celsius");
                        f = Convert.ToDouble(Console.ReadLine());
                        c = (f - 32) * (5.0 / 9.0);
                        Console.WriteLine("temperature in celsius is: {0}", c);

                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("please enter a year");
                        double Y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter principal loan amount");
                        double P = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter percent intrest compound");
                        double R = Convert.ToInt32(Console.ReadLine());
                        Util.monthlyPayment(P, Y, R);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("please enter any number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        string binary = Util.toBinary(num);

                        Console.WriteLine("binary representation of {0} is: {1}", num, binary);
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Binary.SwapNibbles();
                        break;
                    }
                default:
                    Console.WriteLine("Incorrect input, program ends here");
                    break;
            }
            
            
        }
    }
}
