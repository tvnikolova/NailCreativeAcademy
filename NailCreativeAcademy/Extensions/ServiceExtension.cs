namespace Microsoft.Extensions.DependencyInjection
{
    using EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;
    using NailCreativeAcademy.Core.Contracts;
    using NailCreativeAcademy.Core.Services;
    using NailCreativeAcademy.Infrastructure.Data;
    using NailCreativeAcademy.Infrastructure.Data.Common;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public static class ServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ITrainerService, TrainerService>();
            services.AddScoped<ISaloonService, SaloonService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<IGalleryService, GalleryService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<NailCreativeDbContext>(options =>
                 options.UseSqlServer(connectionString));

            services.AddScoped<IRepository, Repository>();


            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<NailCreativeDbContext>();

            return services;
        }
    }
}
