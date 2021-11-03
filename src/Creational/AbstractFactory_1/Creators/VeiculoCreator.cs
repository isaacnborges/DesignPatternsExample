using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.ConcreteProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.Creators
{
    public class VeiculoCreator
    {
        public static Veiculo Create(string modelo, Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new VeiculoPequeno(modelo, porte),
                Porte.Medio => new VeiculoMedio(modelo, porte),
                Porte.Grande => new VeiculoGrande(modelo, porte),
                _ => throw new ApplicationException("Porte de veiculo desconhecido."),
            };
        }
    }
}
