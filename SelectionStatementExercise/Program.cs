namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a game that you have to guess wich number I´m thinking. n");
            Console.WriteLine("Please enter your first guess.");
            var userInput = int.Parse(Console.ReadLine());

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            if (userInput == favNumber)
                Console.WriteLine("You guessed it!!!");

            else if (userInput < favNumber)
                Console.WriteLine("Too low.");

            else
                Console.WriteLine("Too high");

        }
    }
}
