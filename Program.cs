namespace CSharpExercisesW3Resource
{
    class Program
    {
        static void Main(string[] args)
        {
            var pikachu = new Pokemon();
            var bulbasaur = new Pokemon
            {
                type1 = "grass"
            };
            var squirtle = new Pokemon
            {
                type1 = "water",
                name = "squirtle"
            };
            Console.WriteLine("i choose u");
        }
    }

    // C#.NET Tutorials YT
    // constructors, object initialisers
    class Pokemon
    {
        public string name { get; set; }
        public string type1 { get; set; }
        public string type2 { get; set; }

        // object initialisers elimitate need for :this()
        public Pokemon()
        {
            this.name = "unidentified";
            this.type1 = "unknown";
            this.type2 = "unknown";
        }

        public static void doStatic()
        {
            Console.WriteLine("doStatic()");
        }

    }
}