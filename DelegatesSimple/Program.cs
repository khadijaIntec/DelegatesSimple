using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSimple
{
   // public delegate void AddDelegate(int x, int y);
   // public delegate string GreetingsDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            //  AddDelegate addDelegate = new AddDelegate(AddNumbers);
            // addDelegate(3, 2);
            // addDelegate.Invoke(3, 2); // hadi tari9a akhra blast lawla kandiroha

            Action<int, int> addDelegate = AddNumbers;
            addDelegate(3, 2);



            //AddDelegate subtract = new AddDelegate(Subtract);
            // subtract(8, 2);
            //tari9a akhra 
            Action<int, int> subtract = Subtract;
            subtract(8, 2);



           // GreetingsDelegate greetingsDelegate = new GreetingsDelegate(Greetings);
           // string result = greetingsDelegate("Hello c# Group");
            // string result = greetingsDelegate("Hello c# Group"); hta hadi tari9a akhra
            Func<string,string> greetingsDelegate = Greetings;
            string result = greetingsDelegate("Hello c# Group");


            Console.WriteLine(result);

           // GreetingsDelegate sayHello = new GreetingsDelegate(SayHello);
           // string sayHelloResult = sayHello("hello");
            Console.WriteLine(sayHelloresult);
        }
        //static Method 
        public static void AddNumbers(int a, int b)
        {
            Console.WriteLine($"the sum of {a} and {b} is {a+b}");

        }  
        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"The substraction of {a} and {b} is {a/b}");
        }
         public static string Greetings(string str)
        {
            return str;
        }
        public static string SayHello(string str)
        {
            return str;
        }
    }
}
