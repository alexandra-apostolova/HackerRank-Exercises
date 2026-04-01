
namespace HackerRankExercises
{
    public class Implementation
    {
        public List<int> gradingStudents(List<int> grades)
        {
            List<int> modifiedGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                int currentGrade = grades[i];
                if (currentGrade < 38)
                {
                    modifiedGrades.Add(currentGrade);
                }
                else
                {
                    int firstDigit = int.Parse(currentGrade.ToString()[0].ToString());
                    int secondDigit = int.Parse(currentGrade.ToString()[1].ToString());
                    string roundedGrade = "";
                    if (secondDigit > 7)
                    {
                        roundedGrade = $"{firstDigit + 1}0";
                        currentGrade = int.Parse(roundedGrade);
                    }
                    else if (secondDigit > 2 && secondDigit < 5)
                    {
                        roundedGrade = $"{firstDigit}5";
                        currentGrade = int.Parse(roundedGrade);
                    }
                    modifiedGrades.Add(currentGrade);
                }

            }

            return modifiedGrades;
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            for (int i = 0; i < apples.Count; i++)
            {
                apples[i] += a;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                oranges[i] += b;
            }

            List<int> applesInRange = apples.Where(a => a >= s && a <= t).ToList();
            List<int> orangesInRange = oranges.Where(o => o >= s && o <= t).ToList();

            Console.WriteLine(applesInRange.Count);
            Console.WriteLine(orangesInRange.Count);
        }

        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2 > x1 && v2 > v1)
            {
                return "NO";
            }

            int jumpCount = 0;

            while (true)
            {
                x1 += v1;
                x2 += v2;
                jumpCount++;

                if (x1 == x2)
                {
                    return "YES";
                }

                if (jumpCount == 10000)
                {
                    return "NO";
                }
            }
        }

        public static List<int> breakingRecords(List<int> scores)
        {
            int minScore = scores[0];
            int maxScore = scores[0];

            int leastPointsRecord = 0;
            int mostPointsRecord = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    leastPointsRecord++;
                }

                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    mostPointsRecord++;
                }
            }

            return [mostPointsRecord, leastPointsRecord];
        }

        public int birthday(List<int> s, int d, int m)
        {
            if (m > s.Count)
            {
                return 0;
            }

            int divisionCount = 0;

            for (int i = 0; i < s.Count - 1; i++)
            {
                int result = s[i];
                if (m > s.Count - i)
                {
                    break;
                }
                for (int j = i + 1; j < i + m; j++)
                {
                    result += s[j];
                }

                if (result == d)
                {
                    divisionCount++;
                }
            }

            if (m == 1 && s.Contains(d))
            {
                for (int i = 0; i < s.Count; i++)
                {
                    if (s[i] == d)
                    {
                        divisionCount++;
                    }
                }
            }

            return divisionCount;
        }

    }
}
