namespace Facade_1.Domain.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }

        public Pedido(Guid id, List<Produto> produtos)
        {
            Id = id;
            Produtos = produtos;
        }
    }
}