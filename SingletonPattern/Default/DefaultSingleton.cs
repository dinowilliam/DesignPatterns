/*************************************************************************************************************************************************
 * Develop by William Ferreira de Paula
 * In 05/01/2015
 * Exercices and Concept Proves
 * Singleton Design Pattern 
 *************************************************************************************************************************************************/

namespace SingletonPattern.Default
{
    /// <summary>
    /// Implement of Singleton Pattern 
    /// </summary>
    public class DefaultSingleton
    {
        /// <summary>
        /// The instance global variable that contains the unique object
        /// </summary>
        private static DefaultSingleton _instance;

        /// <summary>
        /// The singleton constructor
        /// </summary>
        public DefaultSingleton() { }

        /// <summary>
        /// The factory method that garanties the criation of a unique object
        /// </summary>
        public static DefaultSingleton Instance{
            
            get{

                if (_instance == null){

                    lock (typeof(DefaultSingleton)){

                        if (_instance == null){

                            _instance = new DefaultSingleton();
                        }
                    }                        
                }

                return _instance;
            }
        }

    }
}
