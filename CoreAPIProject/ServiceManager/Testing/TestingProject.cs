using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceManager.Testing
{
    public static class TestingProject
    {
        public static IHostingEnvironment _env;

        public static void AppServiceProvider(this IServiceCollection services, IHostingEnvironment env)
        {
            _env = env;
            //return services;
        }
    }
}
