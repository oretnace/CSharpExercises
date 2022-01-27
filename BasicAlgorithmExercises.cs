namespace CSharpExercisesW3Resource.BasicAlgorithmExercises
{
    class Exercise1
    {
        public static void Do()
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: {0}", x == y ? (x + y) * 3 : x + y);
        }
    }

    class Exercise6
    {
        public static string Do(string theString, int ind)
        {
            if (ind < theString.Length)
            {
                return theString.Remove(ind, 1);
            } else
            {
                return "invalid index";
            }
        }
    }

    class Exercise7
    {
        public static string Do(string theStr)
        {
            int MinLength = 2;
            int MaxLoop = 4;

            if (theStr.Length < MinLength)
            {
                return theStr;
            } else
            {
                string tempStr = "";
                string theSubstr = theStr.Substring(0, MinLength);
                for (int i = 0; i < MaxLoop; i++)
                {
                    tempStr += theSubstr;
                }
                return tempStr;
            }
        }
    }

    class Exercise10
    {
        public static Boolean Do(int x)
        {
            if (x % 3 == 0 || x % 7 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    class Exercise13
    {
        public static bool Do(int x, int y)
        {
            bool isLessThan0 = false;
            bool isMoreThan100 = false;

            if (x < 0 || y < 0)
            {
                isLessThan0 = true;
            }
            if (x > 100 || y > 100)
            {
                isMoreThan100 = true;
            }

            if (isLessThan0 && isMoreThan100)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    class Exercise32
    {
        public static bool Do(int[] arr, int x)
        {
            if (arr.Contains(x))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    class Exercise34
    {
        public static bool Do(int[] arr)
        {
            int One = 1;
            int Two = 2;
            int Three = 3;

            int ind = Array.IndexOf(arr, One);

            if  (ind != -1 && arr[++ind] == Two && arr[++ind] == Three)
            {
                return true;

            }

            return false;
        }
    }
}
