using System;

namespace ZencirvariKesrler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers: ");
            string input1=Console.ReadLine();    
            string input2=Console.ReadLine();

            int x=int.Parse(input1);
            int y=int.Parse(input2);    

            if(x>y && x % y != 0) { 
                int n1 = x / y;
                x = x - n1 * y;
                int n2 = y / x;
                int n3= y - n2 * x;
                if (n3 != 0)
                {
                    Console.WriteLine("We get: " + n1 + " " + n2 + " " + x);
                }
                else
                {
                    Console.WriteLine("We get: " + n1 + " " + n2);
                }

            }
            else
            {
                Console.WriteLine("----------INCORRECT NUMBERS---------");
            }
        }
    }
}
