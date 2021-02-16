using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
  //awal haja kandiroha hia hadi kankatbo hnaya
    public delegate void CalculateDelegate(int n1, int n2);
    class Program
    {
        static void Main(string[] args)
        {
            //kansaliw ma 3 kanjiw hnaya kankatbo i kan instancemaken in delegate
            CalculateDelegate del1 = new CalculateDelegate(Add);
            CalculateDelegate del2 = new CalculateDelegate(Substract);
            CalculateDelegate del3 = new CalculateDelegate(Multiply);
            CalculateDelegate del4 = new CalculateDelegate(Divide);

            //add 4 delegate to del5 which is multicast delegate
            CalculateDelegate del5 = del1 + del2 + del3 + del4;
            del5.Invoke(20, 5);

            del5 -= del2;
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            del5.Invoke(10, 2);

            Console.WriteLine("----------------------------");

            del5 += del2;
            del5 += del2;
            del5 += del2;
            del5.Invoke(6, 3);



        }

        // hna tania dar static waheda jdida
        public static void Add(int x, int y)
        {
            Console.WriteLine($"the Sum of {x} and {y} is {x+y}");
        }

        public static void Substract (int a, int b)
        {
            Console.WriteLine($"the Substraction of {a} and {b} is {a-b}");
        }
        //hadi 3 kankatboha hnaya
        public static void Multiply(int m1, int m2)
        {
            Console.WriteLine($"the Multiplication of {m1} and {m2} is {m1*m2}");

        }
        // hadi 4
        public static void Divide(int d1, int d2)
        {
            Console.WriteLine($"the Division of {d1} and {d2} is {d1 * d2}");

        }

    }
}
