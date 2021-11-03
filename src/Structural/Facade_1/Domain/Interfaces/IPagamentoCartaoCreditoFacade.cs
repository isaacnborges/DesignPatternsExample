using Facade_1.Domain.Models;

namespace Facade_1.Domain.Interfaces
{
    public interface IPagamentoCartaoCreditoFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
