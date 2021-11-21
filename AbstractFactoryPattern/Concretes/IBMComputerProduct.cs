using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Concretes {
    public class IBMComputerProduct : IComputer {

        public ComputerType Type { get => ComputerType.IBMComputer; set => value = Type; }
        public int SpeedMHZ { get => 2500; set => value = SpeedMHZ; }
    }
}
