namespace CSharpExercisesW3Resource
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = BasicAlgorithmExercises.Exercise34.Do(new int[] { 1, 2, 1 });
            Console.WriteLine(x); 
        }
    }
}

namespace CSharpDotNETTutorialsYT
{
    // constructors, object initialisers
    class Pokemon
    {
        readonly public string Name;
        public string type1 { get; set; }
        public string type2 { get; set; }
        private string _weakness;

        // object initialisers elimitate need for :this()
        public Pokemon()
        {
            this.Name = "unidentified";
            this.type1 = "unknown";
            this.type2 = "unknown";

        }

        public static void doStatic()
        {
            Console.WriteLine("doStatic()");
        }

    }

    class Digimon
    {
        public Digimon()
        {

        }
    }

    
}