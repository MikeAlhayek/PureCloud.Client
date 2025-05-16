using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Extensions;

namespace PureCloud.Client.Tests;

public sealed class NotificationHandlerTests
{
    // private readonly IServiceProvider _serviceProvider;

    public NotificationHandlerTests()
    {
        var services = new ServiceCollection();

        services
            .AddSingleton<IConfiguration>(o =>
            {
                return new ConfigurationBuilder()
                    .AddUserSecrets(GetType().Assembly)
                    .Build();
            });

        services
            .AddPureCloudCore()
            .AddPureCloudApis();

        //  _serviceProvider = services.BuildServiceProvider();
    }

    //[Fact]
    //public async Task StartAsync_WhenCalled_IsAbleToCommunicate()
    //{
    //    var userRepository = _serviceProvider.GetRequiredService<IUserRepository>();

    //    var user = await userRepository.GetMeAsync(null, null, TestContext.Current.CancellationToken);

    //    var handler = _serviceProvider.GetRequiredService<INotificationHandler>();

    //    var cts = new CancellationTokenSource(TimeSpan.FromSeconds(60));

    //    await handler.AddSubscriptionsAsync(new Dictionary<string, Type>()
    //    {
    //        { $"v2.analytics.conversation.{user.Id}.metrics", typeof(ConversationMetricsTopicConversationMetricRecord) },
    //    });

    //    await handler.StartAsync(null, cts.Token);
    //}
}
