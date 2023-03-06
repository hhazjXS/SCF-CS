using System;
using System.Numerics;

namespace prime
{
    class Ehrlich
    {
        //输出一个bool类型的数组，判断是否是素数
        public static bool[] outPrime(int n)
        {
            bool[] ans = new bool[n + 1];
            for (int i = 0; i <= n; i++) ans[i] = true;
            ans[0] = ans[1] = false;
            for (int i = 2; i <= n; i++)
            {
                if (ans[i])
                {
                    for (int j = 2 * i; j <= n; j += i)//如果i是素数，则将i的倍数的ans值置为false
                    {
                        ans[j] = false;
                    }
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n = 100;//输入2到n的素数
            bool[] ans = outPrime(n);
            int i = 2;

            while (i <= 100)
            {
                if (ans[i]) System.Console.WriteLine(i);
                i++;
            }
        }
    }
}

