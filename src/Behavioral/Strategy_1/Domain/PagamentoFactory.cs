using Strategy_1.Domain.ConcreteStrategy;
using Strategy_1.Domain.Facades;
using Strategy_1.Domain.Interfaces;
using Strategy_1.ExternalService;

namespace Strategy_1.Domain
{
    public class PagamentoFactory
    {
        public static IPagamento CriarPagamento(TipoPagamento tipoPagamento)
        {
            return tipoPagamento switch
            {
                TipoPagamento.CartaoCredito => new PagamentoCartaoCreditoService(
                                               new PagamentoCartaoCreditoFacade(
                                               new PayPalGateway(),
                                               new ConfigurationManager())),
                TipoPagamento.Boleto => new PagamentoBoletoService(new PagamentoBoletoFacade()),
                TipoPagamento.TransferenciaBancaria => new PagamentoTransferenciaService(new PagamentoTransferenciaFacade()),
                _ => throw new ApplicationException("Meio de Pagamento não conhecido"),
            };
        }
    }
}