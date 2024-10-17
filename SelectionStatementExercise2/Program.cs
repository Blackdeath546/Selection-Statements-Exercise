namespace SelectionStatementExercise2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your favorite school subject?");
        string favoriteSubject = Console.ReadLine();
        string lowercase = favoriteSubject.ToLower();

        switch (lowercase)
        {
            case "math":
            case "arithmetic":
            case "mathematics":
                Console.WriteLine("Math is cool because it's all about solving problems!");
                break;
            case "english":
                Console.WriteLine("English is a pretty normal subject. \nI guess its an okay subject to like, but there are better actual school subjects.");
                break;
            case "history":
                Console.WriteLine("That's pretty old school, are you sure you want that to be your favorite subject?");
                break;
            case "science":
                Console.WriteLine("OK now THAT'S A COOL SUBJECT!\nYou have my respect");
                break;
            case "coding":
            case "code":
            case "computer Science":
                Console.WriteLine("Pretty cool, very respectable ");
                break;
            case "gaming":
                Console.WriteLine("That's not a subject silly!\nI do however approve of this choice.");
                break;
            default:
                Console.WriteLine("That's not a subject!");
                break;

        }
    }
}