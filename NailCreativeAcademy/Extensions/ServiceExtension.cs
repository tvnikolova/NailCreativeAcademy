namespace Microsoft.Extensions.DependencyInjection
{
    using AspNetCore.Identity;
    using EntityFrameworkCore;
    using NailCreativeAcademy.Data;

    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
