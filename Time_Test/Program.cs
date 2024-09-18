using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sec = 8926548;
            int min = sec / 60;
            int hours = min / 60;
            int day = hours / 24;
            int month = day / 30;
            int season = month % 4;

            string[] seasons =
            {
                "Spring", "Summer", "Fall", "Winter"
            };

            Console.WriteLine(sec);
            Console.WriteLine((hours % 24) + ":" + (min % 60));
            Console.WriteLine();
            Console.WriteLine(day % 30);
            Console.WriteLine(season);
            

                int hour24 = 13; // Example input
                int hour12 = hour24 % 12;

                // Handle special case for midnight and noon
                if (hour12 == 0)
                {
                    hour12 = 12; // Convert 0 to 12 for 12 AM or 12 PM
                }

                // Determine AM or PM
                string period = hour24 >= 12 ? "PM" : "AM";

                Console.WriteLine($"Time of day: {hour12} {period}");
                Console.ReadLine();
        }
    }
}
