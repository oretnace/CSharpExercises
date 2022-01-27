namespace CSharpExercisesW3Resource.BasicExercises
{
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

    // string indexing
    class Exercise16
    {
        public static void Do()
        {
            Console.Write("Enter string: ");
            string x = modifyString(Console.ReadLine());
            Console.WriteLine($"Result: {x}");
        }

        private static string modifyString(string theString)
        {
            int penult = theString.Length - 1;
            char first = theString[0];
            char last = theString[penult];
            string substr = theString.Substring(1, penult); 

            return theString.Length > 1 ? last + substr + first : theString;
        }
    }

    // string split
    class Exercise28
    {
        public static void Do()
        {
            Console.Write("Enter string: ");
            string sentence = Console.ReadLine();
            string longest = "";
            string reversed = "";

            foreach (var word in sentence.Split(' '))
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
                reversed = word + " " + reversed;
            }

            Console.WriteLine($"Longest word: {longest}");
            Console.WriteLine($"Reversed sentence: {reversed}");
        }
    }
}