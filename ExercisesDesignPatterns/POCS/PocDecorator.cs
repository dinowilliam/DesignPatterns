using DecoratorPattern;
using System;

namespace ExercisesDesignPatterns.POCS
{
    public class PocDecorator
    {
        Fish fish;
        GoldenFish goldenFish;
        TroutFish troutFish;
        CarpeFish carpeFish;
        MagiKarpFish magiKarpFish;
        Gyarados gyarados;


        public PocDecorator()
        {
            fish = new Fish("    I'm a fish");
            goldenFish = new GoldenFish(fish);
            troutFish = new TroutFish(goldenFish);
            carpeFish = new CarpeFish(troutFish);
            magiKarpFish = new MagiKarpFish(carpeFish);
            gyarados = new Gyarados(magiKarpFish);
        }

        public void StartDecoratorTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|                Exercise about Decorator Design Pattern                         |");
            Console.WriteLine("|******************************************************************************|");

            Console.WriteLine(" Fish Class: ");

            Console.WriteLine(fish.Fishname);
            fish.Eat();
            fish.Swim();
            fish.Rest();

            Console.WriteLine("  ");
            Console.WriteLine(" Golden Fish Class: ");

            Console.WriteLine(goldenFish.Fishname);
            goldenFish.Eat();
            goldenFish.Swim();
            goldenFish.Rest();

            Console.WriteLine("  ");
            Console.WriteLine(" Trout Fish Class: ");

            Console.WriteLine(troutFish.Fishname);
            troutFish.Eat();
            troutFish.Swim();
            troutFish.Rest();

            Console.WriteLine("  ");
            Console.WriteLine(" Carpe Fish Class: ");

            Console.WriteLine(carpeFish.Fishname);
            carpeFish.Eat();
            carpeFish.Swim();
            carpeFish.Rest();

            Console.WriteLine("  ");
            Console.WriteLine(" MagiKarp Class: ");

            Console.WriteLine(magiKarpFish.Fishname);
            magiKarpFish.Eat();
            magiKarpFish.Swim();
            magiKarpFish.Rest();

            Console.WriteLine("  ");
            Console.WriteLine(" Gyarados Class: ");

            Console.WriteLine(gyarados.Fishname);
            gyarados.Eat();
            gyarados.Swim();
            gyarados.Rest();

            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
