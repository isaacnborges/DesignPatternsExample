namespace FactoryMethod_1.Product
{
    public abstract class DbConnector
    {
        public string ConnectionString { get; set; }

        public abstract Connection Connect();

        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
