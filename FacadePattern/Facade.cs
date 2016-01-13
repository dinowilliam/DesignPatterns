/*************************************************************************************************************************************************
 * Develop by William Ferreira de Paula
 * In 05/01/2015
 * Exercices and Concept Proves
 * Facade Design Pattern 
 *************************************************************************************************************************************************/

using System.Collections.Generic;
using FacadePattern.Parts;

namespace FacadePattern
{
    public enum FacadeState { Facade1 = 1, Facade2 = 1, Facade3 = 2 }

    public class Facade
    {
        public FacadeState ActualState;
        public List<Subsystem1> ListSubsystem1;
        public List<Subsystem2> ListSubsystem2;
        public Subsystem3 Subsystem3;

        public void CreateFacadeOperationMarketGarden()
        {
            ListSubsystem1 = new List<Subsystem1>();            
            ListSubsystem2 = new List<Subsystem2>();
            Subsystem3 = new Subsystem3();

            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });

            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });

            ActualState = FacadeState.Facade1; 
        }

        public void CreateFacadeOperationOverlord()
        {
            ListSubsystem1 = new List<Subsystem1>();
            ListSubsystem2 = new List<Subsystem2>();
            Subsystem3 = new Subsystem3();

            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });
            ListSubsystem1.Add(new Subsystem1 { ActualEnum = EnumSubsystem1.Enum1, Field1 = 0, Field2 = 0, Field3 = 0 });

            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });
            ListSubsystem2.Add(new Subsystem2 { EnumSubsystem2 = EnumSubsystem2.Enum1, Field1 = 0, Field2 = 0, Field3 = 0, Field4 = 0 });

            ActualState = FacadeState.Facade2;  
        }
    
    }
}
