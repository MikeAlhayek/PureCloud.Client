using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.DependencyInjection;
using PureCloud.Client.Extensions.Notifications;
using PureCloud.Client.Models.Settings;
using PureCloud.Client.Models.Users;
using PureCloud.Client.Repositories;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class NotificationHandlerTests
{
    private readonly IServiceProvider _serviceProvider;

    public NotificationHandlerTests()
    {
        var services = new ServiceCollection();

        services
            .AddPureCloudCore()
            .AddPureCloudRepositories()
            .Configure<PureCloudOptions>(o =>
            {
                o.ClientId = "97167000-eec1-454a-9abb-2375ebf31099";
                o.ClientSecret = "44FP7uPEKCJ0b2HcqRGb2hSEMTKHBUbzMSSgVka4iVU";
                o.Region = PureCloudRegionHosts.us_west_2;
            });

        _serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task StartAsync_WhenCalled_IsAbleToCommunicate()
    {
        var handler = _serviceProvider.GetRequiredService<INotificationHandler>();

        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(60));

        await handler.AddSubscriptionsAsync();

        await handler.StartAsync(cts.Token);
    }
}

public sealed class UserRepositoryTests
{
    private readonly IServiceProvider _serviceProvider;

    public UserRepositoryTests()
    {
        var services = new ServiceCollection();

        services
            .AddPureCloudCore()
            .AddPureCloudRepositories()
            .Configure<PureCloudOptions>(o =>
            {
                o.ClientId = "97167000-eec1-454a-9abb-2375ebf31099";
                o.ClientSecret = "44FP7uPEKCJ0b2HcqRGb2hSEMTKHBUbzMSSgVka4iVU";
                o.Region = PureCloudRegionHosts.us_west_2;
            });

        _serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task CreateUser_WhenCalled_ReturnValidResponse()
    {
        var repository = _serviceProvider.GetRequiredService<IUserRepository>();

        var name = "John Doe";
        var email = "johndoe@crestapps.com";

        var result = await repository.SearchAsync(new UserSearchRequest()
        {
            Query = new List<SearchCriteria>
            {
                new SearchCriteria()
                {

                    Type = LookupType.Exact,
                    Fields = ["contactInfo.email_main"],
                    Value = email,
                }
            }
        }, TestContext.Current.CancellationToken);

        var existingUser = result.Records?.FirstOrDefault(x => x.Email == email);

        if (existingUser is not null)
        {
            await repository.DeleteAsync(existingUser.Id, TestContext.Current.CancellationToken);
        }

        var newUser = new CreateUser()
        {
            Name = name,
            Email = email,
            Password = Guid.NewGuid() + "!@#$1234asdfASDF"
        };

        var user = await repository.CreateAsync(newUser, TestContext.Current.CancellationToken);

        Assert.NotNull(user);
        Assert.NotEmpty(user.Id);
        Assert.Equal(newUser.Name, name);
        Assert.Equal(newUser.Email, email);
    }
}
