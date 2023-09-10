using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TransportathonApp.Persistence.Contexts;

namespace TransportathonApp.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TransportathonAppDbContext>
{
    public TransportathonAppDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<TransportathonAppDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
    }
}



//dotnet cli için yazılmış bir class