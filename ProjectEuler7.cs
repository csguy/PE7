using System;


namespace PE7
{
    public class ProjectEuler7
    {
        /**
         * Takes in an integer.  If int  is less than 0, throw an ArgumentOutOfRange Exception
         * Start with 1, and with an odd numbe as prime (since even numbers aren't prime)
         * loop through to the Nth element, skipping 2 each time you check for prime numbers.
         * */
        public int FindNthPrime(int nthCount)
        {
            if (nthCount > 0)
            {
                int primeCount = 1;
                int prime = 1;

                while (primeCount < nthCount)
                {
                    prime += 2;
                    if (isNumberPrime(prime))
                    {
                        primeCount++;
                    }
                }
                return prime;
            }else
            {
                Console.WriteLine("exception");
                throw new ArgumentOutOfRangeException("nthCount", nthCount, "The number you passed in is negative.");
            }
            
        }


        /**
         * Takes in a number and determines if it is a prime or not.  If the number is negative or 1,
         * return false.  If the number is 2, return true.  If the number is even, return false.
         * If the number is >2, start the calculation.  Start the divisor at 3 (since we account for all previous inputs).  
         * If the divisor equals the number you're checking against, it's a prime.  If not, increase the divisor by 2.  Continue looping
         * until there is no remainder.  If the value of the divisor equals the value of the number you've passed in, it's prime.  If some other number
         * divided equally in to the number you passed in (and it's not the number itself), it's not a prime.
         * 
         * Example:
         * 
         * Pass in 5.
         * First pass of loop.  5 % 3 != 0 (2 remainder), increase the divisor by 2.
         * Second pass of loop. 5 % 5 == 0; break the loop
         * Since the divisor (5) is equal to the number we passed in (5), the number is prime.
         * 
         * Pass in 6.
         * Return false.  6 is an even number.
         * 
         * Pass in 9.
         * First pass of loop. 9 % 3 == 0.  9 is not prime.
         * */
        public Boolean isNumberPrime(float num)
        {
            if (num <= 1) return false;  //any number <= 1 isn't a prime, so return
            if (num == 2) return true; //special case for 2

            //is the number even?
            if (num % 2 == 0) return false;

            int divisor;

            //loop, and stop once there is no remainder
            for (divisor = 3; num % divisor != 0; divisor += 2)
                ;
            
            if (divisor == num)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
