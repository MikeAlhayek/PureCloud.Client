using System.Net.Http;
using Microsoft.Extensions.Options;
using PureCloud.Client.Apis;
using PureCloud.Client.Json;
using Xunit;

namespace PureCloud.Client.Tests;

public sealed class LanguageUnderstandingApiIntegrationTests
{
    [Fact]
    public void LanguageUnderstandingApi_Constructor_ShouldCreateInstanceWithValidParameters()
    {
        // Arrange
        var httpClientFactory = new TestHttpClientFactory();
        var options = Options.Create(new PureCloudJsonSerializerOptions());

        // Act
        var api = new LanguageUnderstandingApi(httpClientFactory, options);

        // Assert
        Assert.NotNull(api);
    }

    [Fact]
    public void LanguageUnderstandingApi_Methods_ShouldHaveCorrectSignatures()
    {
        // Arrange
        var httpClientFactory = new TestHttpClientFactory();
        var options = Options.Create(new PureCloudJsonSerializerOptions());
        var api = new LanguageUnderstandingApi(httpClientFactory, options);

        // Act & Assert - Check that methods exist and return Tasks
        var getDomainMethod = api.GetType().GetMethod("GetLanguageUnderstandingDomainAsync");
        var getDomainsMethod = api.GetType().GetMethod("GetLanguageUnderstandingDomainsAsync");
        var createDomainMethod = api.GetType().GetMethod("CreateLanguageUnderstandingDomainAsync");
        var updateDomainMethod = api.GetType().GetMethod("UpdateLanguageUnderstandingDomainAsync");
        var deleteDomainMethod = api.GetType().GetMethod("DeleteLanguageUnderstandingDomainAsync");

        Assert.NotNull(getDomainMethod);
        Assert.NotNull(getDomainsMethod);
        Assert.NotNull(createDomainMethod);
        Assert.NotNull(updateDomainMethod);
        Assert.NotNull(deleteDomainMethod);
        
        // All methods should return Task or Task<T>
        Assert.True(getDomainMethod.ReturnType.BaseType == typeof(System.Threading.Tasks.Task));
        Assert.True(getDomainsMethod.ReturnType.BaseType == typeof(System.Threading.Tasks.Task));
        Assert.True(createDomainMethod.ReturnType.BaseType == typeof(System.Threading.Tasks.Task));
        Assert.True(updateDomainMethod.ReturnType.BaseType == typeof(System.Threading.Tasks.Task));
        Assert.True(deleteDomainMethod.ReturnType == typeof(System.Threading.Tasks.Task));
    }

    private class TestHttpClientFactory : IHttpClientFactory
    {
        public HttpClient CreateClient(string name)
        {
            return new HttpClient();
        }
    }
}