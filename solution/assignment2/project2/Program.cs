using System;

namespace integer
{
    class IntArray
    {
        //最大值
        public static int outMax(int[] a)
        {
            int max = a[0];
            int i = 1;
            while (i < a.Length)
            {
                max = a[i] > max ? a[i] : max;
                i++;
            }
            return max;
        }
        //最小值
        public static int outMin(int[] a)
        {
            int min = a[0];
            int i = 1;
            while (i < a.Length)
            {
                min = a[i] < min ? a[i] : min;
                i++;
            }
            return min;
        }
        
        //总和
        public static int sum(int[] a)
        {
            int sum = 0;
            int i = 0;
            while (i < a.Length)
            {
                sum = sum + a[i];
                i++;
            }
            return sum;
        }
        //平均值
        public static int average(int[] a)
        {
            return sum(a) / a.Length;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 6, 7, 8, 9, 10, 11 };
            System.Console.WriteLine(outMax(a));
            System.Console.WriteLine(outMin(a));
            System.Console.WriteLine(average(a));
            System.Console.WriteLine(sum(a));
        }
    }
}
