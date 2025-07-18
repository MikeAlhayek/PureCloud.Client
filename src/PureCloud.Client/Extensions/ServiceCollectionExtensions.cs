using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models.Settings;
using PureCloud.Client.Notifications;
using PureCloud.Client.Services;
using PureCloud.Client.Tokens;

namespace PureCloud.Client.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPureCloudCore(this IServiceCollection services)
    {
        services
            .AddLogging()
            .AddOptions<PureCloudJsonSerializerOptions>();

        services.AddOptions<NotificationClientResilienceOptions>();

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

    public static IServiceCollection AddPureCloudApis(this IServiceCollection services)
    {
        services.TryAddScoped<INotificationClientFactory, NotificationClientFactory>();

        services.TryAddTransient<NotificationClient>();

        services.TryAddScoped<IUserApi, UserApi>();

        services.TryAddScoped<IChannelsApi, ChannelsApi>();

        services.TryAddScoped<IAgentAssistantsApi, AgentAssistantsApi>();

        services.TryAddScoped<IAgentCopilotApi, AgentCopilotApi>();

        services.TryAddScoped<IAgentUIApi, AgentUIApi>();

        services.TryAddScoped<IAlertingApi, AlertingApi>();

        services.TryAddScoped<IAnalyticsApi, AnalyticsApi>();

        services.TryAddScoped<IArchitectApi, ArchitectApi>();

        services.TryAddScoped<IAuditApi, AuditApi>();

        services.TryAddScoped<IAuthorizationApi, AuthorizationApi>();

        services.TryAddScoped<IBillingApi, BillingApi>();

        services.TryAddScoped<ICarrierServicesApi, CarrierServicesApi>();

        services.TryAddScoped<IChatApi, ChatApi>();

        services.TryAddScoped<ICoachingApi, CoachingApi>();

        services.TryAddScoped<IContentManagementApi, ContentManagementApi>();

        services.TryAddScoped<IConversationsApi, ConversationsApi>();

        services.TryAddScoped<IDataExtensionsApi, DataExtensionsApi>();

        services.TryAddScoped<IDataPrivacyApi, DataPrivacyApi>();

        services.TryAddScoped<IDownloadsApi, DownloadsApi>();

        services.TryAddScoped<IEmailsApi, EmailsApi>();

        services.TryAddScoped<IEmployeeEngagementApi, EmployeeEngagementApi>();

        services.TryAddScoped<IEventsApi, EventsApi>();

        services.TryAddScoped<IExternalContactsApi, ExternalContactsApi>();

        services.TryAddScoped<IFaxApi, FaxApi>();

        services.TryAddScoped<IFlowsApi, FlowsApi>();

        services.TryAddScoped<IGamificationApi, GamificationApi>();

        services.TryAddScoped<IGeneralDataProtectionRegulationApi, GeneralDataProtectionRegulationApi>();

        services.TryAddScoped<IGeolocationApi, GeolocationApi>();

        services.TryAddScoped<IGreetingsApi, GreetingsApi>();

        services.TryAddScoped<IGroupsApi, GroupsApi>();

        services.TryAddScoped<IIdentityProviderApi, IdentityProviderApi>();

        services.TryAddScoped<IInfrastructureAsCodeApi, InfrastructureAsCodeApi>();

        return services;
    }

}
