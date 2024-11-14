class Program
{
static void Main(string[] args)
{
// Získání instance Singletonu a volání metody
Singleton singleton = Singleton.Instance;
singleton.DoSomething();
// Získání další instance Singletonu a volání metody
Singleton anotherSingleton = Singleton.Instance;
anotherSingleton.DoSomething();
// Ověření, že obě instance jsou shodné
if (singleton == anotherSingleton)
{
Console.WriteLine("Both instances are the same.");
}
}
}