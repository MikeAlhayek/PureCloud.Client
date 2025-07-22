using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;

namespace PureCloud.Client.Apis;

public sealed class WebMessagingApi : IWebMessagingApi
{
    private readonly IHttpClientFactory _httpClientFactory;

    private readonly PureCloudJsonSerializerOptions _options;

    public WebMessagingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }


    public async Task<string> GetMessagesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", pageSize.Value.ToString());
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", pageNumber.Value.ToString());
        }

        var url = UriHelper.GetUri("api/v2/webmessaging/messages", parameters);

        var response = await client.GetAsync(url, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<string>(_options.JsonSerializerOptions, cancellationToken: cancellationToken);
    }

}
