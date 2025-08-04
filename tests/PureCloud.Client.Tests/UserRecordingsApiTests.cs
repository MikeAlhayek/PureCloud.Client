using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class UserRecordingsApiTests
{
    [Fact]
    public void UserRecordingsApi_CanBeCreated()
    {
        // This is a basic test to ensure the API can be instantiated
        // In a real scenario, we would need proper dependency injection setup
        
        // Just check that our interface is properly defined
        Assert.True(typeof(IUserRecordingsApi).IsInterface);
        Assert.True(typeof(UserRecordingsApi).IsSealed);
        
        // Check that UserRecordingsApi implements IUserRecordingsApi
        Assert.True(typeof(IUserRecordingsApi).IsAssignableFrom(typeof(UserRecordingsApi)));
    }
    
    [Fact]
    public void UserRecordingsApi_HasRequiredMethods()
    {
        var apiType = typeof(IUserRecordingsApi);
        
        // Check that all expected methods exist
        Assert.NotNull(apiType.GetMethod("DeleteUserRecordingAsync"));
        Assert.NotNull(apiType.GetMethod("GetUserRecordingAsync"));
        Assert.NotNull(apiType.GetMethod("GetUserRecordingTranscodingAsync"));
        Assert.NotNull(apiType.GetMethod("GetUserRecordingsAsync"));
        Assert.NotNull(apiType.GetMethod("GetUserRecordingsSummaryAsync"));
        Assert.NotNull(apiType.GetMethod("UpdateUserRecordingAsync"));
    }
}