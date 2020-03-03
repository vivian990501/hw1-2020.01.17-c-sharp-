using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_5_2020._01._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個中華民國年份:");
            string cy = Console.ReadLine();
            int ty = int.Parse(cy);
            int y = ty + 1911;
            if (DateTime.IsLeapYear(y))
            {
                Console.WriteLine($"{ty}年為閏年");
            }
            else
            {
                Console.WriteLine($"{ty}年非閏年");
            }

            //if (((y % 4) == 0) && ((y % 100) != 0))
            //{
            //    Console.WriteLine($"{ty}年為閏年");
            //}
            //else if ((y % 400) == 0 && ((y % 100) != 0))
            //{
            //    Console.WriteLine($"{ty}年為閏年");
            //}
            //else 
            //{
            //    Console.WriteLine($"{ty}年非閏年");
            //}
            Console.ReadLine();
        }
    }
}
