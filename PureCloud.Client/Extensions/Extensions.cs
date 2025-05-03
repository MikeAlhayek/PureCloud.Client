using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using PureCloud.Client.Extensions.Notifications;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Settings;
using PureCloud.Client.Repositories;
using PureCloud.Client.Services;

namespace PureCloud.Client.DependencyInjection;

public static class Extensions
{
    public static ServiceCollection AddPureCloudCore(this ServiceCollection services)
    {
        services
            .AddLogging()
            .AddOptions<PureCloudJsonSerializerOptions>();

        services
            .AddScoped<ITokenService, TokenService>()
            .AddScoped<ITokenStore, MemoryTokenStore>();

        // Add PureCloudAuth client;
        services
            .AddScoped<BearerTokenHandler>()
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

    public static ServiceCollection AddPureCloudRepositories(this ServiceCollection services)
    {
        services.AddTransient<INotificationHandler, NotificationHandler>();

        services
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IChannelRepository, ChannelRepository>();

        return services;
    }


}
