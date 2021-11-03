using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteProducts
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro MEDIO - Modelo {veiculo.Modelo}");
        }
    }
}
