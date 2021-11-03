using Observable_1.Subject;

namespace Observable_1
{
    public interface IObserver
    {
        string Nome { get; }
        void Notificar(Investimento investimento);
    }
}
