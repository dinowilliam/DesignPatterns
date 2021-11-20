namespace FactoryPattern.Contracts {
    public interface IComputer {
        string Type { get; }
        int SpeedMHZ { get; set; }
    }
}
