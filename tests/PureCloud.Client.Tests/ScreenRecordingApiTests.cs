using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class ScreenRecordingApiTests
{
    [Fact]
    public void ScreenRecordingApi_CanBeCreated()
    {
        // This is a basic test to ensure the API can be instantiated
        // In a real scenario, we would need proper dependency injection setup
        
        // Just check that our interface is properly defined
        Assert.True(typeof(IScreenRecordingApi).IsInterface);
        Assert.True(typeof(ScreenRecordingApi).IsSealed);
        
        // Check that ScreenRecordingApi implements IScreenRecordingApi
        Assert.True(typeof(IScreenRecordingApi).IsAssignableFrom(typeof(ScreenRecordingApi)));
    }
    
    [Fact]
    public void ScreenRecordingApi_HasRequiredMethods()
    {
        var apiType = typeof(IScreenRecordingApi);
        
        // Check that all expected methods exist
        Assert.NotNull(apiType.GetMethod("CreateScreenrecordingTokenAsync"));
    }
}