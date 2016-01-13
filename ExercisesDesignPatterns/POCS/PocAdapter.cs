using System;
using AdapterPattern;
using AdapterPattern.Contract;
using AdapterPattern.Resources;

namespace ExercisesDesignPatterns.POCS
{
    public class PocAdapter
    {
        ITarget adapterReceive;
        Client clientThatUseAdapter;

        public PocAdapter()
        {
            adapterReceive = new Adapter();
            clientThatUseAdapter = new Client(adapterReceive);            
        }

        public void StartAdapterTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Adapter Design Pattern                         |");
            Console.WriteLine("|******************************************************************************|");
            
            var value = clientThatUseAdapter.CallBooleanCheckOfModemStringResponse();
            
            if (value)
            {
                Console.WriteLine(" The valor of Adapter Client Return are " + value);
            }

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
