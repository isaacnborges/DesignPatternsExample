using AbstractFactory_1.AbstractProducts;
using AbstractFactory_1.Enums;

namespace AbstractFactory_1.ConcreteProducts
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte)
        { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo carro GRANDE - Modelo {veiculo.Modelo}");
        }
    }
}
