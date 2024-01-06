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
            string dbNameBookContext = "Books" + Guid.NewGuid();
            services.AddDbContext<BooksContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameBookContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped

            );

            string dbNameUserContext = "Users" + Guid.NewGuid();
            services.AddDbContext<UsersContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameUserContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped

            );

            string dbNameKiadoContext = "Kiadok" + Guid.NewGuid();
            services.AddDbContext<KiadokContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameKiadoContext),
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

            string dbNameUserInMemoryContext = "Users" + Guid.NewGuid();
            services.AddDbContext<UsersInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameUserInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );

            string dbNameKiadoInMemoryContext = "Kiadok" + Guid.NewGuid();
            services.AddDbContext<KiadoInMemoryContext>
            (
                 options => options.UseInMemoryDatabase(databaseName: dbNameKiadoInMemoryContext),
                 ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );

        }

        public static void ConfigureRepos(this IServiceCollection services) 
        { 
            services.AddScoped<IBookRepo, BookRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IKiadoRepo, KiadoRepo>();
        }
    }
}
