using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_3_2020._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入輸入一串以逗號分隔的字串:");
            string exp1 = Console.ReadLine();
            string[] exp = exp1.Split(',');
            for (int i = exp.Length-1; i >= 0; i--)
            {
                
                Console.Write(exp[i]);
                if (i > 0)
                {
                    Console.Write(",");
                }
                
            }
            //string y="";
            /*
            Array.Reverse(exp);
            
            //Console.WriteLine(exp[1]);
            for (int i = 0; i < j ; i  ++)
            {
                string z= exp[i];
                y = y +","+ z;
                //Console.Write($"{y} ");
            }
            //Console.WriteLine(y);
            string u = y.Remove(0, 1);
            Console.WriteLine(u);
            */
            //var u=string.Join("," + y);
            //Console.WriteLine(x[3]);
            Console.ReadLine();
        }
    }
}
