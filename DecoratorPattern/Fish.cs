using DecoratorPattern.Contracts;
using System;

namespace DecoratorPattern {
    public class Fish : IFish    {

        public string fishname;

        public Fish(string fishname) {
            this.fishname = fishname;
        }

        public virtual void Eat() {
            Console.WriteLine("     Eating!");
        }

        public virtual void Swim() {
            Console.WriteLine("     Swiming!");
        }

        public virtual void Rest() {
            Console.WriteLine("     Resting!");
        }

        public string Fishname {
            get => this.fishname;
            set => this.fishname = value;
        }
    }
}
