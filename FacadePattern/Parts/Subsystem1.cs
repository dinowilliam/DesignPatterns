using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Parts
{
    public enum EnumSubsystem1 { Enum1 = 0, Enum2 = 1, Enum3 = 2 }

    public class Subsystem1
    {
        public EnumSubsystem1 ActualEnum;        
        public int Field1;
        public int Field2;
        public int Field3;
    }
}
