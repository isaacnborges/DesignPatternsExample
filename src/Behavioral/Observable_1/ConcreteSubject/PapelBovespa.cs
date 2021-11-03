using Observable_1.Subject;

namespace Observable_1.ConcreteSubject
{
    public class PapelBovespa : Investimento
    {
        public PapelBovespa(string empresa, decimal preco) : base(empresa, preco)
        {
        }
    }
}
