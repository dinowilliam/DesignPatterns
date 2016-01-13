/*************************************************************************************************************************************************
 * Develop by William Ferreira de Paula
 * In 05/01/2015
 * Exercices and Concept Proves
 * Singleton Design Pattern 
 *************************************************************************************************************************************************/

namespace SingletonPattern.Generics
{
    /// <summary>
    /// Implement of Singleton Pattern with Generics from C#
    /// </summary>
    public class GenericsSingleton<T> where T: class, new()
    {
        /// <summary>
        /// The instance global variable that contains the unique object
        /// </summary>
        private static T _instance;
      
        /// <summary>
        /// The factory method that garanties the criation of a unique object
        /// </summary>
        public static T Instance
        {            
            get{

                if (_instance == null){

                    lock (typeof(T)){
                        
                        if (_instance == null){
                            _instance = new T();
                        }
                    }                        
                }

                return _instance;
            }
        }

    }
}
