using Command_1.Command;

namespace Command_1.ConcreteCommand
{
    internal class CalculadoraCommand : Commander
    {
        private readonly char _operador;
        private readonly decimal _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(Calculadora calculadora, char operador, decimal valor)
        {
            _calculadora = calculadora;
            _operador = operador;
            _valor = valor;
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }

        public override void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _valor);
        }

        private static char Desfazer(char operador)
        {
            switch (operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Operador desconhecido");
            }
        }
    }
}
