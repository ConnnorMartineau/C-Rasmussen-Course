using System;

namespace Lab2
{
    class Program
    {
        public static int Dividend(int num1, int num2)
    {
        int total;
        total = num1 / num2;
        return total;
    }
        static void Main(string[] args)
        {
            Console.Write("\n\nFunction to divide two numbers :\n");
            Console.Write("--------------------------------------------------\n");
	        Console.Write("Enter a number: ");
            int n1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Dividend of two numbers is : {0} \n", Dividend(n1,n2) );
        }
    }
}