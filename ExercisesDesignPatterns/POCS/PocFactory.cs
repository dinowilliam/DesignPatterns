using FactoryPattern;
using FactoryPattern.Contracts;
using System;

namespace ExercisesDesignPatterns.POCS
{
    public class PocFactory {
        
        ComputerFactory computerFactory;

        public PocFactory() {
            computerFactory = new ComputerFactory();
        }

        public void StartFactoryTest() {

            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Factory Design Pattern                         |");
            Console.WriteLine("|******************************************************************************|");

            Console.WriteLine("     ");
            Console.WriteLine("     Generic Computer Class: ");
            var genericComputer = computerFactory.GetComputer(ComputerType.GenericComputer);

            Console.WriteLine("         Type: {0}", genericComputer.Type);
            Console.WriteLine("         Speed: {0}", genericComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("     IBM Computer Class: ");
            var ibmComputer = computerFactory.GetComputer(ComputerType.IBMComputer);

            Console.WriteLine("         Type: {0}", ibmComputer.Type);
            Console.WriteLine("         Speed: {0}", ibmComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("     COMPAQ Computer Class: ");
            var compaqComputer = computerFactory.GetComputer(ComputerType.COMPAQComputer);

            Console.WriteLine("         Type: {0}", compaqComputer.Type);
            Console.WriteLine("         Speed: {0}", compaqComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
