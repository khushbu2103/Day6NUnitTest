using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6NUnitTest
{
    internal class VendingMachine
    {
        public static void NoteDenomination()
        {
            Console.WriteLine("please enter total amout of currency");
            int totalCurrency = Convert.ToInt32(Console.ReadLine());
            int amount = totalCurrency;
            int totalNoOfNotes = 0;
            int[] noteDenomination = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noOfNotes = new int[noteDenomination.Length];
            Console.WriteLine("Currency denominations available are : ");
            foreach (int denomination in noteDenomination)
            {
                Console.Write(denomination + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < noteDenomination.Length; i++)
            {
                noOfNotes[i] = amount / noteDenomination[i];
                amount = amount % noteDenomination[i];
                Console.WriteLine(" number of {0} rupees notes are required {1}", noteDenomination[i], noOfNotes[i]);
                totalNoOfNotes += noOfNotes[i];
            }
            Console.WriteLine("total number of notes: {0}", totalNoOfNotes);
            Console.ReadLine();
           
        }
    
    }
}
