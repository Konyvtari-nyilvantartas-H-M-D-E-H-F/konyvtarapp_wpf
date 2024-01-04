using Books.Backend.Context;
using Books.Backend.Repos;
using Microsoft.EntityFrameworkCore;

namespace Books.Backend.Extensions
{
    public static class BooksBackendExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {

            services.AddCors(option =>
                 option.AddPolicy(name: "BooksCors",
                     policy =>
                     {
                         policy.WithOrigins("https://localhost:7090/")
                         .AllowAnyHeader()
                         .AllowAnyMethod();
                     }
                 )
            );
        }

        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameKretaContext = "Books" + Guid.NewGuid();
            services.AddDbContext<BooksContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameKretaContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );


            string dbNameInMemoryContext = "Books" + Guid.NewGuid();
            services.AddDbContext<BooksInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

        public static void ConfigureRepos(this IServiceCollection services) 
        { 
            services.AddScoped<IBookRepo, BookRepo>();
        }
    }
}
