using konyvtarMVVM.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Extensions
{
    public static class ApiServiceExtensions
    {
        public static void ConfigureApiServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBookService, BookService>();
        }
    }
}
