using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Moq;
using PureCloud.Client.Apis;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;
using System.Net;
using System.Text;
using System.Text.Json;
using Xunit;

namespace PureCloud.Client.Tests;

public class TokensApiTests
{
    private readonly Mock<IHttpClientFactory> _httpClientFactoryMock;
    private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;
    private readonly HttpClient _httpClient;
    private readonly IOptions<PureCloudJsonSerializerOptions> _options;
    private readonly TokensApi _tokensApi;

    public TokensApiTests()
    {
        _httpClientFactoryMock = new Mock<IHttpClientFactory>();
        _httpMessageHandlerMock = new Mock<HttpMessageHandler>();
        
        _httpClient = new HttpClient(_httpMessageHandlerMock.Object)
        {
            BaseAddress = new Uri("https://api.mypurecloud.com/")
        };
        
        _httpClientFactoryMock.Setup(f => f.CreateClient(It.IsAny<string>()))
                             .Returns(_httpClient);

        _options = Options.Create(new PureCloudJsonSerializerOptions());
        _tokensApi = new TokensApi(_httpClientFactoryMock.Object, _options);
    }

    [Fact]
    public void TokensApi_ShouldImplementITokensApi()
    {
        // Arrange & Act & Assert
        Assert.IsAssignableFrom<ITokensApi>(_tokensApi);
    }

    [Fact]
    public void TokensApi_ShouldBeSealed()
    {
        // Arrange & Act & Assert
        Assert.True(typeof(TokensApi).IsSealed);
    }

    [Fact]
    public async Task DeleteTokenAsync_WithNullUserId_ShouldThrowArgumentNullException()
    {
        // Arrange & Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => _tokensApi.DeleteTokenAsync(null!));
    }

    [Fact]
    public async Task DeleteTokenAsync_WithEmptyUserId_ShouldThrowArgumentException()
    {
        // Arrange & Act & Assert
        await Assert.ThrowsAsync<ArgumentException>(() => _tokensApi.DeleteTokenAsync(""));
    }

    [Fact]
    public async Task UpdateTokensTimeoutAsync_WithNullBody_ShouldThrowArgumentNullException()
    {
        // Arrange & Act & Assert
        await Assert.ThrowsAsync<ArgumentNullException>(() => _tokensApi.UpdateTokensTimeoutAsync(null!));
    }
}