/*************************************************************************************************************************************************
 * Develop by William Ferreira de Paula
 * In 05/01/2015
 * Exercices and Concept Proves
 * Exercises Design Patterns
 *************************************************************************************************************************************************/

using System;
using ExercisesDesignPatterns.POCS;

namespace ExercisesDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawMainScreen();           
        }

        public static void DrawMainScreen()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                       Exercises from Design Patterns                         |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("| Options                                                                      |");
            Console.WriteLine("|      1 - Singleton Pattern (Default)                                         |");
            Console.WriteLine("|      2 - Singleton Pattern (Generics)                                        |");
            Console.WriteLine("|      3 - Adapter Pattern                                                     |");
            Console.WriteLine("|      4 - Decorator Pattern                                                   |");
            Console.WriteLine("|      5 - Facade Pattern                                                      |");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("| Choose one option to continue...                                             |");
            Console.WriteLine("|******************************************************************************|");

            var option = Console.ReadLine();

            ExecuteTheOption(option);
        }

        public static void ExecuteTheOption(string option)
        {
            if (!String.IsNullOrWhiteSpace(option))
            {
                int value = Int32.Parse(option);

                switch (value)
                {
                    case 1:
                        var pocSingDefault = new PocSingleton();
                        pocSingDefault.StartDefaultSingletonTest();

                        DrawMainScreen();
                        break;

                    case 2:
                        var pocSingGenerics = new PocSingleton();
                        pocSingGenerics.StartGenericsSingletonTest();

                        DrawMainScreen();
                        break;

                    case 3:
                        var pocAdapter = new PocAdapter();
                        pocAdapter.StartAdapterTest();

                        DrawMainScreen();
                        break;

                    case 4:                        
                        DrawMainScreen();
                        break;

                    case 5:
                        var pocFacade = new PocFacade();
                        pocFacade.StartFacadeTest();

                        DrawMainScreen();
                        break;

                    default:
                        DrawMainScreen();
                        break;
                }
            }
            else
            {
                DrawMainScreen();
            }
        }

    }
}
