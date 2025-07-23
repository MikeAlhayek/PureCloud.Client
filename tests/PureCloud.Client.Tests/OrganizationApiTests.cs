using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class OrganizationApiTests
{
    [Fact]
    public void OrganizationApi_CanBeCreated()
    {
        // This is a basic test to ensure the API can be instantiated
        // In a real scenario, we would need proper dependency injection setup
        
        // Just check that our interface is properly defined
        Assert.True(typeof(IOrganizationApi).IsInterface);
        Assert.True(typeof(OrganizationApi).IsSealed);
        
        // Check that OrganizationApi implements IOrganizationApi
        Assert.True(typeof(IOrganizationApi).IsAssignableFrom(typeof(OrganizationApi)));
    }
    
    [Fact]
    public void OrganizationApi_HasRequiredMethods()
    {
        var apiType = typeof(IOrganizationApi);
        
        // Check that all expected methods exist
        Assert.NotNull(apiType.GetMethod("GetOrganizationAsync"));
        Assert.NotNull(apiType.GetMethod("GetOrganizationAuthenticationSettingsAsync"));
        Assert.NotNull(apiType.GetMethod("UpdateOrganizationAuthenticationSettingsAsync"));
        Assert.NotNull(apiType.GetMethod("UpdateOrganizationAsync"));
        Assert.NotNull(apiType.GetMethod("GetOrganizationLimitsChangeRequestAsync"));
        Assert.NotNull(apiType.GetMethod("GetOrganizationLimitsChangeRequestsAsync"));
    }
}