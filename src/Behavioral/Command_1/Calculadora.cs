namespace Command_1
{
    internal class Calculadora
    {
        private decimal _valorAtual;

        public void Operacao(char operador, decimal valor)
        {
            switch (operador)
            {
                case '+': _valorAtual += valor; break;
                case '-': _valorAtual -= valor; break;
                case '*': _valorAtual *= valor; break;
                case '/': _valorAtual /= valor; break;
            }

            Console.WriteLine($"(valor {operador} {valor}) | Valor atual = {_valorAtual}");
        }
    }
}
