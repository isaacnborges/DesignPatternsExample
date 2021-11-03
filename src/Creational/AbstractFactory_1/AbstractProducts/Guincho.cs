using AbstractFactory_1.Enums;

namespace AbstractFactory_1.AbstractProducts
{
    public abstract class Guincho
    {
        public abstract void Socorrer(Veiculo veiculo);
        public Porte Porte { get; set; }

        protected Guincho(Porte porte)
        {
            Porte = porte;
        }
    }
}
