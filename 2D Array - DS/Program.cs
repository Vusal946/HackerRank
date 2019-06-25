using System;
namespace _2D_Array___DS
{
    class Program
    {
        static int hourglassSum(int[][] arr)
        {
            int maxSum = -63;
            int temp = 0;
            byte rowIndex = 0;
            byte columnIndex = 0;
            byte rowLength = 3;
            byte columnLength = 3;

            for (int a = 0; a < 4; a++)
            {
                byte count = 1;
                var isFirst = true;
                for (int j = rowIndex; j < rowLength; j++, count++)
                {
                    for (int k = columnIndex; k < columnLength; k++)
                    {
                        if ((arr[j][k] < -9 || arr[j][k] > 9) || j < 0 || j > 5 || k < 0 || k > 5)
                            throw new ArgumentOutOfRangeException("Constraint error");

                        if (count != 2)
                            temp += arr[j][k];
                        else
                        {
                            temp += arr[j][k];
                            if (isFirst)
                            {
                                temp = temp - arr[j][k] - arr[j][k + 2];
                                isFirst = false;
                            }
                        }
                    }
                }
                columnIndex += 1;
                columnLength += 1;
                maxSum = temp > maxSum ? temp : maxSum;
                temp = 0;

                if (a == 3)
                {
                    a = -1;
                    rowIndex += 1;
                    rowLength += 1;
                    columnIndex = 0;
                    columnLength = 3;
                }              

                if (rowIndex == 4)
                    return maxSum;
            }
            return maxSum;
        }

        static void Main(string[] args)
        {
            try
            {
                int[][] arr = new int[6][];
                for (int i = 0; i < 6; i++)
                {
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
                }
                int result = hourglassSum(arr);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
