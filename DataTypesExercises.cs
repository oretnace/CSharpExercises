namespace CSharpExercisesW3Resource.DataTypesExercises
{
    // for, if, else, break
    class Exercise3
    {
        private static string TheUserId = "userid";
        private static string ThePassword = "password";
        private static int MaxAttempts = 3;
        private static void getLogin()
        {
            string userid = "", password = "";

            for (int i = 0; i < MaxAttempts; i++)
            {
                Console.WriteLine("Please enter login details.");
                Console.Write("userid: ");
                userid = Console.ReadLine();
                Console.Write("password: ");
                password = Console.ReadLine();

                if (isValid(userid, password))
                {
                    Console.WriteLine("Login Success!");
                    break;
                } else
                {
                    int attemptsLeft = MaxAttempts - 1 - i;
                    string info = "";
                    if (attemptsLeft > 0)
                    {
                        info = "Remaining attempts: " + attemptsLeft;
                    } else
                    {
                        info = "No attempts left, kicking out user.";
                    }
                    Console.WriteLine("Login Failed, " + info);
                }
            }
            
        }
        private static bool isValid(string userid, string password)
        {
            if (userid == TheUserId && password == ThePassword)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static void main()
        {
            getLogin();
        }
    }

    class Exercise5
    {
        public static void main()
        {
            Console.Write("Enter circle radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Area: " + area);
        }
    }
    // char-string conversion, Char object methods, upper/lower case
    class Exercise9
    {
        public static void main()
        {
            string input = "";
            char theChar;
            int CharLength = 1;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string info;

            do
            {
                Console.Write("Enter a character: ");
                input = Console.ReadLine();

                if (input.Length != CharLength)
                {
                    Console.WriteLine("Please only input 1 character");
                } else
                {
                    break;
                }
                
            } while (input.Length != CharLength);

            theChar = Convert.ToChar(input);

            if (Char.IsNumber(theChar))
            {
                info = "Digit.";
            } else if (Char.IsLetter(theChar))
            {
                if (Char.IsUpper(theChar))
                {
                    info = "Uppercase";
                } else
                {
                    info = "Lowercase";
                }

                if (vowels.Contains(Char.ToLower(theChar)))
                {
                    info += " vowel.";
                } else
                {
                    info += " letter.";
                }
                
            } else if (Char.IsWhiteSpace(theChar))
            {
                info = "Whitespace.";
            } else
            {
                info = "Symbol.";
            }

            Console.WriteLine(info);
        }
    }

    // converting int to binary
    class Exercise11
    {
        public static void @do()
        {
            int x;
            Console.Write("Enter a number: ");

            try
            {
                x = Convert.ToInt32(Console.ReadLine);
                string y = Convert.ToString(x, 2);
                Console.WriteLine("Binary version: " + y);
            } catch
            {
                Console.WriteLine("Error converting number to binary.");
            }
        }
    }
}
