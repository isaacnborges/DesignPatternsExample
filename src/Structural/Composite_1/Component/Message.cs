using System.Collections;

namespace Composite_1.Component
{
    public class Message : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _lista = new();

        public string Nome { get; set; }

        public Message(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);

            foreach (var mensagem in _lista)
            {
                mensagem.ExibirMensagens(sub + 2);
            }
        }

        public void AdicionarFilha(IMessage filha)
        {
            _lista.Add(filha);
        }

        public void RemoverFilha(IMessage filha)
        {
            _lista.Remove(filha);
        }

        public IMessage ObterFilha(int index)
        {
            return _lista[index];
        }

        public IMessage ObterFilha(string nome)
        {
            return _lista.First(c => c.Nome == nome);
        }

        public IEnumerable<IMessage> ObterLista()
        {
            return _lista;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }
    }
}
