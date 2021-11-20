using System;

namespace DecoratorPattern {
    public class TroutFish : GoldenFish {
        
        private GoldenFish goldenFishWrapped;

        public TroutFish(GoldenFish goldenFish) : base(goldenFish) {

            this.goldenFishWrapped = goldenFish;
            this.goldenFishWrapped.fishname = "   Trout Fish Name!";
        }        

        public override void Eat() {

            Console.WriteLine("     Trout Fish Eating!");

        }

        public override void Swim() {

            Console.WriteLine("     Trout Fish Swiming!");

        }

        public override void Rest() {

            Console.WriteLine("     Trout Fish Resting!");

        }
    }
}
