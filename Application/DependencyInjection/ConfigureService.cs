using Application.Interfaces.Food;
using Application.Interfaces.Tip;
using Application.Interfaces.User;
using Application.Services.Food;
using Application.Services.Tip;
using Application.Services.User;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyInjection{
    public class ConfigureService{
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection){
            serviceCollection.AddTransient<IUser, UserService>();
            serviceCollection.AddTransient<ITips, TipService>();
            serviceCollection.AddTransient<IFood, FoodService>();
        }
    }
}