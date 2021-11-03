using FactoryMethod_1.ConcreteCreator;
using FactoryMethod_1.Enums;
using FactoryMethod_1.Product;

namespace FactoryMethod_1.Creator
{
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory GetDatabase(Database database)
        {
            return database switch
            {
                Database.SqlServer => new SqlServerFactory(),
                Database.Oracle => new OracleFactory(),
                _ => throw new ApplicationException("Banco de dados não reconhecido"),
            };
        }
    }
}
