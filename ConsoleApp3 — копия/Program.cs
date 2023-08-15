using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)  
        {

            for (int i = 1; i < 11; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 11; i > 0; i--)
            {
                for (int k = 1; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            for (int i = 1, k = 9; i < 11; i++, k--)
            {
                //string str = new string(' ', k);
                //Console.Write(str);

                for (int q = 10; q > i; q--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)

                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 10, k = 0; i > 0; i--, k++)
            {
                //string str = new string(' ', k);
                //Console.Write(str);

                for (int q = 10; q > i; q--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }






            //первый  треугольник

            //for (int i = 1; i < 12; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            ////второй треугольник

            //for (int i = 11; i > 1; i--)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            ////третий треугольник

            //for (int i = 0, k = 11; i < 12; i++, k--)
            //{

            //    string str = new string(' ', k);
            //    Console.Write(str);

            //    for (int j = 1; j < i; j++)

            //    {
            //        Console.Write("#");
            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            ////чевёртый треугольник

            //for (int i = 0; i < 11; i++)
            //{

            //    string str = new string(' ', i);
            //    Console.Write(str);

            //    for (int j = 10; j > i; j--)

            //    {
            //        Console.Write("#");
            //    }

            //    Console.WriteLine();
            //}


        }
    }
}
