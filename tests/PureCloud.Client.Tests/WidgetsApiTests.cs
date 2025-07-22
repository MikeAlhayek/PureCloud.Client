using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Contracts;
using PureCloud.Client.Extensions;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class WidgetsApiTests
{
    private readonly IServiceProvider _serviceProvider;

    public WidgetsApiTests()
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
    public void WidgetsApi_ServiceRegistration_ShouldResolveInterface()
    {
        // Act
        var widgetsApi = _serviceProvider.GetService<IWidgetsApi>();

        // Assert
        Assert.NotNull(widgetsApi);
        Assert.IsAssignableFrom<IWidgetsApi>(widgetsApi);
    }

    [Fact]
    public void WidgetsApi_ServiceRegistration_ShouldResolveCorrectImplementation()
    {
        // Act
        var widgetsApi = _serviceProvider.GetService<IWidgetsApi>();

        // Assert
        Assert.NotNull(widgetsApi);
        Assert.Equal("WidgetsApi", widgetsApi.GetType().Name);
    }

    [Fact] 
    public void WidgetsApi_ServiceRegistration_ShouldBeScopedService()
    {
        // Arrange
        using var scope1 = _serviceProvider.CreateScope();
        using var scope2 = _serviceProvider.CreateScope();

        // Act
        var instance1a = scope1.ServiceProvider.GetService<IWidgetsApi>();
        var instance1b = scope1.ServiceProvider.GetService<IWidgetsApi>();
        var instance2 = scope2.ServiceProvider.GetService<IWidgetsApi>();

        // Assert
        Assert.NotNull(instance1a);
        Assert.NotNull(instance1b);
        Assert.NotNull(instance2);
        
        // Same instance within scope
        Assert.Same(instance1a, instance1b);
        
        // Different instances across scopes
        Assert.NotSame(instance1a, instance2);
    }
}