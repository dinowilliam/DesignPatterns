using System;

namespace DecoratorPattern {
    public class Gyarados : MagiKarpFish {
        
        private MagiKarpFish magiKarpFishWrapped;

        public Gyarados(MagiKarpFish magiKarpFish) : base(magiKarpFish) {

            this.magiKarpFishWrapped = magiKarpFish;
            this.magiKarpFishWrapped.fishname = "   Gyarados Name!";
        }        

        public override void Eat() {

            Console.WriteLine("     Gyarados Eating!");

        }

        public override void Swim() {

            Console.WriteLine("     Gyarados Swiming!");

        }

        public override void Rest() {

            Console.WriteLine("     Gyarados Resting!");

        }
    }
}
