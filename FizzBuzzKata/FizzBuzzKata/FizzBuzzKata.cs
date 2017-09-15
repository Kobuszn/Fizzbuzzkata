using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzzKata
    {
        public string FizzBuzzChecker(int input)
        {
            if (DivisibleBy3(input)&& DivisibleBy5(input))
            {
                return "FizzBuzz";
            }
            if (DivisibleBy5(input))
            {
                return "Buzz";
            }
            if (DivisibleBy3(input))
            {
                return "Fizz";
            }

            return input.ToString();
        }

        private static bool DivisibleBy3(int input)
        {
            return input % 3 == 0;
        }

        private static bool DivisibleBy5(int input)
        {
            return input % 5 == 0;
        }
    }
}
