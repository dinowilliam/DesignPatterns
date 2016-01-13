using AdapterPattern.Contract;
using AdapterPattern.Resources;

namespace AdapterPattern
{
    /// <summary>
    /// The adapter class that inherits from the OldSystem class and adapts (do a darwin) this class to ITarget contract
    /// </summary>
    public class Adapter : OldSystem, ITarget
    {
        /// <summary>
        /// The adpater constructor
        /// </summary>
        public Adapter() { }
        
        /// <summary>
        /// The method that are specified in the ITarget contract and are the beheviour expected by the Client class
        /// </summary>
        /// <returns>Return the string reponse from the modem</returns>
        public string ModemResponse()
        {
           double modemData;
           GetMdmDataFromResolver(out modemData);

           return modemData.ToString();
        }
    }
}
