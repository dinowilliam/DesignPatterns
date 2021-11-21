using AbstractFactoryPattern.Concretes;
using AbstractFactoryPattern.Contracts;

namespace AbstractFactoryPattern
{
    public class ConcreteFactory : IAbstractFactory {
        
        public IComputer GetCOMPAQComputer() {

            return new COMPAQComputerProduct();
        }

        public IComputer GetGenericComputer() {

            return new ComputerProduct();
        }

        public IComputer GetIBMComputer() {

            return new IBMComputerProduct();
        }
    }
}
