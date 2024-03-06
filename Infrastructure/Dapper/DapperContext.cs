namespace Infrastructure.Dapper;
using Npgsql;
public class DapperContext
{
    private readonly string _connectionString =
        "Host=localhost;Port=5432;Database=.NetHw1;User Id=postgres;Password=20080820;";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    }
}
