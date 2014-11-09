using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        public enum ShapeType { none, Rectangle, Ellipse };
        static void Main(string[] args)
        {
            do
            {
             Console.Clear();
              ViewMenu();//Skriver ut menyn
                int userSelection;
                string choice = Console.ReadLine(); //Användaren får 3 alternativ, Avsluta, Ellipse eller rektangel.

                try 
                {
                    userSelection = int.Parse(choice);
                        switch (userSelection)
                        {
                            case 0 : return; // Avslutar
                            case 1 : ViewShapeDetail(CreateShape(ShapeType.Ellipse)); break; //Metoden ViewMenu anropas och värdena från CreateShape och ShapeType.Ellipse skickas med.
                            case 2: ViewShapeDetail(CreateShape(ShapeType.Rectangle)); break; // Metoden ViewMenu anropas och värdena från CreateShape och ShapeType.Rectangle skickas med.
                            default : Console.WriteLine("var snäll och ange ett utav valen 0-2"); break; // Om inget av ovanstående case körs, skrivs detta felmeddelande ut.
                        }
                }
                
                catch
                {
                    //Om användaren matar in en siffra som är mindre än noll
                     Console.BackgroundColor = ConsoleColor.Red;
                     Console.WriteLine("Fel! '{0}' är inte ett heltal", choice);
                     Console.ResetColor();  
                }
                     Console.BackgroundColor = ConsoleColor.DarkBlue;
                     Console.WriteLine("\nTryck valfri tangent för ny uträkning - ESC avslutar ");
                     Console.ResetColor();
               } while (Console.ReadKey(true).Key != ConsoleKey.Escape); //Valfri tanget gör ny uträkning och Escape avslutar
        }

            private static Shape CreateShape(ShapeType shapeType)
        {
            
            //Skapar nya lokala variabler.
            double length;
            double width;
            Shape shape;
 
                //Skriver ut vilken geometrisk figur som skall beräknas.
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("╔════════════════════════════════════════════════╗");
            Console.WriteLine("║   {0,25}                    ║", shapeType);
            Console.WriteLine("╚════════════════════════════════════════════════╝");
            Console.ResetColor();

            length = ReadDoubleGreaterThanZero("Mata in längden: ");
            width = ReadDoubleGreaterThanZero("Mata in bredden: ");
            if (shapeType == ShapeType.Ellipse)
            {
                return shape = new Ellipse(length, width); //Skickar längd och bredd till konstruktorn om användaren valde Ellipse
            }
            return shape = new Rectangle(length, width);  //Skickar längd och bredd till konstruktorn om användaren valde Rectangle
            }

                 private static void ViewMenu() //menyn som skrivs ut vid ViewMenu i do-while loopen.
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=                                      =");
            Console.WriteLine("=          Geometriska Figurer         =");
            Console.WriteLine("=                                      =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta.\n 1. Ellips\n 2. Rektangel.");
            Console.WriteLine("========================================");
        }
        private static void ViewShapeDetail(Shape shape)//skriver ut resultaten.
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========================================");
            Console.WriteLine("=               Detaljer               =");
            Console.WriteLine("========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());//anropar och skriver ut det som ToString() returnerar.
            Console.WriteLine("========================================");
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            string input;
            double number;

            while (true)
            {
                Console.Write(prompt);
                input = Console.ReadLine(); //Användaren skriver in ett värde
                
                try
                {
                    number = Double.Parse(input);
                    if (number < 0) // Är värdet mindre än noll ?
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("FEL! {0} Är mindre än noll.", input);
                        Console.ResetColor();
                    }
                    return number;
                }
                catch (FormatException)
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("FEL! {0} är inget heltal !", input);
                    Console.ResetColor();
                 
                         }
                     }
                }
           }
       }
