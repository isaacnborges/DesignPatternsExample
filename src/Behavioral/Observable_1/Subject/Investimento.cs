namespace Observable_1.Subject
{
    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObserver> _observadores = new();
        public string Empresa { get; }
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;

                _valor = value;
                Notificar();
            }
        }

        protected Investimento(string empresa, decimal valor)
        {
            Empresa = empresa;
            _valor = valor;
        }

        public void Subscribe(IObserver observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} está recebendo atualizãções de {Empresa}");
        }

        public void UnSubscribe(IObserver observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} NÃO está recebendo atualizãções de {Empresa}");
        }

        private void Notificar()
        {
            foreach (var observer in _observadores)
            {
                observer.Notificar(this);
            }

            Console.WriteLine("");
        }
    }
}
