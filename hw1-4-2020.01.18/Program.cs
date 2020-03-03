using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_4_2020._01._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字:");
            string exp = Console.ReadLine();
            int x = int.Parse(exp);

            for (int i = x; i>0;i--)
            {

                for (int j = 0; j<=(x-i); j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
