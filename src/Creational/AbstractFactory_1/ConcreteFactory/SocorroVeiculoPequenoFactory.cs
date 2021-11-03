using AbstractFactory_1.AbstractFactory;
using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Creators;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteFactory
{
    public class SocorroVeiculoPequenoFactory : AutoSocorroAbstractFactory
    {
        public override Guincho CriarGuincho()
        {
            return GuinchoCreator.Create(Porte.Pequeno);
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            return VeiculoCreator.Create(modelo, porte);
        }
    }
}
