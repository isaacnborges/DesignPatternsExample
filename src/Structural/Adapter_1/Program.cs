using Adapter_1.Adaptee;
using Adapter_1.Adapter;
using Adapter_1.Client;
using Adapter_1.Target;

Console.WriteLine("*** Adapter 1 ***");
Console.WriteLine();

var pagamentoLogPadrao = new TransacaoService(new Logger());
pagamentoLogPadrao.RealizarTransacao();

Console.WriteLine();

var pagamentoLogCustom = new TransacaoService(new LogAdapter(new LogNetMasterService()));
pagamentoLogCustom.RealizarTransacao();