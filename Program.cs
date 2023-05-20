using DesignPatternsGOF.Singleton;

Singleton object1 = Singleton.Instance();
Singleton object2 = Singleton.Instance();

if (object1 == object2)
{
    Console.WriteLine("These objects are the same");
}