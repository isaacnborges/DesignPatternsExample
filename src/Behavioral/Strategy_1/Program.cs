using Strategy_1.Domain;
using Strategy_1.Domain.ConcreteStrategy;
using Strategy_1.Domain.Facades;
using Strategy_1.Domain.Models;
using Strategy_1.Domain.Strategy;
using Strategy_1.ExternalService;

Console.WriteLine("*** Strategy 1 ***");
Console.WriteLine();

var produtos = new List<Produto>
{
    new Produto("Tenis Adidas", new Random().Next(500)),
    new Produto("Camisa Boliche", new Random().Next(500)),
    new Produto("Raquete Tenis", new Random().Next(500))
};

var pedido = new Pedido(Guid.NewGuid(), produtos);

var tipoPagamentoCredito = new Pagamento
{
    TipoPagamento = TipoPagamento.CartaoCredito,
    CartaoCredito = "5555 2222 5555 9999"
};

var tipoPagamentoBoleto = new Pagamento
{
    TipoPagamento = TipoPagamento.Boleto
};

var tipoPagamentoTransferencia = new Pagamento
{
    TipoPagamento = TipoPagamento.TransferenciaBancaria,
    ConfirmacaoTransferencia = "Confirma"
};

SimpleExecute(pedido, tipoPagamentoCredito, tipoPagamentoBoleto, tipoPagamentoTransferencia);
ExecuteWithFactory(pedido, tipoPagamentoCredito, tipoPagamentoBoleto, tipoPagamentoTransferencia);

void SimpleExecute(Pedido pedido, Pagamento tipoPagamentoCredito, Pagamento tipoPagamentoBoleto, Pagamento tipoPagamentoTransferencia)
{
    var pedidoCredito = new PedidoService(
                           new PagamentoCartaoCreditoService(
                           new PagamentoCartaoCreditoFacade(
                           new PayPalGateway(),
                           new ConfigurationManager())));
    var pagamentoCredito = pedidoCredito.RealizarPagamento(pedido, tipoPagamentoCredito);
    Console.WriteLine(pagamentoCredito.Status);

    Console.WriteLine("-------------------------------------------------------");

    var pedidoBoleto = new PedidoService(
                           new PagamentoBoletoService(
                           new PagamentoBoletoFacade()));

    var pagamentoBoleto = pedidoBoleto.RealizarPagamento(pedido, tipoPagamentoBoleto);
    Console.WriteLine(pagamentoBoleto.Status);

    Console.WriteLine("-------------------------------------------------------");

    var pedidoTransferencia = new PedidoService(
                                  new PagamentoTransferenciaService(
                                  new PagamentoTransferenciaFacade()));

    var pagamentoTransferencia = pedidoTransferencia.RealizarPagamento(pedido, tipoPagamentoTransferencia);
    Console.WriteLine(pagamentoTransferencia.Status);

    Console.WriteLine("-------------------------------------------------------");
}

void ExecuteWithFactory(Pedido pedido, Pagamento tipoPagamentoCredito, Pagamento tipoPagamentoBoleto, Pagamento tipoPagamentoTransferencia)
{
    var pedidoCredito2 = new PedidoService(PagamentoFactory.CriarPagamento(tipoPagamentoCredito.TipoPagamento));
    var pagamentoCredito2 = pedidoCredito2.RealizarPagamento(pedido, tipoPagamentoCredito);
    Console.WriteLine(pagamentoCredito2.Status);

    Console.WriteLine("-------------------------------------------------------");

    var pedidoBoleto2 = new PedidoService(PagamentoFactory.CriarPagamento(tipoPagamentoBoleto.TipoPagamento));
    var pagamentoBoleto2 = pedidoBoleto2.RealizarPagamento(pedido, tipoPagamentoBoleto);
    Console.WriteLine(pagamentoBoleto2.Status);

    Console.WriteLine("-------------------------------------------------------");

    var pedidoTransferencia2 = new PedidoService(PagamentoFactory.CriarPagamento(tipoPagamentoTransferencia.TipoPagamento));
    var pagamentoTransferencia2 = pedidoTransferencia2.RealizarPagamento(pedido, tipoPagamentoTransferencia);
    Console.WriteLine(pagamentoTransferencia2.Status);
}