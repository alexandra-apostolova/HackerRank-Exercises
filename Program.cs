
namespace HackerRankExercises
{
    public class Program
    {
        public static void Main()
        {
            Implementation bm = new Implementation();
            List<int> grades = bm.gradingStudents([23, 68, 70, 33]);

            Console.WriteLine(string.Join(" ", grades));

            Console.WriteLine(bm.kangaroo(0, 3, 4, 2));

            Console.WriteLine(bm.birthday([1, 4, 5, 2, 3], 12, 4));
        }
    }
}
