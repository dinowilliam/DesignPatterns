using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Parts
{
    public enum FuelBombState { Off=0, On=1}

    public class FuelBomb
    {
        public int QuantityOfFuelPerSecond;
        public FuelBombState ActualState;
        public int Durability;
    }
}
