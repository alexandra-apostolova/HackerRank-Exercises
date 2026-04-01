
namespace HackerRankExercises
{
    public class Program
    {
        public static void Main()
        {
            BitManipulation bm = new BitManipulation();
            List<int> grades = bm.gradingStudents([23, 68, 70, 33]);

            Console.WriteLine(string.Join(" ", grades));

            Console.WriteLine(bm.kangaroo(0, 3, 4, 2));
        }
    }
}
