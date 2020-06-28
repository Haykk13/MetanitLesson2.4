using System;

namespace MetanitLesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            do
            {
                Console.Write("Enter the first integer (1-10): ");
                first = int.Parse(Console.ReadLine());
                Console.Write("Enter the second integer(1-10): ");
                second = int.Parse(Console.ReadLine());
            } while (first <= 0 || first >= 10 || second <= 0 || second >= 10);
            int res = first * second;
            Console.WriteLine($"The multiplication of your integers equals to {res}!");
            Console.ReadLine();
        }
    }
}
