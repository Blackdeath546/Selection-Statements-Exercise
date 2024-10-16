namespace SelectionStatementExercise
{
    public class Program
    {

        static int RandomNumber()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            //var userInput = int.Parse(Console.ReadLine());
            return favNumber;
        }

        

         static int GuessingGame()
         {
             int favNumber = RandomNumber();
             

             int GuessingLoop()
             {
                 
                 var userInput = double.Parse(Console.ReadLine());
                 
                 if (userInput == favNumber)
                 {
                     Console.WriteLine($"You Win! My favorite number is {favNumber}");
                 }
                 else if (userInput > favNumber)
                 {
                     Console.WriteLine($"Too high try again!");

                     GuessingLoop();
                 }
                 else if (userInput < favNumber)
                 {
                     Console.WriteLine($"Too low try again!");

                     GuessingLoop();
                 }
                 else 
                 {
                     Console.WriteLine("Please enter a valid number"); //Unable to fix bug where putting anything but a number breaks the build.

                     GuessingLoop();
                 }

                 return favNumber; // it says I need a return, but it doesn't do anything from my understanding
             }
             GuessingLoop();
             return favNumber;
         }

        static void Main(string[] args)
        { 
            //RandomNumber();
            //Console.WriteLine($"{RandomNumber()}");
            //Console.WriteLine($"{favNumber}");
            //Console.WriteLine($"{favNumber}");
            
            //Console.WriteLine("Hmmm I got it! ");
            Console.WriteLine("Lets try to guess my favorite number!");
            Console.WriteLine("Guess my favorite number! : ");
           
            GuessingGame();
            
            
        }
    }
}
