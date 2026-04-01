
namespace HackerRankExercises
{
    public class BitManipulation
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
            List<int> orangesInRange = oranges.Where(o =>  o >= s && o <= t).ToList();

            Console.WriteLine(applesInRange.Count);
            Console.WriteLine(orangesInRange.Count);
        }
    }
}
