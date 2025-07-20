using System.Collections.Specialized;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public sealed class WorkforceManagementApi : IWorkforceManagementApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public WorkforceManagementApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    /// <inheritdoc />
    public async Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userIds, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var parameters = new NameValueCollection();
        if (userIds != null)
        {
            foreach (var id in userIds)
            {
                parameters.Add("userId", UriHelper.ParameterToString(id));
            }
        }

        var requestUri = UriHelper.GetUri("api/v2/workforcemanagement/adherence", parameters);
        var response = await client.GetAsync(requestUri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<UserScheduleAdherence[]>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/workforcemanagement/adherence/explanations/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryAdherenceExplanationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitActivityCode> PatchBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(businessUnitId))
            throw new ArgumentException("Business unit ID cannot be null or empty", nameof(businessUnitId));
        
        if (string.IsNullOrEmpty(activityCodeId))
            throw new ArgumentException("Activity code ID cannot be null or empty", nameof(activityCodeId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}", body ?? new UpdateActivityCodeRequest(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(businessUnitId))
            throw new ArgumentException("Business unit ID cannot be null or empty", nameof(businessUnitId));

        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }
}