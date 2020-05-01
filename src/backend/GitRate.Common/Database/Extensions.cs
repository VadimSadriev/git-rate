﻿using System;
using GitRate.Common.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GitRate.Common.Database
{
    public static class Extensions
    {
        public static IServiceCollection AddDataContext<TContext>(this IServiceCollection services, IConfiguration configuration)
            where TContext : DbContext
        {
           var dbSection = configuration.GetSection("Database").CheckExistence();

            return services.AddDbContext<TContext>(x => { x.UseNpgsql(dbSection["ConnectionString"]); });
        }
    }
}