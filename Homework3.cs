using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UW_Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
                                  
            Console.WriteLine();
            Console.Write("Please enter a number of seconds you would like converted into days, hours, minutes and seconds:  ");
            string stringTime = Console.ReadLine();
            
            int integerTime = int.Parse(stringTime);

            int integerHour = integerTime / 3600;
            integerTime = integerTime % 3600;
            int integerMinutes = integerTime/60;
            integerTime = integerTime % 60;
            int integerSeconds = integerTime;
            
            Console.WriteLine("hours: {0} , minutes: {1}, seconds: {2}", integerHour, integerMinutes, integerSeconds);
            Console.ReadKey();
        }
    }
}
