using FactoryMethod_1.Creator;
using FactoryMethod_1.Enums;

Console.WriteLine("*** Factory Method 1 ***");
Console.WriteLine();

var sqlConnection = DbFactory
    .GetDatabase(Database.SqlServer)
    .CreateConnector("SqlServer_ConnectionString")
    .Connect();

sqlConnection.ExecuteCommand("select * from tabelaSql");
sqlConnection.Close();

Console.WriteLine();
Console.WriteLine("--------------------------------");
Console.WriteLine();

var oracleConnection = DbFactory
    .GetDatabase(Database.Oracle)
    .CreateConnector("Oracle_ConnectionString")
    .Connect();

oracleConnection.ExecuteCommand("select * from tabelaOracle");
oracleConnection.Close();