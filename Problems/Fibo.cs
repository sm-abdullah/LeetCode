using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCoding.Problems
{
    public class Fibo
    {
        public static int CalcFibo(int n)
        {

            if (n == 0) {
                return 0;
            }
            if (n < 3) {
                return 1;
            }

            return CalcFibo(n - 1) + CalcFibo(n-2);
        }
        public static int CalF(int n)
        {
            var ar = new int[n + 1];

            ar[0] = 0;
            ar[1] = 1;
            ar[2] = 1;
            if (n < 3) {
                return ar[n];
            }
            for (int i = 3; i <= n; i++) {
                ar[i] = ar[i - 1] + ar[i - 2];
            }
            return ar[n];
        }
        public static int CalF2(int n)
        {
                if (n < 2) return n;
                var f = 0;
                var l = 1;
                for (int i = 2; i <= n; i++)
                {
                    var fib = f + l;
                    f = l;
                    l = fib;
                }
                return l;
        }
    }
}
