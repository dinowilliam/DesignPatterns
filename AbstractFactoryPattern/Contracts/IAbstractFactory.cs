namespace AbstractFactoryPattern.Contracts
{
    internal interface IAbstractFactory {

        IComputer GetGenericComputer();
        IComputer GetIBMComputer();        
        IComputer GetCOMPAQComputer();

    }
}
