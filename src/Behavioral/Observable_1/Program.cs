using Observable_1.ConcreteObserver;
using Observable_1.ConcreteSubject;

Console.WriteLine("*** Observable 1 ***");
Console.WriteLine();

var joao = new Observer("João");
var maria = new Observer("Maria");
var paulo = new Observer("Paulo");

var amazon = new PapelBovespa("Amazon", GetNextRandomValue());
var microsoft = new PapelBovespa("Microsoft", GetNextRandomValue());

amazon.Subscribe(joao);
amazon.Subscribe(maria);

microsoft.Subscribe(maria);
microsoft.Subscribe(paulo);

Console.WriteLine();
Console.WriteLine("------------------------------");
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    amazon.Valor = GetNextRandomValue();
    microsoft.Valor = GetNextRandomValue();

    if (i == 4)
    {
        amazon.UnSubscribe(maria);
        Console.WriteLine();
    }
}

static decimal GetNextRandomValue()
{
    var random = new Random().Next(141421, 314160);
    return random / (decimal)100000.00;
}