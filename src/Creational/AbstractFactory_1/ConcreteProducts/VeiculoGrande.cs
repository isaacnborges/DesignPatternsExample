using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteProducts
{
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
        { }
    }
}
