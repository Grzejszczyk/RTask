using RTask.Domain.Interfaces;
using RTask.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RTask.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<Context>(options =>
            options.UseSqlite("Data Source=exercises.db"));

            services.AddTransient<IExerciseRepository, ExerciseRepository>();

            return services;
        }
    }
}
