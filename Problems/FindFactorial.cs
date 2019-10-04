using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCoding.Problems
{
    public class FindFactorial
    {
        public static int Factorial(int n) {

            if (n > 0)
            {
                var f = Factorial(n - 1);
                return f * n;
            }
            else return 1;

        }
        public static int Factorial2(int n)
        {
            var total = 1;
            for (int i = 1; i <= n; i++) {
                total = i * total; 
            }
            return total;
        }
    }
}
