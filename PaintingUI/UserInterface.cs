using PaintingBL;
using PaintingDL;
using PaintingModel;
namespace PaintingUI
{
    internal class UserInterface
    {
        public static void DisplayPainting(Model Painting)
        {
            Console.WriteLine("Title of the Painting: " + Painting.Title);
            Console.WriteLine("Artist: " + Painting.Painter);
            Console.WriteLine("Date: " + Painting.Date);
            Console.WriteLine("Location of the painting: " + Painting.Where);
            Console.WriteLine("Description: " + Painting.Description);
            Console.WriteLine("____________________");

        }
        static void Main(string[] args)
        {
           BusinessLogic businessServices = new BusinessLogic();
            List<Model> famouspainting = businessServices.GMS();
            DataLayer dataServices = new DataLayer();

            Console.WriteLine("Welcome to the history website of the world's famous paintings!!!");

            Console.WriteLine("PRESS ENTER KEY ONLY TO CONTINUE :)");
            Console.WriteLine("____________________");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

            Console.WriteLine("The Famous Paintings In The World: ");
            Console.WriteLine();

            foreach (var painting in famouspainting)
            {
                DisplayPainting(painting);
            }

            Console.WriteLine("\nPress A/a to Add a new painting or R/r to Remove an existing painting. Press Backspace to exit.");
            char option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("\nEnter the details of the new painting that you want to add: ");
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Painter: ");
                    string painter = Console.ReadLine();
                    Console.Write("Date: ");
                    string date = Console.ReadLine();
                    Console.Write("Where: ");
                    string where = Console.ReadLine();
                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Model newPainting = new Model()
                    {
                        Title = title,
                        Painter = painter,
                        Date = date,
                        Where = where,
                        Description = description
                    };

                    dataServices.AddPainting(newPainting);
                    Console.WriteLine("New Painting Added Successfully!");
                    Console.WriteLine();
                    Console.WriteLine("PRESS BACKSPACE KEY ONLY TO EXIT.....");
                    while (Console.ReadKey(true).Key != ConsoleKey.Backspace) { }
                    Console.WriteLine("Good bye!!!");
                    break;

                case 'R':
                case 'r':
                    Console.WriteLine("\nEnter the title of the painting that you want to remove: ");
                    string titleToRemove = Console.ReadLine();
                    dataServices.RemovePainting(titleToRemove);
                    Console.WriteLine("Painting Removed Successfully!");
                    Console.WriteLine();
                    Console.WriteLine("PRESS BACKSPACE KEY ONLY TO EXIT.....");
                    while (Console.ReadKey(true).Key != ConsoleKey.Backspace) { }
                    Console.WriteLine("Good bye!!!");
                    break;

                default:
                    Console.WriteLine("\nInvalid Option. Exiting...");
                    break;
            }

        }

    }
}
