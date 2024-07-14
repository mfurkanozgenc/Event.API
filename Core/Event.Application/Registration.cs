using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Event.Application
{
    public static class Registration
    {
        public static void AddAplication(this IServiceCollection services)
        {
            var assembely = Assembly.GetExecutingAssembly();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembely));
        }
    }
}
