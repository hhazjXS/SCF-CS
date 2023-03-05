using System;

namespace prime
{
    class PrimeFactor
    {
        //判断n是否为素数
        public bool isPrime(int n)
        {
            for (int i = (int)Math.Sqrt(n); i > 1; i--)//只需判断至根号n就行
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            PrimeFactor p = new PrimeFactor();
            string input = System.Console.ReadLine();
            int n = int.Parse(input);//将用户输入转化为int类型
            for (int i = 2; i <= n / 2; i++)
            {
                while (n % i == 0)
                {
                    if (p.isPrime(i))
                        Console.WriteLine(i);
                    n = n / i;
                }
            }
        }
    }
}
