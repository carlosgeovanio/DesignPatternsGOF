/* 
 * Why would we even use Singleton?
 * Logging, drives, settings, etc. Often need only of a kind. 
 * Maybe you want to update a setting and it be made globally.
 *
 * Reasons NOT to:
 *  - Unit Testig
 *	- Thread Safety
 *	- Maybe a simples static class would be better?
 *	- Violates SRP
*/

namespace DesignPatternsGOF.Singleton
{
    public class Singleton
    {
        protected Singleton() { }
        static Singleton? instancce;
        public string Setting { get; set; } = "Foo bar baz";

        public static Singleton Instance()
        {
            if (instancce is null)
            {
                instancce = new Singleton();
            }
            return instancce;
        }
    }
}
