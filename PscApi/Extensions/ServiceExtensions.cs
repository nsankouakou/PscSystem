using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Entities.Models;
using Swashbuckle.AspNetCore.Swagger;
using Contracts;
using Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
//using Entities.MikidiaModels;
//using PscApi.IServices;
//using PscApi.Extensions;
//using PscApi.Services;
using LoggerService;

namespace PscApi
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration Configuration)
        {
            var connection = Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            services.AddDbContext<pscContext>(options => options.UseMySQL(connection)/*, ServiceLifetime.Singleton*/);
        }
        

        public static void SwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "PSC API", Version = "v1" });
            });
        }

        public static void JwtBearerDefault(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = "http://localhost:5000",
            ValidAudience = "http://localhost:5000",
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("Security").GetSection("secretKey").Value))
        };
    });
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            
        }

        public static void ConfigureClientService(this IServiceCollection services)
        {            
            //services.AddTransient<IParametreConfigService, ParametreConfigService>();
            //services.AddSingleton<IDemandeService, DemandeService>();
            //services.AddTransient<ILoginService, LoginService>();
            //services.AddTransient<IParametreConfigMobilService, ParametreConfigMobilService>();            
            //services.AddTransient<IServiceCommun, ServiceCommun>();
        }




    }
}
