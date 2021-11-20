using FactoryPattern.Contracts;

namespace FactoryPattern.Concretes {
    public class ComputerProduct : IComputer {        
        public string Type { get => "Generic Computer"; }
        public int SpeedMHZ { get => 1000; set => value = SpeedMHZ; }
    }
}
