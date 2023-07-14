using System;

namespace RandomQArray;

class Program
{
    static void Main(string[] args)
    {
        //creates questions array with 10 rows and 3 columns 
        int[,] questions = new int[10, 3];

        int score = 0;

        //starts for loop that while row is lower than 10, continue to ask questions
        for (int row = 0; row < 10; row++)
        {
            //creates integer variable firstNum and assigns a random number to it
            Random a = new Random();
            int firstNum = a.Next(1, 10);

            //creates integer variable secondNum and assigns a random number to it
            Random b = new Random();
            int secondNum = b.Next(1, 10);

            //places firstNum variable in the first slot of the questions array
            questions[row, 0] = firstNum;

            //places secondNum variable in the second slot of the questions array
            questions[row, 1] = secondNum;

            //places the sum of firstNum * secondNum in the third slot of the questions array
            questions[row, 2] = (firstNum * secondNum);

            //sets the variable sum1 equal to whatever is in the 3rd slot of the array
            int sum1 = questions[row, 2];

            //converts the integer variable sum1 to a string
            Convert.ToString(sum1);

            //prints out the question
            Console.WriteLine("Question {0}: What is {1} x {2}", row + 1, questions[row, 0], questions[row, 1]);

            //asks user for an answer
            Console.WriteLine("Enter Your Answer: ");

            //sets the string variable to whatever the user answered
            string userAnswer = Console.ReadLine();

            //creates the integer variable userIntegerAnswer
            int userIntegerAnswer;

            //creates a while loop that while the userAnswer is not an integer it will fail to pass it to userIntegerAnswer and ask for a new input
            while (!int.TryParse(userAnswer, out userIntegerAnswer))
            {
                //clears console to tidy code up
                Console.Clear();

                //sets text colour to red
                Console.ForegroundColor = ConsoleColor.Red;

                //tells user that what they entered is not a number
                Console.WriteLine("Not A Number");

                //re-prints the question for the user and asks for another input
                Console.WriteLine("Question {0}: What is {1}*{2}", row + 1, questions[row, 0], questions[row, 1]);

                Console.WriteLine("Enter Your Answer: ");
                userAnswer = Console.ReadLine();
            }

            //starts if statement that if userIntegerNumber equals sum1 then set text to green and display "Correct!" and add a point to the score variable
            if (userIntegerAnswer == sum1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Correct!");
                score = score + 1;

            }

            //else statement that sets text color to red and then displays when they get a question wrong
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Incorrect!");

            }


            //sets console colour back to white and displays the current score
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Total Score: " + score);
            Console.WriteLine(SumariseScore(score));
        }
    }

    private static string SumariseScore(int score)
    {
        if (score <= 4 && score >= 0)
        {
            return "You should spend an hour a day working on multiplication ";
        }
        if (score <= 7 && score > 4)
        {
            return "You should spend 30 minutes a day improving your multiplication skills ";
        }
        if (score > 7)
        {
            return "You're great at multiplication!";
        }
        return "You broke the system! You're that good!";
    }
}
