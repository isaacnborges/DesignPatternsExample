using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.ConcreteProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.Creators
{
    public class GuinchoCreator
    {
        public static Guincho Create(Porte porte)
        {
            return porte switch
            {
                Porte.Pequeno => new GuinchoPequeno(porte),
                Porte.Medio => new GuinchoMedio(porte),
                Porte.Grande => new GuinchoGrande(porte),
                _ => throw new ApplicationException("Porte de guinho desconhecido"),
            };
        }
    }
}
