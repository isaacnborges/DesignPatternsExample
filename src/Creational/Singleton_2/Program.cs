using Singleton_2;

Console.WriteLine("*** Singleton 2 ***");
Console.WriteLine();

var s1 = Singleton.GetInstance();
var s2 = Singleton.GetInstance();

if (s1 == s2)
    Console.WriteLine("Singleton works, both variables contain the same instance.");
else
    Console.WriteLine("Singleton failed, variables contain different instances.");