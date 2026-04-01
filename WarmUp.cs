
using Microsoft.VisualBasic;

namespace HackerRankExercises;

class WarmUp
{
    public static int simpleArraySum(List<int> ar)
    {
        int result = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            result += ar[i];
        }
        return result;
    }

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int pointsAlice = 0;
        int pointsBob = 0;
        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                pointsAlice++;
            }
            else if (a[i] < b[i]) 
            { 
                pointsBob++; 
            }
        }

        return [pointsAlice, pointsBob];
    }

    public static long aVeryBigSum(List<long> ar)
    {
        long result = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            result += ar[i];
        }

        return result;
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int firstDiagonal = 0;

        for (int i = 0;i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                {
                    firstDiagonal += arr[i][j];
                }
            }
        }

        int secondDiagonal = 0;
        arr.Reverse();

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                {
                    secondDiagonal += arr[i][j];
                }
            }
        }

        return Math.Abs(firstDiagonal - secondDiagonal);
    }

    public static void plusMinus(List<int> arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeroes = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 0)
            {
                positives++;
            }
            else if (arr[i] < 0)
            {
                negatives++;
            }
            else
            {
                zeroes++;
            }

        }
            Console.WriteLine($"{(decimal)positives/arr.Count:F6}");
            Console.WriteLine($"{(decimal)negatives/arr.Count:F6}");
            Console.WriteLine($"{(decimal)zeroes/arr.Count:F6}");
    }

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int k = 0; k < n - i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < n - (n - i); j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }

    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
        }
        long minValueResult = sum - arr.Max();
        long maxValueResult = sum - arr.Min();

        Console.WriteLine($"{minValueResult} {maxValueResult}");
    }

    public static int birthdayCakeCandles(List<int> candles)
    {
        int maxValue = int.MinValue;
        int highestCandlesCount = 0;

        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] > maxValue)
            {
                maxValue = candles[i];
            }
        }

        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == maxValue)
            {
                highestCandlesCount++;
            }
        }

        return highestCandlesCount;
    }

    public static string timeConversion(string s)
    {
        DateTime dt = DateTime.Parse(s);
        return dt.ToString("HH:mm:ss");
    }
}



