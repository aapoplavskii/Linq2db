using LinqToDB.Data;

namespace Linq2DB
{
    public static class Config
    {
        public static string SqlConnectionString = "User ID=postgres; Password = 'Kontroller-1394';Host=localhost;Port=5432;Database='DZ_LINQ2DB'";

        public static DataConnection db = new DataConnection(LinqToDB.ProviderName.PostgreSQL, SqlConnectionString);

    }
}
