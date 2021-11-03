namespace Strategy_1.Domain.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}