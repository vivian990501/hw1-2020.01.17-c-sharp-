using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_1_2020._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字:");
            string i = Console.ReadLine();
            int j = int.Parse(i);
            //int i =int.Parse(Console.ReadLine())
            if ((j % 2) == 0)
            {
                Console.WriteLine("偶數");
            }
            else
            {
                Console.WriteLine("奇數");
            }
            Console.ReadLine();
        }
    }
}
