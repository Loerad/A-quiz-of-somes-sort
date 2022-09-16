using System;
using System.Threading;

namespace repoQuiz1
{
    internal class Program
    {
        static void Main()
        {
            const string answer1 = "elephant";
            int score = 0;
            Console.WriteLine("Question 1");
            Console.Write("What is the world’s largest land mammal? ");
            string guess1 = Console.ReadLine();
            if (answer1 == guess1.ToLower())
            {
                Console.WriteLine("Congrats, you got question 1 correct! +1!");
                score++;
            } else
            {
                Console.WriteLine("That's too bad, the correct answer was: Elephant!");
            }
            Console.WriteLine($"Your score is: {score}");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(1000);
        }
    }
}
