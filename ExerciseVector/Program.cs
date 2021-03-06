using FluentAssertions;
using System;

namespace ExerciseVector
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new(2, 3);
            Vector v2 = new(4, 5);
            Vector v3 = v1 + v2;
            Vector v4 = v3 * 3;

            Console.WriteLine(v1['X']);

            Console.WriteLine($"Vector: ({v4.X}, {v4.Y})");
        }
    }
}
