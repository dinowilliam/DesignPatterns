using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ComputerFactory{
       
            public ComputerProduct GetComputer(int type) {

                switch (type) {
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
