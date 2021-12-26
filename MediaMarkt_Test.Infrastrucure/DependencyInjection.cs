using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaMarkt_Test.Infrastrucure
{
    public class DependencyInjection
    {
        /// <summary>
        /// Injecting repositories
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Core.Interfaces.IProductRepository, Repositories.ProductRepository>();
        }
    }
}
