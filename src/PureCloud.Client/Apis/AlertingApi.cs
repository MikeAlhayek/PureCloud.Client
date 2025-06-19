using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

public class AlertingApi : IAlertingApi
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly PureCloudJsonSerializerOptions _options;

    public AlertingApi(
        IHttpClientFactory httpClientFactory,
        IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClientFactory = httpClientFactory;
        _options = options.Value;
    }

    // get methods

    public async Task<CommonRule> GetAlertingRuleAsync(string ruleId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/alerting/rules/{ruleId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonAlert> GetAlertingAlertAsync(string alertId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.GetAsync($"api/v2/alerting/alerts/{alertId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonAlert>(_options.JsonSerializerOptions, cancellationToken);
    }

    // get methods

    // put methods

    public async Task<CommonAlert> PatchAlertingAlertAsync(string alertId, AlertRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync($"api/v2/alerting/alerts/{alertId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonAlert>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<bool> PatchAlertingAlertsAllAsync(CommonAllAlertUpdateRequest body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        // If body is null, send an empty object to avoid a null content (PATCH with no body is not always supported)
        var response = await client.PatchAsJsonAsync("api/v2/alerting/alerts/all", body ?? new CommonAllAlertUpdateRequest(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<BulkResponse> PatchAlertingAlertsBulkAsync(CommonAlertBulkUpdateRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/alerting/alerts/bulk", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkResponse> PatchAlertingRulesBulkAsync(CommonRuleBulkUpdateNotificationsRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PatchAsJsonAsync("api/v2/alerting/rules/bulk", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<AlertingUnreadStatus> PutAlertingAlertAsync(string alertId, AlertingUnreadStatus body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/alerting/alerts/{alertId}", body ?? new AlertingUnreadStatus(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlertingUnreadStatus>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonRule> PutAlertingRuleAsync(string ruleId, ModifiableRuleProperties body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PutAsJsonAsync($"api/v2/alerting/rules/{ruleId}", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    // put methods

    // post methods

    public async Task<AlertListing> PostAlertingAlertsQueryAsync(GetAlertQuery body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/alerting/alerts/query", body ?? new GetAlertQuery(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<AlertListing>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonRule> PostAlertingRulesAsync(CommonRule body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/alerting/rules", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonRule>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<BulkResponse> PostAlertingRulesBulkRemoveAsync(CommonRuleBulkDeleteRequest body, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/alerting/rules/bulk/remove", body, _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BulkResponse>(_options.JsonSerializerOptions, cancellationToken);
    }

    public async Task<CommonRuleContainer> PostAlertingRulesQueryAsync(GetRulesQuery body = null, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.PostAsJsonAsync("api/v2/alerting/rules/query", body ?? new GetRulesQuery(), _options.JsonSerializerOptions, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<CommonRuleContainer>(_options.JsonSerializerOptions, cancellationToken);
    }

    // post methods

    // delete methods

    public async Task<bool> DeleteAlertingAlertAsync(string alertId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/alerting/alerts/{alertId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAlertingAlertsAllAsync(CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync("api/v2/alerting/alerts/all", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAlertingRuleAsync(string ruleId, CancellationToken cancellationToken = default)
    {
        var client = _httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);

        var response = await client.DeleteAsync($"api/v2/alerting/rules/{ruleId}", cancellationToken);

        response.EnsureSuccessStatusCode();

        return response.IsSuccessStatusCode;
    }

    // delete methods

}
