using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBase
{
    class PrimeNumber
    {
        
        public bool IsPrime(int Number)
        {
            bool primeFlag = false;
            //Loop from 2 to Number value (since divisible by 1 is default for all numbers)
            for(int i=2;i<=(Number-1);i++)
            {
                //Check if the counter i value modulus is equal to zero, 
                //if yes it is not a prime number, then return false
                if ((Number % i) == 0)
                {
                    primeFlag = false;
                    return primeFlag;
                }
                   
            }
            return primeFlag;
        }
    }
}
