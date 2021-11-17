using System;

namespace SelectionStatementPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine("Why? Math is hard and boring.");
                    break;
                case "English":
                    Console.WriteLine("Way to enjoy something that's as boring as math.");
                    break;
                case "History":
                    Console.WriteLine("Mine too! This is probably the most interesting subject.");
                    break;
                case "Science":
                    Console.WriteLine("Good choice. Major in this in college to make the big bucks later.");
                    break;
                case "Philosophy":
                    Console.WriteLine("Strange choice, but this is what many lawyers studied before law school so best of luck.");
                    break;
                default:
                    Console.WriteLine("You had that in school? Unheard of.");
                    break;

            }
        }

    }
}
