using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Contracts;
using PureCloud.Client.Extensions;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class LanguageUnderstandingApiTests
{
    private readonly IServiceProvider _serviceProvider;

    public LanguageUnderstandingApiTests()
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
    public void LanguageUnderstandingApi_ServiceRegistration_ShouldResolveInterface()
    {
        // Act
        var languageUnderstandingApi = _serviceProvider.GetService<ILanguageUnderstandingApi>();

        // Assert
        Assert.NotNull(languageUnderstandingApi);
        Assert.IsAssignableFrom<ILanguageUnderstandingApi>(languageUnderstandingApi);
    }

    [Fact]
    public void LanguageUnderstandingApi_ServiceRegistration_ShouldResolveCorrectImplementation()
    {
        // Act
        var languageUnderstandingApi = _serviceProvider.GetService<ILanguageUnderstandingApi>();

        // Assert
        Assert.NotNull(languageUnderstandingApi);
        Assert.Equal("LanguageUnderstandingApi", languageUnderstandingApi.GetType().Name);
    }

    [Fact] 
    public void LanguageUnderstandingApi_ServiceRegistration_ShouldBeScopedService()
    {
        // Arrange
        using var scope1 = _serviceProvider.CreateScope();
        using var scope2 = _serviceProvider.CreateScope();

        // Act
        var instance1a = scope1.ServiceProvider.GetService<ILanguageUnderstandingApi>();
        var instance1b = scope1.ServiceProvider.GetService<ILanguageUnderstandingApi>();
        var instance2 = scope2.ServiceProvider.GetService<ILanguageUnderstandingApi>();

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