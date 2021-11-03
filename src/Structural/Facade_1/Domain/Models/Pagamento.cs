using Facade_1.Domain.Enums;

namespace Facade_1.Domain.Models
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}
