using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.AbstractFactory
{
    public abstract class AutoSocorroAbstractFactory
    {
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
