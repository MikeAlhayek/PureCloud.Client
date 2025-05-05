using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.AspNetCore.Http;

public static class Extensions
{
    public static IServiceCollection AddIdentityTokenStore<TUser>(this IServiceCollection services)
        where TUser : class
    {
        services.Replace(ServiceDescriptor.Scoped<ITokenStore, IdentityTokenStore<TUser>>());

        return services;
    }
}
