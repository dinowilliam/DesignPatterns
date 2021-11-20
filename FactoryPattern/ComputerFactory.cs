using FactoryPattern.Concretes;
using FactoryPattern.Contracts;
using System;

namespace FactoryPattern
{
    public class ComputerFactory {
       
            public IComputer GetComputer(ComputerType type) {

                switch (type) {
                    
                    case ComputerType.GenericComputer:
                        return new ComputerProduct();

                    case ComputerType.IBMComputer:
                        return new IBMComputerProduct();

                    case ComputerType.COMPAQComputer:
                        return new COMPAQComputerProduct();

                    default:
                        throw new NotSupportedException();
                }
            
            }
    }
}
