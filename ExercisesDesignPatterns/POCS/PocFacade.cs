using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern;

namespace ExercisesDesignPatterns.POCS
{
    public class PocFacade
    {
        Facade facadePattern;

        public PocFacade()
        {
            facadePattern = new Facade();
        }

        public void StartFacadeTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                   Exercise about Facade Design Pattern                       |");
            Console.WriteLine("|******************************************************************************|");

            facadePattern.CreateFacadeOperationMarketGarden();

            Console.WriteLine(" From method CreateFacadeOperationMarketGarden() ");
            Console.WriteLine(" Qtd From List Subsystem 1: " + facadePattern.ListSubsystem1.Count);
            Console.WriteLine(" Qtd From List Subsystem 2: " + facadePattern.ListSubsystem2.Count);
            Console.WriteLine(" Qtd Subsystem 2   Field 1: " + facadePattern.Subsystem3.Field1);
            Console.WriteLine(" Qtd Subsystem 2   Field 2: " + facadePattern.Subsystem3.Field2);
            Console.WriteLine(" Qtd Subsystem 2   Field 3: " + facadePattern.Subsystem3.Field3);
            Console.WriteLine(" Qtd Subsystem 2   Field 4: " + facadePattern.Subsystem3.Field4);

            facadePattern.CreateFacadeOperationOverlord();

            Console.WriteLine("\n From method CreateFacadeOperationOverlord() ");
            Console.WriteLine(" Qtd From List Subsystem 1: " + facadePattern.ListSubsystem1.Count);
            Console.WriteLine(" Qtd From List Subsystem 2: " + facadePattern.ListSubsystem2.Count);
            Console.WriteLine(" Qtd Subsystem 2   Field 1: " + facadePattern.Subsystem3.Field1);
            Console.WriteLine(" Qtd Subsystem 2   Field 2: " + facadePattern.Subsystem3.Field2);
            Console.WriteLine(" Qtd Subsystem 2   Field 3: " + facadePattern.Subsystem3.Field3);
            Console.WriteLine(" Qtd Subsystem 2   Field 4: " + facadePattern.Subsystem3.Field4);            

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();

        }
    }
}
