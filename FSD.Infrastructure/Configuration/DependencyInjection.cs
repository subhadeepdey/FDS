using FSD.Infrastructure.Context;
using FSD.Infrastructure.Context.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FSD.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static void AddFSDIdentity(this IServiceCollection services, IConfiguration configuration)
        {
            // Server version is important
            services.AddDbContext<FSDIdentityDbContext>(options => options.UseMySql(configuration.GetConnectionString("mysqlConnection"), new MySqlServerVersion(new Version(8, 0, 29))));

            // For Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                        .AddEntityFrameworkStores<FSDIdentityDbContext>()
                        .AddDefaultTokenProviders();

            //services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
        }

        public static void AddFSDJwtBearer(this IServiceCollection services, IConfiguration configuration)
        {

            // Adding Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })


            // Adding Jwt Bearer
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]))
                };
            });
        }
    }
}

