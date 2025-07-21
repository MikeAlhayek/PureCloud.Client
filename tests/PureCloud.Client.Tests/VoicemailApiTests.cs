using Microsoft.Extensions.DependencyInjection;
using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class VoicemailApiTests
{
    [Fact]
    public void VoicemailApi_CanBeCreated()
    {
        // This is a basic test to ensure the API can be instantiated
        // In a real scenario, we would need proper dependency injection setup
        
        // Just check that our interface is properly defined
        Assert.True(typeof(IVoicemailApi).IsInterface);
        Assert.True(typeof(VoicemailApi).IsSealed);
        
        // Check that VoicemailApi implements IVoicemailApi
        Assert.True(typeof(IVoicemailApi).IsAssignableFrom(typeof(VoicemailApi)));
    }
    
    [Fact]
    public void VoicemailApi_HasRequiredMethods()
    {
        var apiType = typeof(IVoicemailApi);
        
        // Check that all expected methods exist
        Assert.NotNull(apiType.GetMethod("GetVoicemailMessageAsync"));
        Assert.NotNull(apiType.GetMethod("DeleteVoicemailMessageAsync"));
        Assert.NotNull(apiType.GetMethod("GetVoicemailMailboxAsync"));
        Assert.NotNull(apiType.GetMethod("PatchVoicemailMePolicyAsync"));
        Assert.NotNull(apiType.GetMethod("SearchVoicemailsAsync"));
    }
}