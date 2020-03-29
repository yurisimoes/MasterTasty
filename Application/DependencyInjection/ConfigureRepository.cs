using Application.Interfaces;
using Application.Repository;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection{
    public class ConfigureRepository{
        public static void ConfigureDepenciesRepository(IServiceCollection serviceCollection){
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql("Server=localhost;Port=3306;Database=MasterTasty;Uid=root;Pwd=123456")
            );
        }
    }
}