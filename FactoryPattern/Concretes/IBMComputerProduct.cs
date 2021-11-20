using FactoryPattern.Contracts;

namespace FactoryPattern.Concretes {
    public class IBMComputerProduct : IComputer {

        public string Type { get => "IBM PC";  }
        public int SpeedMHZ { get => 2500; set => value = SpeedMHZ; }
    }
}
