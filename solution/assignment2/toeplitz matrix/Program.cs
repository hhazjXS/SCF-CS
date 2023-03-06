using System;

namespace toeplitz
{
    class ToeplitzMatrix
    {
        //遍历数组
        public bool isToeplitz(int[][] a)
        {
            for (int row = 0; row < a.Length; row++)
            {
                for (int col = 0; col < a[0].Length; col++)
                {
                    if (row > 0 && col > 0 && a[row][col] != a[row - 1][col - 1])//判断是否相等
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[][] matrix = { new int[] { 1, 2, 1 }, new int[] { 2, 1, 2 } };
            ToeplitzMatrix toeplitzMatrix = new ToeplitzMatrix();
            if (toeplitzMatrix.isToeplitz(matrix))
            {
                System.Console.WriteLine("此矩阵为托普利茨矩阵。");
            }
        }
    }
}