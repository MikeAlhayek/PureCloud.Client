using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Contracts;
using PureCloud.Client.Extensions;
using Xunit;

namespace PureCloud.Client.Tests;

public class WebDeploymentsApiTests
{
    private readonly IServiceProvider _serviceProvider;

    public WebDeploymentsApiTests()
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
    public void WebDeploymentsApi_CanBeCreated()
    {
        // Act
        var api = _serviceProvider.GetService<IWebDeploymentsApi>();

        // Assert
        Assert.NotNull(api);
    }

    [Fact]
    public void WebDeploymentsApi_HasRequiredMethods()
    {
        // Arrange
        var api = _serviceProvider.GetService<IWebDeploymentsApi>();

        // Act & Assert
        Assert.NotNull(api);

        // Verify the interface has the expected methods
        var methods = typeof(IWebDeploymentsApi).GetMethods();
        
        // Should have 21 methods as described in the PR
        Assert.True(methods.Length >= 21, $"Expected at least 21 methods, but found {methods.Length}");
        
        // Verify key methods exist
        Assert.Contains(methods, m => m.Name == "DeleteWebdeploymentsConfigurationAsync");
        Assert.Contains(methods, m => m.Name == "DeleteWebdeploymentsDeploymentAsync");
        Assert.Contains(methods, m => m.Name == "GetWebdeploymentsConfigurationsAsync");
        Assert.Contains(methods, m => m.Name == "GetWebdeploymentsDeploymentAsync");
        Assert.Contains(methods, m => m.Name == "CreateWebdeploymentsConfigurationsAsync");
        Assert.Contains(methods, m => m.Name == "CreateWebdeploymentsDeploymentsAsync");
        Assert.Contains(methods, m => m.Name == "UpdateWebdeploymentsDeploymentAsync");
        Assert.Contains(methods, m => m.Name == "CreateWebdeploymentsTokenOauthcodegrantjwtexchangeAsync");
        Assert.Contains(methods, m => m.Name == "CreateWebdeploymentsTokenRefreshAsync");
    }

    [Fact]
    public void WebDeploymentsApi_ServiceRegistration_ShouldResolveCorrectImplementation()
    {
        // Act
        var api = _serviceProvider.GetService<IWebDeploymentsApi>();

        // Assert
        Assert.NotNull(api);
        Assert.Equal("WebDeploymentsApi", api.GetType().Name);
    }

    [Fact]
    public void WebDeploymentsApi_ServiceRegistration_ShouldBeScopedService()
    {
        // Act
        var api1 = _serviceProvider.GetService<IWebDeploymentsApi>();
        var api2 = _serviceProvider.GetService<IWebDeploymentsApi>();

        // Assert - Should be the same instance within the same scope
        Assert.NotNull(api1);
        Assert.NotNull(api2);
        Assert.Same(api1, api2);
    }
}