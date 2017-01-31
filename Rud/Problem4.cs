using System.Linq;
using System.Collections.Generic;

namespace ProjectEuler.Rud
{
    class Problem4 : Problem
    {
        public Problem4()
        {
description =
@"A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.";
        }


        protected override void Solve()
        {
            List<int> palindromes = new List<int>();
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    int product = i * j;
                    var digits = product.ToString().ToCharArray();

                    int x = 0;
                    int y = digits.Length - 1;
                    //x starts at first digit in number, y is last digit, keep checking until they meet in the middle or pass each other

                    bool isPalindrome = true;
                    bool done = false;
                    while (!done)
                    {
                        if (digits[x] != digits[y])
                        {
                            isPalindrome = false;
                            done = true;
                        }
                        x++;
                        y--;
                        if (y <= x)
                        {
                            done = true;
                        }
                    }

                    if (isPalindrome)
                    {
                        palindromes.Add(product);
                    }
                }
            }
            answer = palindromes.Max().ToString();
        }
    }
}
