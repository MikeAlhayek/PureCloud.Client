using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Settings;
using PureCloud.Client.Notifications;
using PureCloud.Client.Repositories;
using PureCloud.Client.Services;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddPureCloudCore(this IServiceCollection services)
    {
        services
            .AddLogging()
            .AddOptions<PureCloudJsonSerializerOptions>();

        services.AddTransient<IConfigureOptions<PureCloudOptions>, PureCloudOptionsConfigurations>();

        services.TryAddScoped<ITokenService, TokenService>();

        services.TryAddScoped<ITokenStore, MemoryTokenStore>();

        // Add PureCloudAuth client;
        services
            .AddHttpClient(PureCloudConstants.PureCloudAuthClientName, (sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<PureCloudOptions>>().Value;

                var host = options.Region.GetDescription();
                if (!string.IsNullOrEmpty(host))
                {
                    var regex = new Regex(@"://(api)\.");
                    var authUrl = regex.Replace(host, "://login.");
                    client.BaseAddress = new Uri(authUrl);
                }
            });

        // Add PureCloud client;
        services
            .AddScoped<BearerTokenHandler>()
            .AddHttpClient(PureCloudConstants.PureCloudClientName, (sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<PureCloudOptions>>().Value;

                client.BaseAddress = new Uri(options.Region.GetDescription());
            }).AddHttpMessageHandler<BearerTokenHandler>();

        return services;
    }

    public static IServiceCollection AddPureCloudRepositories(this IServiceCollection services)
    {
        services.TryAddScoped<INotificationClientFactory, NotificationClientFactory>();

        services.AddTransient<NotificationClient>();

        services
            .AddScoped<IUserRepository, UserRepository>()
            .TryAddScoped<IChannelRepository, ChannelRepository>();

        return services;
    }
}
