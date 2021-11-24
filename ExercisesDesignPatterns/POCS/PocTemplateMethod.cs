using System;
using AdapterPattern;
using AdapterPattern.Contract;
using AdapterPattern.Resources;
using TemplateMethodPattern;
using TemplateMethodPattern.Resources;

namespace ExercisesDesignPatterns.POCS
{
    public class PocTemplateMethod {

        Graphics graphics;
        Circle circle;
        Line line;

        public PocTemplateMethod() {

            graphics = new Graphics();
            
            circle = new Circle();
            line = new Line();            
        }

        public void StartTemplateMethodTest()
        {
            Console.Clear();
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("|              Exercise about Template Method Design Pattern                   |");
            Console.WriteLine("|******************************************************************************|");

            circle.Radius = 10;
            circle.Center = 55;
            circle.Draw(graphics);

            line.Begin = 125;
            line.End = 26;
            line.Draw(graphics);

            foreach (String item in graphics.List) {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("|******************************************************************************|");
            Console.WriteLine("\n \n \n Press on key to continue... ");
            Console.ReadLine();
            
        }
    }
}
