using System;
using CommandPattern.Contracts;


namespace CommandPattern
{
    public class Command : ICommand {
        public Command() { 

        }
        
        public void Execute() {
            Console.WriteLine("     Command Pattern is Working");
        }
    }
}
