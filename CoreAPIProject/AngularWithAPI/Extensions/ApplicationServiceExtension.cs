using AngularWithAPI.Interfaces;
using AngularWithAPI.Models;
using AngularWithAPI.Services;
using AutoMapper;
using Data;
using Helpers;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWithAPI.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<MyDBContext>(
                x =>
                {
                    x.UseSqlServer("Server=DESKTOP-QP39QM0;Initial Catalog=MyDB;Integrated Security=True");
                });
            return services;
        }

    }
}
