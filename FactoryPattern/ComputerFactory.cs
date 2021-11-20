using FactoryPattern.Concretes;
using FactoryPattern.Contracts;
using System;

namespace FactoryPattern
{
    public class ComputerFactory {
       
            public IComputer GetComputer(int type) {

                switch (type) {
                    
                    case 0:
                        return new ComputerProduct();

                    case 1:
                        return new IBMComputerProduct();

                    case 2:
                        return new COMPAQComputerProduct();

                    default:
                        throw new NotSupportedException();
                }
            
            }
    }
}
