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
            if (input % 3 == 0)
            {
                return "Fizz";
            }
            if (input == 5)
            {
                return "Buzz";
            }
            return input.ToString();

        }
    }
}
