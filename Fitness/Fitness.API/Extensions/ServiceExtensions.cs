using Fitness.BLL.Implementation;
using Fitness.BLL.Interface;
using Fitness.DAL.DBContext;
using Fitness.DAL.Entities;
using LoggerServices;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Fitness.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {

            });

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<FitnessDbContext>()
                .AddDefaultTokenProviders();
        }
        public static void AddDBConnection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FitnessDbContext>(opts => opts.UseSqlServer(configuration.GetConnectionString("DefaultConn")
         ));
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IServiceFactory, ServiceFactory>();
            services.AddTransient<DbContext, FitnessDbContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork<FitnessDbContext>>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IFoodStuffService, FoodStuffService>();
            services.AddTransient<IMealLogService, MealLogService>();
        }
    }
}
