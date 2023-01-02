namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject");

            var subject = Console.ReadLine();

            switch(subject.ToLower()) 
            {
                case "math": 
                    Console.WriteLine("Nerd");
                    break;
                case "english":
                    Console.WriteLine("Theatre Kid");
                    break;
                case "pe":
                    Console.WriteLine("Jock");
                    break;
                case "chemistry":
                    Console.WriteLine("Mr.White");
                    break;
                default:
                    Console.WriteLine("No idea what this subject is");
                    break;
                 
            }
        }
    }
}