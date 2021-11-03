using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Client;
using AbstractFactory_1.Creators;
using AbstractFactory_1.Enums;

Console.WriteLine("*** Abstract Factory 1 ***");
Console.WriteLine();

var veiculosSocorro = new List<Veiculo>
{
    VeiculoCreator.Create("Celta", Porte.Pequeno),
    VeiculoCreator.Create("Jetta", Porte.Medio),
    VeiculoCreator.Create("BMW X6", Porte.Grande),
    VeiculoCreator.Create("Palio", Porte.Pequeno),
    VeiculoCreator.Create("Fusion", Porte.Medio),
    VeiculoCreator.Create("Compass", Porte.Grande),
};

veiculosSocorro.ForEach(veiculo => AutoSocorro.CriarAutoSocorro(veiculo).RealizarAtendimento());