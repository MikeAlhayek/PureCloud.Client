using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Contracts;
using PureCloud.Client.Extensions;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class KnowledgeApiTests
{
    private readonly IServiceProvider _serviceProvider;

    public KnowledgeApiTests()
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
    public void KnowledgeApi_ServiceRegistration_ShouldRegisterInterface()
    {
        // Act
        var knowledgeApi = _serviceProvider.GetService<IKnowledgeApi>();

        // Assert
        Assert.NotNull(knowledgeApi);
        Assert.IsAssignableFrom<IKnowledgeApi>(knowledgeApi);
    }

    [Fact]
    public void KnowledgeApi_ServiceRegistration_ShouldResolveCorrectImplementation()
    {
        // Act
        var knowledgeApi = _serviceProvider.GetService<IKnowledgeApi>();

        // Assert
        Assert.NotNull(knowledgeApi);
        Assert.Equal("KnowledgeApi", knowledgeApi.GetType().Name);
    }

    [Fact] 
    public void KnowledgeApi_ServiceRegistration_ShouldBeScopedService()
    {
        // Arrange
        using var scope1 = _serviceProvider.CreateScope();
        using var scope2 = _serviceProvider.CreateScope();

        // Act
        var instance1 = scope1.ServiceProvider.GetService<IKnowledgeApi>();
        var instance2 = scope1.ServiceProvider.GetService<IKnowledgeApi>();
        var instance3 = scope2.ServiceProvider.GetService<IKnowledgeApi>();

        // Assert
        Assert.NotNull(instance1);
        Assert.NotNull(instance2);
        Assert.NotNull(instance3);
        Assert.Same(instance1, instance2); // Same scope should return same instance
        Assert.NotSame(instance1, instance3); // Different scope should return different instance
    }

    [Fact]
    public async Task KnowledgeApi_ArgumentValidation_GetKnowledgeKnowledgebaseAsync_ShouldThrowOnNullId()
    {
        // Arrange
        var knowledgeApi = _serviceProvider.GetService<IKnowledgeApi>();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(async () => 
            await knowledgeApi.GetKnowledgeKnowledgebaseAsync(null));
    }

    [Fact]
    public async Task KnowledgeApi_ArgumentValidation_PostKnowledgeKnowledgebasesAsync_ShouldThrowOnNullBody()
    {
        // Arrange
        var knowledgeApi = _serviceProvider.GetService<IKnowledgeApi>();

        // Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(async () => 
            await knowledgeApi.PostKnowledgeKnowledgebasesAsync(null));
    }
}