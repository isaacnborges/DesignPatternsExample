using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteProducts
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro PEQUENO - Modelo {veiculo.Modelo}");
        }
    }
}
