using System;

namespace DecoratorPattern {
    public class MagiKarpFish : CarpeFish {
        
        private CarpeFish carpeFishWrapped;

        public MagiKarpFish(CarpeFish carpeFish) : base(carpeFish) {

            this.carpeFishWrapped = carpeFish;
            this.carpeFishWrapped.fishname = "   MagiKarp Name!";
        }        

        public override void Eat() {

            Console.WriteLine("     MagiKarp Eating!");

        }

        public override void Swim() {

            Console.WriteLine("     MagiKarp Swiming!");

        }

        public override void Rest() {

            Console.WriteLine("     MagiKarp Resting!");

        }
    }
}
