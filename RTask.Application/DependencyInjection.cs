using Microsoft.Extensions.DependencyInjection;
using RTask.Application.Interfaces;
using RTask.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RTask.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IExerciseService, ExerciseService>();

            return services;
        }
    }
}
