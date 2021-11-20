using System;

namespace DecoratorPattern {
    public class CarpeFish : TroutFish {
        
        private TroutFish troutFishWrapped;

        public CarpeFish(TroutFish troutFish) : base(troutFish) {

            this.troutFishWrapped = troutFish;
            this.troutFishWrapped.fishname = "   Carpe Fish Name!";
        }        

        public override void Eat() {

            Console.WriteLine("     Carpe Fish Eating!");

        }

        public override void Swim() {

            Console.WriteLine("     Carpe Fish Swiming!");

        }

        public override void Rest() {

            Console.WriteLine("     Carpe Fish Resting!");

        }
    }
}
