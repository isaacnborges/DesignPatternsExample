using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteProducts
{
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo, Porte porte) : base(modelo, porte)
        { }
    }
}
