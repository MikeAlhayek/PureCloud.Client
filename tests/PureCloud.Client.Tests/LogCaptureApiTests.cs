using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class LogCaptureApiTests
{
    [Fact]
    public void LogCaptureApi_CanBeCreated()
    {
        // This is a basic test to ensure the API can be instantiated
        // In a real scenario, we would need proper dependency injection setup
        
        // Just check that our interface is properly defined
        Assert.True(typeof(ILogCaptureApi).IsInterface);
        Assert.True(typeof(LogCaptureApi).IsSealed);
        
        // Check that LogCaptureApi implements ILogCaptureApi
        Assert.True(typeof(ILogCaptureApi).IsAssignableFrom(typeof(LogCaptureApi)));
    }
    
    [Fact]
    public void LogCaptureApi_HasRequiredMethods()
    {
        var apiType = typeof(ILogCaptureApi);
        
        // Check that all 7 expected methods exist
        Assert.NotNull(apiType.GetMethod("DeleteDiagnosticsLogcaptureBrowserUserAsync"));
        Assert.NotNull(apiType.GetMethod("GetDiagnosticsLogcaptureBrowserEntriesDownloadJobAsync"));
        Assert.NotNull(apiType.GetMethod("GetDiagnosticsLogcaptureBrowserUserAsync"));
        Assert.NotNull(apiType.GetMethod("GetDiagnosticsLogcaptureBrowserUsersAsync"));
        Assert.NotNull(apiType.GetMethod("CreateDiagnosticsLogcaptureBrowserEntriesDownloadJobsAsync"));
        Assert.NotNull(apiType.GetMethod("CreateDiagnosticsLogcaptureBrowserEntriesQueryAsync"));
        Assert.NotNull(apiType.GetMethod("CreateDiagnosticsLogcaptureBrowserUserAsync"));
        
        // Verify we have exactly 7 methods
        var methods = apiType.GetMethods().Where(m => m.Name.EndsWith("Async") && !m.IsSpecialName).ToArray();
        Assert.Equal(7, methods.Length);
    }
}