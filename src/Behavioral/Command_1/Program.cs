using Command_1.Client;

Console.WriteLine("*** Command 1 ***");
Console.WriteLine();


var user = new Usuario();

user.Adicionar('+', 100);
Console.ReadKey();
user.Adicionar('-', 50);
Console.ReadKey();
user.Adicionar('*', 10);
Console.ReadKey();
user.Adicionar('/', 2);
Console.ReadKey();

user.Desfazer(4);
Console.ReadKey();

user.Reexecutar(3);