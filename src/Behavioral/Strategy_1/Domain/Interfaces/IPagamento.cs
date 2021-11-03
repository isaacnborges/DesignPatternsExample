using Strategy_1.Domain.Models;

namespace Strategy_1.Domain.Interfaces
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}