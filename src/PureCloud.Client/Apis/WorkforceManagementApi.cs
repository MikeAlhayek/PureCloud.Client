using System.Collections.Specialized;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Options;
using PureCloud.Client.Contracts;
using PureCloud.Client.Http;
using PureCloud.Client.Json;
using PureCloud.Client.Models;

namespace PureCloud.Client.Apis;

/// <inheritdoc />
public sealed class WorkforceManagementApi : IWorkforceManagementApi
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _options;

    public WorkforceManagementApi(IHttpClientFactory httpClientFactory, IOptions<PureCloudJsonSerializerOptions> options)
    {
        _httpClient = httpClientFactory.CreateClient(PureCloudConstants.PureCloudClientName);
        _options = options.Value.JsonSerializerOptions;
    }

    /// <inheritdoc />
    public async Task<BusinessUnitListing> GetBusinessUnitsAsync(string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/businessunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<BusinessUnitResponse> GetBusinessUnitAsync(string businessUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BusinessUnitResponse>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<bool> DeleteManagementUnitAsync(string managementUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitAsync(string managementUnitId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetManagementUnitsAsync(int? pageSize = null, int? pageNumber = null, string expand = null, string feature = null, string divisionId = null, CancellationToken cancellationToken = default)
    {
        var parameters = new NameValueCollection();

        if (pageSize.HasValue)
        {
            parameters.Add("pageSize", UriHelper.ParameterToString(pageSize.Value));
        }

        if (pageNumber.HasValue)
        {
            parameters.Add("pageNumber", UriHelper.ParameterToString(pageNumber.Value));
        }

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        if (feature != null)
        {
            parameters.Add("feature", UriHelper.ParameterToString(feature));
        }

        if (divisionId != null)
        {
            parameters.Add("divisionId", UriHelper.ParameterToString(divisionId));
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/managementunits", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetAdherenceAsync(List<string> userId, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(userId);

        var parameters = new NameValueCollection();

        foreach (var id in userId)
        {
            parameters.Add("userId", id);
        }

        var uri = UriHelper.GetUri("api/v2/workforcemanagement/adherence", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetWorkPlansAsync(string managementUnitId, IEnumerable<string> expands = null, List<string> exclude = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);

        var parameters = new NameValueCollection();

        if (expands != null)
        {
            foreach (var expand in expands)
            {
                parameters.Add("expand", expand);
            }
        }

        if (exclude != null)
        {
            foreach (var item in exclude)
            {
                parameters.Add("exclude", item);
            }
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> CreateWorkPlanAsync(string managementUnitId, string body, string validationMode = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var parameters = new NameValueCollection();

        if (validationMode != null)
        {
            parameters.Add("validationMode", UriHelper.ParameterToString(validationMode));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/workplans", parameters);

        var content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(uri, content, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetMyManagementUnitAsync(CancellationToken cancellationToken = default)
    {
        var uri = "api/v2/workforcemanagement/agents/me/managementunit";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCodeContainer> GetActivityCodesAsync(string businessUnitId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCodeContainer>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<ActivityCode> CreateActivityCodeAsync(string businessUnitId, CreateActivityCodeRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<ActivityCode>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteActivityCodeAsync(string businessUnitId, string activityCodeId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(activityCodeId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/activitycodes/{Uri.EscapeDataString(activityCodeId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<BuScheduleListing> GetSchedulesAsync(string businessUnitId, string weekId, bool? includeOnlyPublished = null, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);

        var parameters = new NameValueCollection();

        if (includeOnlyPublished.HasValue)
        {
            parameters.Add("includeOnlyPublished", UriHelper.ParameterToString(includeOnlyPublished.Value));
        }

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<BuScheduleListing>(_options, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<string> GetScheduleAsync(string businessUnitId, string weekId, string scheduleId, string expand = null, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var parameters = new NameValueCollection();

        if (expand != null)
        {
            parameters.Add("expand", UriHelper.ParameterToString(expand));
        }

        var uri = UriHelper.GetUri($"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}", parameters);

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteScheduleAsync(string businessUnitId, string weekId, string scheduleId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekId);
        ArgumentException.ThrowIfNullOrEmpty(scheduleId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekId)}/schedules/{Uri.EscapeDataString(scheduleId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> GetForecastsAsync(string businessUnitId, string weekDateId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts";

        var response = await _httpClient.GetAsync(uri, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<bool> DeleteForecastAsync(string businessUnitId, string weekDateId, string forecastId, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(businessUnitId);
        ArgumentException.ThrowIfNullOrEmpty(weekDateId);
        ArgumentException.ThrowIfNullOrEmpty(forecastId);

        var uri = $"api/v2/workforcemanagement/businessunits/{Uri.EscapeDataString(businessUnitId)}/weeks/{Uri.EscapeDataString(weekDateId)}/shorttermforecasts/{Uri.EscapeDataString(forecastId)}";

        var response = await _httpClient.DeleteAsync(uri, cancellationToken);

        return response.IsSuccessStatusCode;
    }

    /// <inheritdoc />
    public async Task<string> CreateTimeOffRequestAsync(string managementUnitId, CreateAdminTimeOffRequest body, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrEmpty(managementUnitId);
        ArgumentNullException.ThrowIfNull(body);

        var uri = $"api/v2/workforcemanagement/managementunits/{Uri.EscapeDataString(managementUnitId)}/timeoffrequests";

        var response = await _httpClient.PostAsJsonAsync(uri, body, _options, cancellationToken);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync(cancellationToken);
    }
}
