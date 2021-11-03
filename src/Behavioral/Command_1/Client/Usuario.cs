using Command_1.Command;
using Command_1.ConcreteCommand;

namespace Command_1.Client
{
    public class Usuario
    {
        private readonly Calculadora _calculadora = new();
        private readonly List<Commander> _commands = new();
        private int _total;

        public void Adicionar(char operador, int valor)
        {
            Commander command = new CalculadoraCommand(_calculadora, operador, valor);
            command.Executar();

            _commands.Add(command);
            _total++;
        }

        public void Reexecutar(int niveis)
        {
            Console.WriteLine($"\n---- Retornando {niveis} níveis ");

            for (var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine($"\n---- Desfazendo {niveis} níveis ");

            for (var i = 0; i < niveis; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}
