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
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                  dinowilliam.com                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                            Exercises from Design Patterns                                           |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                        Options:                                                                     |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                            1 - Singleton Pattern (Default)                                          |");
            Console.WriteLine("|                                            2 - Singleton Pattern (Generics)                                         |");
            Console.WriteLine("|                                            3 - Adapter Pattern                                                      |");
            Console.WriteLine("|                                            4 - Decorator Pattern                                                    |");
            Console.WriteLine("|                                            5 - Facade Pattern                                                       |");
            Console.WriteLine("|                                            6 - Command Pattern                                                      |");
            Console.WriteLine("|                                            7 - Factory Pattern                                                      |");
            Console.WriteLine("|                                            8 - Abstract Factory Pattern                                             |");
            Console.WriteLine("|                                            0 - Exit                                                                 |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|*********************************************************************************************************************|");
            Console.WriteLine("| Choose one option to continue...                                                                                    |");
            Console.WriteLine("|*********************************************************************************************************************|");

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
                        var pocDecorator = new PocDecorator();
                        pocDecorator.StartDecoratorTest();
                        DrawMainScreen();
                        break;

                    case 5:
                        var pocFacade = new PocFacade();
                        pocFacade.StartFacadeTest();

                        DrawMainScreen();
                        break;

                    case 6:
                        var pocCommand = new PocCommand();
                        pocCommand.StartCommandTest();

                        DrawMainScreen();
                        break;

                    case 7:
                        var pocFactory = new PocFactory();
                        pocFactory.StartFactoryTest();

                        DrawMainScreen();
                        break;

                    case 8:
                        var pocAbstractFactory = new PocAbstractFactory();
                        pocAbstractFactory.StartAbstractFactoryTest();
                        DrawMainScreen();
                        break;

                    case 0:
                        Environment.Exit(0);
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
