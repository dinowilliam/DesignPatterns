namespace AbstractFactoryPattern.Contracts {

    public enum ComputerType : int {
        
        GenericComputer = 0,
        IBMComputer = 1,
        COMPAQComputer = 2
    }

    public interface IComputer {
        ComputerType Type { get; set; }
        int SpeedMHZ { get; set; }
    }
}
