using Observable_1.Subject;

namespace Observable_1.ConcreteObserver
{
    internal class Observer : IObserver
    {
        public string Nome { get; }

        public Observer(string nome)
        {
            Nome = nome;
        }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine($"Notificando {Nome} que {investimento.Empresa} teve preço alterado para {investimento.Valor:C}");
        }
    }
}
