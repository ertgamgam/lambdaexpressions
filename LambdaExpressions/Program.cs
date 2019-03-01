using System;

//lambda expressions, these are unnamed methods used together with delegates.
//https://medium.com/@sawomirkowalski/c-language-15-events-and-delegates-be1e6f966922    event sample

namespace LambdaExpressions
{
    class Program
    {
        delegate int LambdaTest(int a, int b);
        
        static void Main(string[] args)
        {
            //You can do same thing with three different ways

            Console.WriteLine("Sample1");
            LambdaTest multiplication = (x, y) =>// or ( int x,int y) =>
            {
                return x * y;
            };
            Console.WriteLine(multiplication(3, 7));

            Console.WriteLine("Sample2");
            LambdaTest multiplication2 = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine(multiplication2(4, 7));

            Console.WriteLine("Sample3");
            LambdaTest multiplication3 = (a, b) => a * b; //or (int a,int b) => a * b;
            Console.WriteLine(multiplication3(5, 7));

            //Lambda expressions are often used with Func and Action delegates:

            Func<int, int, int> adder = (a, b) => a + b;

            Func<int, int> square = (a) =>
            {
                return a * a;
            };

            Action actionOne = () =>
            {
                Console.WriteLine("ActionOne");
            };

            Action<int, int> exponent = (a, b) =>
             {
                 int result = a;
                 for (int i = 1; i < b; i++)
                 {
                     result *= a;
                 }
                 Console.WriteLine(result);
             };


            Console.WriteLine("Func adder working");
            Console.WriteLine(adder(9, 2));

            Console.WriteLine("Func square working");
            Console.WriteLine(square(7));

            Console.WriteLine("ActionOne working");
            actionOne();

            Console.WriteLine("Action exponent working");
            exponent(2, 5);

            Console.ReadKey();
        }
    }
}
