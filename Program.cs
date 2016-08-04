using System;


namespace PE7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProjectEuler7 pe7 = new ProjectEuler7();
            try
            {
                Console.WriteLine("{0} ", pe7.isNumberPrime(-1));
                Console.WriteLine("The {0} (N)th prime number is {1} ",10001, pe7.FindNthPrime(10001)); //104743
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
        }
    }
}
