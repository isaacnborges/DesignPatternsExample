using FactoryMethod_1.ConcreteProduct;
using FactoryMethod_1.Creator;
using FactoryMethod_1.Product;

namespace FactoryMethod_1.ConcreteCreator
{
    public class SqlServerFactory : DbFactory
    {
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlServerConnector(connectionString);
        }
    }
}
