/*************************************************************************************************************************************************
 * Develop by William Ferreira de Paula
 * In 06/01/2015
 * Exercices and Concept Proves
 * Facade Design Pattern 
 *************************************************************************************************************************************************/

using System.Collections.Generic;
using FacadePattern.Parts;

namespace FacadePattern
{
    public class EngineFacade
    {
        public List<Valve> Valves;
        public List<Gear> Gears;
        public FuelBomb FuelBomb;

        public EngineFacade()
        {
            Valves = new List<Valve>();
            Gears = new List<Gear>();
            FuelBomb = new FuelBomb();
        }

        public void CreateEngine()
        {
            Valves = new List<Valve>();
            Gears = new List<Gear>();
            FuelBomb = new FuelBomb();

            this.FuelBomb.ActualState = FuelBombState.Off;
            this.FuelBomb.Durability = 300;
            this.FuelBomb.QuantityOfFuelPerSecond = 3;

            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Close, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Stuck, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });
            this.Valves.Add(new Valve { ActualState = State.Open, Durability = 10 });

            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });
            this.Gears.Add(new Gear { Diameter = 40, Durability = 10, NumberOfTeeths = 300 });


        }
    }
}
