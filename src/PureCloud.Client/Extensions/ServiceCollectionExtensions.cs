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

        services.TryAddScoped<IKnowledgeApi, KnowledgeApi>();

        services.TryAddScoped<IIntegrationsApi, IntegrationsApi>();

        services.TryAddScoped<IJourneyApi, JourneyApi>();

        services.TryAddScoped<ILanguagesApi, LanguagesApi>();

        services.TryAddScoped<ILearningApi, LearningApi>();

        services.TryAddScoped<ILicenseApi, LicenseApi>();

        services.TryAddScoped<ILocationsApi, LocationsApi>();

        services.TryAddScoped<ILogCaptureApi, LogCaptureApi>();

        services.TryAddScoped<IMobileDevicesApi, MobileDevicesApi>();

        services.TryAddScoped<IMessagingApi, MessagingApi>();

        services.TryAddScoped<INotificationsApi, NotificationsApi>();

        services.TryAddScoped<INotificationClientFactory, NotificationClientFactory>();

        services.TryAddTransient<NotificationClient>();

        services.TryAddScoped<INotificationClientFactory, NotificationClientFactory>();

        services.TryAddTransient<NotificationClient>();

        services.TryAddScoped<IOAuthApi, OAuthApi>();

        services.TryAddScoped<IOrganizationApi, OrganizationApi>();

        services.TryAddScoped<IOrganizationAuthorizationApi, OrganizationAuthorizationApi>();

        services.TryAddScoped<IObjectsApi, ObjectsApi>();

        services.TryAddScoped<IOperationalEventsApi, OperationalEventsApi>();

        services.TryAddScoped<IQualityApi, QualityApi>();

        services.TryAddScoped<IOutboundApi, OutboundApi>();

        services.TryAddScoped<IPresenceApi, PresenceApi>();

        services.TryAddScoped<IProcessAutomationApi, ProcessAutomationApi>();

        services.TryAddScoped<IRoutingApi, RoutingApi>();

        services.TryAddScoped<IPresenceApi, PresenceApi>();

        services.TryAddScoped<IRecordingApi, RecordingApi>();

        services.TryAddScoped<IResponseManagementApiV2, ResponseManagementApi>();

        services.TryAddScoped<IScriptsApi, ScriptsApi>();

        services.TryAddScoped<ISearchApi, SearchApi>();

        services.TryAddScoped<IScreenRecordingApi, ScreenRecordingApi>();

        services.TryAddScoped<IScriptsApi, ScriptsApi>();

        services.TryAddScoped<ISettingsApi, SettingsApi>();

        services.TryAddScoped<IStationsApi, StationsApi>();

        services.TryAddScoped<ISocialMediaApi, SocialMediaApi>();

        services.TryAddScoped<ISpeechTextAnalyticsApi, SpeechTextAnalyticsApi>();

        services.TryAddScoped<ITextbotsApi, TextbotsApi>();

        services.TryAddScoped<IUserRecordingsApi, UserRecordingsApi>();

        services.TryAddScoped<IUtilitiesApi, UtilitiesApi>();

        services.TryAddScoped<ITokensApi, TokensApi>();

        services.TryAddScoped<ITelephonyApi, TelephonyApi>();

        services.TryAddScoped<ITelephonyProvidersEdgeApi, TelephonyProvidersEdgeApi>();

        services.TryAddScoped<ITeamsApi, TeamsApi>();

        services.TryAddScoped<ITaskManagementApi, TaskManagementApi>();

        services.TryAddScoped<ITokensApi, TokensApi>();

        services.TryAddScoped<IUserApi, UserApi>();

        services.TryAddScoped<IVoicemailApi, VoicemailApi>();

        services.TryAddScoped<IWebChatApi, WebChatApi>();

        services.TryAddScoped<IWebMessagingApi, WebMessagingApi>();

        services.TryAddScoped<IWidgetsApi, WidgetsApi>();

        return services;
    }

}
