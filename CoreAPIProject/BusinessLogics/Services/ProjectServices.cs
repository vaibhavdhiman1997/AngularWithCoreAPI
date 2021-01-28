using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogics.Services
{
    public static class ProjectServices
    {
        public static IHostingEnvironment _env;
        public static void ProjectServiceProvider(this IServiceCollection services, IHostingEnvironment env)
        {
            _env = env;
        }
    }
}
