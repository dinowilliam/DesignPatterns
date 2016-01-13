using System;
using AdapterPattern.Contract;

namespace AdapterPattern.Resources
{
    /// <summary>
    /// The client class that consumes the adapter, this class simulates a scenario of integration with a old system with many classes of modens 
    /// that cannot be changed, for this you assume the creation of many adapter are necessary and create a contract called ITarget that speciefed
    /// a beheviour expected for any adapter 
    /// </summary>
    public class Client : IClient
    {
        private ITarget _modem;

        /// <summary>
        /// The Client class constructor that implements a Depedency Injection Pattern this are a flexible way that depends in the abstractions 
        /// of adapter and can recieve any adapter create with this inherince
        /// </summary>
        /// <param name="activeModem"></param>
        public Client(ITarget activeModem)
        {
            _modem = activeModem;
        }

        /// <summary>
        /// A method that expected the modem response to test
        /// </summary>
        /// <returns>Return true or false</returns>
        public bool CallBooleanCheckOfModemStringResponse()
        {
            return !String.IsNullOrWhiteSpace(_modem.ModemResponse());
        }
        
    }
}
