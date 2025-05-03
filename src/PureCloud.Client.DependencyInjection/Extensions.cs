using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PureCloud.Client.Apis;
using PureCloud.Client.Http;
using PureCloud.Client.Services;

namespace PureCloud.Client.DependencyInjection;

public static class Extensions
{
    public static ServiceCollection AddPureCloud(this ServiceCollection services)
    {
        services
            .AddLogging();

        services
            .AddScoped<ITokenService, TokenService>()
            .AddScoped<ITokenStore, MemoryTokenStore>()
            .AddScoped<BearerTokenHandler>()
            .AddHttpClient("PureCloud", (sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<PureCloudOptions>>().Value;

                client.BaseAddress = new Uri(options.Region.GetDescription());
            }).AddHttpMessageHandler<BearerTokenHandler>();

        return services;
    }


}
