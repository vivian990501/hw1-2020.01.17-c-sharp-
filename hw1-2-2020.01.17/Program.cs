using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_2_2020._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入輸入一串以逗號分隔的整數數字字串:");
            string[] exp = Console.ReadLine().Split(',');
            int j = exp.Length;
            //int s;
            int[] t = new int[j];

            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            //Console.WriteLine($"{exp[1]} {exp[2]}");


            for (int k = 0; k < j; k++)
            {
                t[k] = int.Parse(exp[k]);
                //Console.WriteLine($"\nk={k}");
                //Console.WriteLine($"j={j}");
                //Console.WriteLine($"{exp[k]}");

            }
            Array.Sort(t);

            for (int v = 0; v < j; v++)
            {

                if ((t[v] % 2) == 0)
                {
                    c++;
                }
                else
                {
                    d++;
                }

            }
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            int[] p = new int[c];
            int[] q = new int[d];
            string[] a = new string[c];
            string[] b = new string[d];

            //Console.Write("偶數:");
            for (int k = 0; k < j; k++)
            {
                if ((t[k] % 2) == 0)
                {
                    p[e] = t[k];
                    //Console.Write($"{p[e]}");
                    e++;
                }
                else
                {
                    q[f] = t[k];
                    f++;
                }

            }
            //Console.WriteLine($"\np長度 {p.Length} ");
            //Console.WriteLine();
            //Console.Write("奇數:");
            //for (int k = 0; k < j; k++)
            //{
                //if ((t[k] % 2) != 0)
                //{
                    //q[f] = t[k];
                    // Console.Write($"{q[f]}");
                    //f++;
                //}

            //}

            // Console.WriteLine();
            for (int z = 0; z < c; z++)
            {
                a[z] = p[z].ToString();
                //Console.WriteLine($"{a[z]}");
            }
            for (int g = 0; g < d; g++)
            {
                b[g] = q[g].ToString();
            }
            var x = string.Join(",", a);
            var y = string.Join(",", b);
            Console.WriteLine("偶數:" + x);
            Console.WriteLine("奇數:" + y);
            //Console.WriteLine(p);不可以這樣寫
            /*
            Console.Write("偶數:");
            foreach (string i in exp)
            {
                s = int.Parse(i);
                if ((s % 2) == 0)
                {
                   Console.Write($"{s},");
                }

            }
            Console.WriteLine();
            Console.Write("奇數:");
            foreach (string i in exp)
            {
                s = int.Parse(i);
                if ((s % 2) != 0)
                {
                    
                    Console.Write($"{s},");
                }
            }
            */

            Console.ReadLine();
        }
    }
}
