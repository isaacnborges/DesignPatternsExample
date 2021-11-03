using Command_2;

Console.WriteLine("*** Command 2 ***");
Console.WriteLine();

var invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("Say Hello!"));
var receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

invoker.DoSomethingImportant();