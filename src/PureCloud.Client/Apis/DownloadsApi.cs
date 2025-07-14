using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;
public class DownloadsApi : IDownloadsApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public DownloadsApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    public async Task<UrlResponse> GetDownloadAsync(string downloadId, string contentDisposition = null, bool? issueRedirect = null, bool? redirectToAuth = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(downloadId);

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();

        if (contentDisposition != null)
        {
            parameters.Add("contentDisposition", UriHelper.ParameterToString(contentDisposition));
        }

        if (issueRedirect.HasValue)
        {
            parameters.Add("issueRedirect", UriHelper.ParameterToString(issueRedirect.Value));
        }

        if (redirectToAuth.HasValue)
        {
            parameters.Add("redirectToAuth", UriHelper.ParameterToString(redirectToAuth.Value));
        }

        var uri = UriHelper.GetUri($"api/v2/downloads/{downloadId}", parameters);

        var response = await client.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UrlResponse>(_options.JsonSerializerOptions, cancellationToken);
    }


}
