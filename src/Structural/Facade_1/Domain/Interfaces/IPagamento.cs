using Facade_1.Domain.Models;

namespace Facade_1.Domain.Interfaces
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
