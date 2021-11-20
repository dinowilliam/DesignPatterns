using FactoryPattern.Contracts;

namespace FactoryPattern.Concretes {
    public class COMPAQComputerProduct : IComputer {
        
        public ComputerType Type { get => ComputerType.COMPAQComputer; set => value = Type; }
        public int SpeedMHZ { get => 2000; set => value = SpeedMHZ; }

    }
}
