using FactoryMethod_1.Product;

namespace FactoryMethod_1.ConcreteProduct
{
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connecntion = new Connection(ConnectionString);
            connecntion.Open();

            return connecntion;
        }
    }
}
