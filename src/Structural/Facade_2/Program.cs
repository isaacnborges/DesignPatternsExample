using Facade_2;

Console.WriteLine("*** Facade 2 ***");
Console.WriteLine();

var subsystem1 = new Subsystem1();
var subsystem2 = new Subsystem2();
var facade = new Facade(subsystem1, subsystem2);
Client.ClientCode(facade);