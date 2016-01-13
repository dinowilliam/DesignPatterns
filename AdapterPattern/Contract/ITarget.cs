
namespace AdapterPattern.Contract
{
    /// <summary>
    /// A interface that specifie a contract (a beheviour expected by a class) to Client class
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// The method ModemReponse is one of the clauses of ITarget contract, the Client class expected this method with a string returns
        /// </summary>
        /// <returns>Return the expected modem string response</returns>        
        string ModemResponse();
    }
}
