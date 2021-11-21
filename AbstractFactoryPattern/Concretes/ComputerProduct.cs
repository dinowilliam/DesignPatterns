﻿using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern.Concretes {
    public class ComputerProduct : IComputer {
        public ComputerType Type { get => ComputerType.GenericComputer; set => value = Type; }
        public int SpeedMHZ { get => 1000; set => value = SpeedMHZ; }
    }
}
