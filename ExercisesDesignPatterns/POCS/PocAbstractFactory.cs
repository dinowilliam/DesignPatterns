
using AbstractFactoryPattern;
using System;

namespace ExercisesDesignPatterns.POCS
{
    public class PocAbstractFactory {
        
        ConcreteFactory concreteFactory;

        public PocAbstractFactory() {
            concreteFactory = new ConcreteFactory();
        }

        public void StartAbstractFactoryTest() {

            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|               Exercise about Abstract Factory Design Pattern                 |");
            Console.WriteLine("|******************************************************************************|");

            Console.WriteLine("     ");
            Console.WriteLine("     Generic Computer Class: ");
            var genericComputer = concreteFactory.GetGenericComputer();

            Console.WriteLine("         Type: {0}", genericComputer.Type);
            Console.WriteLine("         Speed: {0}", genericComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("     IBM Computer Class: ");
            var ibmComputer = concreteFactory.GetIBMComputer();

            Console.WriteLine("         Type: {0}", ibmComputer.Type);
            Console.WriteLine("         Speed: {0}", ibmComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("     COMPAQ Computer Class: ");
            var compaqComputer = concreteFactory.GetIBMComputer();

            Console.WriteLine("         Type: {0}", compaqComputer.Type);
            Console.WriteLine("         Speed: {0}", compaqComputer.SpeedMHZ);

            Console.WriteLine("     ");
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
