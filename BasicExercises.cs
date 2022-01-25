namespace CSharpExercisesW3Resource.BasicExercises
{
    // Up to 15

    // I/O, Arithmetic, Format String, Convert
    class Exercise7
    {
        public static void main()
        {
            Console.Write("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = " + (x + y));
            Console.WriteLine($"{x} - {y} = " + (x - y));
            Console.WriteLine($"{x} x {y} = " + (x * y));
            Console.WriteLine($"{x} / {y} = " + (x / y));
            Console.WriteLine($"{x} % {y} = " + (x % y));
        }
    }
}