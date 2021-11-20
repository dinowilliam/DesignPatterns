using System;

namespace DecoratorPattern
{
    public class GoldenFish : Fish {
        
        private Fish fishWrapped;

        public GoldenFish(Fish fish) : base(fish.Fishname) {

            this.fishWrapped = fish;
            this.fishWrapped.fishname = "   Golden Fish Name!";

        }        

        public override void Eat() {

            Console.WriteLine("     Golden Fish Eating!");

        }

        public override void Swim() {

            Console.WriteLine("     Golden Fish Swiming!");

        }

        public override void Rest() {

            Console.WriteLine("     Golden Fish Resting!");

        }
    }
}
