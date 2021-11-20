using CommandPattern;
using CommandPattern.Contracts;
using System;

namespace ExercisesDesignPatterns.POCS
{
    public class PocCommand
    {
        ICommand commandPattern;        

        public PocCommand()
        {
            commandPattern = new Command();
            
        }

        public void StartCommandTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Command Design Pattern                         |");
            Console.WriteLine("|******************************************************************************|");

            commandPattern.Execute();

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
