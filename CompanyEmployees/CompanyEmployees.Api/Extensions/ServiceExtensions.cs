using CompanyEmployees.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Api.Extensions;

public static class ServiceExtensions
{
    public static void AddCustomDbContext(this IServiceCollection services,
        string connectionString) =>
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));
}
