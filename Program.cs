using System;
//Quinn M
namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 4;
            int[] password = new int[length];
            string guess;
            int[] guessArray = new int[length];
            int guessesLeft = 10;
            int intVal;
            bool gameOver = false;
            Random random = new Random();
            string t;
            // Creation of the mastermind code
            for (int i = 0; i < length; i++)
            {
                password[i] = random.Next(1, 7);
            }
            Console.WriteLine("Welcome to Mastermind.");         
            do
            {
                t = "";
                Console.WriteLine("Enter a number: ");
                guess = Console.ReadLine();
                for (var a = 0; a < length; a++)
                {
                    intVal = guess[a];
                    guessArray[a] = intVal-48;
                }

                //Console.WriteLine(string.Join("",password));
                //Comparing digit by digit guess to password returning the string of answers for hints.
                for (var i = 0; i < 4; i++)
                {
                    if (guessArray[i] == password[0] || guessArray[i] == password[1] || guessArray[i] == password[2] || guessArray[i] == password[3])
                    {
                        if (guessArray[i] == password[i]) t += "+";
                        else t += "-";
                    }  
                }             
                //Game status check
                guessesLeft--;
                Console.WriteLine("You have {0}  guesses left.", guessesLeft);
                Console.WriteLine(string.Join("", t));
                if (t=="++++")
                {
                    gameOver = true;
                    Console.WriteLine("You win!");
                }
                else if (guessesLeft == 0)
                {
                    gameOver = true;
                    Console.WriteLine("Sorry you ran out of guesses.");
                }
            }
            while (gameOver == false);
        }
    }
}
