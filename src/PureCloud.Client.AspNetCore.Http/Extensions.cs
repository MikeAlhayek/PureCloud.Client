using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.AspNetCore.Http;

public static class Extensions
{
    public static IServiceCollection AddInMemoryTokenStore(this IServiceCollection services)
    {
        services.RemoveAll<ITokenStore>();
        services.AddSingleton<ITokenStore, InMemoryTokenStore>();

        return services;
    }

    public static IServiceCollection AddIdentityTokenStore<TUser>(this IServiceCollection services)
        where TUser : class
    {
        services.RemoveAll<ITokenStore>();
        services.AddScoped<ITokenStore, IdentityTokenStore<TUser>>();

        return services;
    }
}
