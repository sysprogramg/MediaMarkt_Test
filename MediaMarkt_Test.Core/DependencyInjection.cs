using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Core
{
    public class DependencyInjection
    {
        /// <summary>
        /// Injecting services
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Interfaces.IProduct, Services.Product>();
        }
    }
}
