using System;

namespace AdapterPattern.Resources
{
    /// <summary>
    /// A Class that represents a system without a pattern or architecture (the adaptee) that are the system that needs a adapter to exchange
    /// data with the client class, you cannot change a old class that are used in a entire system, the better aproach is use the Adapter Pattern
    /// </summary>
    public class OldSystem
    {
        private int vldFromModemData;
        private int mdmVersion;

        /// <summary>
        /// The OldSystem class constructor
        /// </summary>
        public OldSystem()
        {
            vldFromModemData = 0;
            mdmVersion = 100;
        }

        /// <summary>
        /// A wrong way to return data from a method
        /// </summary>
        /// <param name="modemData">A param that are used to return data</param>
        public void GetMdmDataFromResolver(out double modemData)
        {
            modemData = ((double)vldFromModemData + (double)mdmVersion) *  Math.PI;
            modemData = modemData / Math.Sqrt(modemData);
        }
        
    }
}
