using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Parts
{
    public enum State { Open=0, Close=1, Stuck=2}

    public class Valve
    {
        /// <summary>
        /// Actual state of valve
        /// </summary>
        public State ActualState;

        /// <summary>
        /// In Days
        /// </summary>
        public int Durability;
    }
}
