using ExercisesDesignPatterns.Resources;
using SingletonPattern.Default;
using SingletonPattern.Generics;
using System;

namespace ExercisesDesignPatterns.POCS
{
    public class PocSingleton
    {
        protected DefaultSingleton Ds1;
        protected DefaultSingleton Ds2;

        protected Engine Engine1;        
        protected Engine Engine2;

        protected Turbine Turbine1;
        protected Turbine Turbine2;

        public PocSingleton()
        {
            Ds1 = DefaultSingleton.Instance;
            Ds2 = DefaultSingleton.Instance;

            Engine1 = GenericsSingleton<Engine>.Instance;
            Turbine1 = GenericsSingleton<Turbine>.Instance;

            Engine2 = GenericsSingleton<Engine>.Instance;
            Turbine2 = GenericsSingleton<Turbine>.Instance;            
        }

        public void StartDefaultSingletonTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|            Exercise about Singleton Design Pattern  - Default                |");
            Console.WriteLine("|******************************************************************************|");
         
            if (Ds1 == Ds2)
            {
                Console.WriteLine(" The two classes are equal " +
                                  "\n Hash Code from ds1: " + Ds1.GetHashCode() +
                                  "\n Hash Code from ds2: " + Ds1.GetHashCode());
            }

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
        }

        public void StartGenericsSingletonTest()
        {            
            Engine1.QuantityOfValves = 16;
            Turbine1.QuantityOfBlades = 360;

            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|            Exercise about Singleton Design Pattern  - Generics               |");
            Console.WriteLine("|******************************************************************************|");

            Console.WriteLine(" Engine 1 Number of Valves: " + Engine1.QuantityOfValves.ToString() +
                              "\n Engine 2 Number of Valves: " + Engine2.QuantityOfValves.ToString() +
                              "\n And the hash code from Engine 1: " + Engine1.GetHashCode() +
                              "\n And the hash code from Engine 2: " + Engine2.GetHashCode());
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine(" Turbine 1 Number of Valves: " + Turbine1.QuantityOfBlades.ToString() +
                              "\n Turbine 2 Number of Valves: " + Turbine2.QuantityOfBlades.ToString() +
                              "\n And the hash code from Engine 1: " + Turbine1.GetHashCode() +
                              "\n And the hash code from Engine 2: " + Turbine2.GetHashCode());
            Console.WriteLine("\n|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
        }
    }
}
