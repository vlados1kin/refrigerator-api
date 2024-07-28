using Microsoft.EntityFrameworkCore;
using Refrigerator.Repository;

namespace Refrigerator.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositoryContext(this IServiceCollection services, IConfiguration configuration)
        => services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
}