// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            greetUser();


            while (true)
            {

                // Set correct number 
                //int correctNumber = 7;

                //create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string numInput = Console.ReadLine();

                    if (!int.TryParse(numInput, out guess))
                    {
                        printColorMessage(ConsoleColor.Red, "Please enter a number");


                        continue;
                    }

                    //Cast to int and put into guess variable
                    guess = Int32.Parse(numInput);

                    //matxh guess to correct num

                    if (guess != correctNumber)
                    {
                        printColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                printColorMessage(ConsoleColor.Yellow, "You are correct!");

                // ask to play again

                Boolean validAnswer = false;

                while(!validAnswer)
                {


                Console.WriteLine("Play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        validAnswer = true;
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y or N");
                    }
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Bryan Morandi";

            printColorMessage(ConsoleColor.Blue, String.Format("{0}: Version {1} by {2}", appName, appVersion, appAuthor));

        }

        static void greetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);
        }

        static void printColorMessage(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(msg);

            Console.ResetColor();
        }
    }
}
