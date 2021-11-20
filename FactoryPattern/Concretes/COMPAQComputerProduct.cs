using FactoryPattern.Contracts;

namespace FactoryPattern.Concretes {
    public class COMPAQComputerProduct : IComputer {
        
        public string Type { get => "COMPAQ Presário"; }
        public int SpeedMHZ { get => 2000; set => value = SpeedMHZ; }
    }
}
