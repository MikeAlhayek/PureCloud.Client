using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class WorkforceManagementApi : IWorkforceManagementApi
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

    // get methods

    public async Task<List<UserScheduleAdherence>> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        // Build query parameters for userId list
        var queryParams = new List<string>();
        if (userId != null)
        {
            foreach (var id in userId)
            {
                queryParams.Add($"userId={Uri.EscapeDataString(id)}");
            }
        }

        var queryString = queryParams.Count > 0 ? "?" + string.Join("&", queryParams) : "";
        var response = await client.GetAsync($"api/v2/workforcemanagement/adherence{queryString}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<UserScheduleAdherence>>(_options.JsonSerializerOptions, cancellationToken);
    }

    // get methods

    // post methods

    public async Task<QueryAdherenceExplanationsResponse> CreateAdherenceExplanationsQueryAsync(AgentQueryAdherenceExplanationsRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/workforcemanagement/adherence/explanations/query", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<QueryAdherenceExplanationsResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    // post methods

    // patch methods

    public async Task<BusinessUnitActivityCode> PatchBusinessUnitActivityCodeAsync(string businessUnitId, string activityCodeId, UpdateActivityCodeRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/workforcemanagement/businessunits/{businessUnitId}/activitycodes/{activityCodeId}", body ?? new UpdateActivityCodeRequest(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitActivityCode>(_options.JsonSerializerOptions, cancellationToken);
    }

    // patch methods

    // put methods

    // delete methods

    public async Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/workforcemanagement/businessunits/{businessUnitId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    // delete methods

}