using FactoryMethod_1.Product;

namespace FactoryMethod_1.ConcreteProduct
{
    public class SqlServerConnector : DbConnector
    {
        public SqlServerConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Sql Server...");
            var connecntion = new Connection(ConnectionString);
            connecntion.Open();

            return connecntion;
        }
    }
}
