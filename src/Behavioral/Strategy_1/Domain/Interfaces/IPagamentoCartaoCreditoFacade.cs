using Strategy_1.Domain.Models;

namespace Strategy_1.Domain.Interfaces
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
