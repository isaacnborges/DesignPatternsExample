using Facade_1.Domain.Facade;
using Facade_1.Domain.Models;
using Facade_1.Domain.Services;
using Facade_1.ExternalService;

Console.WriteLine("*** Facade 1 ***");
Console.WriteLine();

var produtos = new List<Produto>
{
    new Produto("Tenis Adidas", new Random().Next(500)),
    new Produto("Camisa Boliche", new Random().Next(500)),
    new Produto("Raquete Tenis", new Random().Next(500))
};

var pedido = new Pedido(Guid.NewGuid(), produtos);

var pagamento = new Pagamento
{
    CartaoCredito = "5555 2222 5555 9999"
};

// Usar DI
var pagamentoService = new PagamentoCartaoCreditoService(new PagamentoCartaoCreditoFacade(new PayPalGateway(), new ConfigurationManager()));

var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

Console.WriteLine(pagamentoResult.Status);