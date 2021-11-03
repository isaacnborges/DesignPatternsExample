using Strategy_1.Domain.Interfaces;
using Strategy_1.Domain.Models;

namespace Strategy_1.Domain.Strategy
{
    public class PedidoService
    {
        private readonly IPagamento _pagamento;

        public PedidoService(IPagamento pagamento)
        {
            _pagamento = pagamento;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}
