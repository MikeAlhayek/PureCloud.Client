using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Contracts;
using PureCloud.Client.Extensions;
using PureCloud.Client.Models.Users;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class UserRepositoryTests
{
    private readonly IServiceProvider _serviceProvider;

    public UserRepositoryTests()
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

        _serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task CreateUser_WhenCalled_ReturnValidResponse()
    {
        var repository = _serviceProvider.GetRequiredService<IUserApi>();

        var name = "John Doe";
        var email = "johndoe@crestapps.com";

        var result = await repository.SearchUsersAsync(new UserSearchRequest()
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
            await repository.DeleteUserAsync(existingUser.Id, TestContext.Current.CancellationToken);
        }

        var newUser = new CreateUser()
        {
            Name = name,
            Email = email,
            Password = Guid.NewGuid() + "!@#$1234asdfASDF"
        };

        var user = await repository.CreateUserAsync(newUser, TestContext.Current.CancellationToken);

        Assert.NotNull(user);
        Assert.NotEmpty(user.Id);
        Assert.Equal(newUser.Name, name);
        Assert.Equal(newUser.Email, email);
    }
}
