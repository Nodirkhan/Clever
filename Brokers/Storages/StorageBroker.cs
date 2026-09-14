using System.Data;
using Microsoft.Data.SqlClient;

namespace Clever.Brokers.Storages;

public partial class StorageBroker : IStorageBroker
{
    private readonly IDbConnection context;
    const string CONNECTION_STRING = "Server=localhost;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;";

    public StorageBroker()
    {
        context = new SqlConnection(CONNECTION_STRING);
    }
}